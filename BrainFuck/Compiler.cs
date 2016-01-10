// <copyright company="Oswald MASKENS" file="Compiler.cs">
// Copyright 2014-2016 Oswald MASKENS
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
// 
//  http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrainFuck
{
    /// <summary>
    ///     The compiler.
    /// </summary>
    public static class Compiler
    {
        /// <summary>
        ///     The compile.
        /// </summary>
        /// <param name="source">
        ///     The source.
        /// </param>
        /// <returns>
        ///     The assembly code
        /// </returns>
        public static string[] Compile(string[] source)
        {
            var instructions = new[] {'>', '<', '+', '-', '.', ',', '[', ']'};

            // Get the code as a nice string !
            var sb = new StringBuilder();
            foreach (var line in source)
            {
                sb.Append(line);
            }

            char[] code = sb.ToString().Where(instructions.Contains).ToArray();

            // Not supported yet ...
            if (code.Any(instr => instr == ','))
            {
                return null;
            }

            // Assembly to be outputed in the structure.asm file
            var output = new List<string>();
            var labels = new LabelCounter();
            var count = 1;
            var countType = code[0];

            for (var i = 1; i < code.Length; i += 1)
            {
                if (countType != code[i])
                {
                    output.Add(string.Empty);

                    switch (countType)
                    {
                        case '>':
                            output.Add("addi sp, sp, " + (4*count));
                            break;
                        case '<':
                            output.Add("addi sp, sp, -" + (4*count));
                            break;
                        case '+':
                            output.Add("ldw t0, 0(sp)");
                            output.Add("addi t0, t0, " + count);
                            output.Add("stw t0, 0(sp)");
                            break;
                        case '-':
                            output.Add("ldw t0, 0(sp)");
                            output.Add("addi t0, t0, -" + count);
                            output.Add("stw t0, 0(sp)");
                            break;
                        case '.':
                            for (var j = 0; j < count; j += 1)
                            {
                                output.Add("call print");
                            }

                            break;
                        case ',':
                            throw new Exception(", is not supported yet !");
                        case '[':
                            for (var j = 0; j < count; j += 1)
                            {
                                labels.GenNext();
                                output.Add("ldw t0, 0(sp)");
                                output.Add("beq t0, zero, " + labels.TopEnd());
                                output.Add(labels.TopStart() + ":");
                            }

                            break;
                        case ']':
                            for (var j = 0; j < count; j += 1)
                            {
                                output.Add("ldw t0, 0(sp)");
                                output.Add("bne t0, zero, " + labels.PopStart());
                                output.Add(labels.PopEnd() + ":");
                            }

                            break;
                        default:
                            throw new Exception("How the fuck did you get here ?");
                    }

                    count = 1;
                    countType = code[i];
                }
                else
                {
                    count += 1;
                }
            }

            return output.ToArray();
        }
    }
}