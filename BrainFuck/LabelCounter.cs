// <copyright company="Oswald MASKENS" file="LabelCounter.cs">
// Copyright 2014-2016 Oswald MASKENS
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
// 
//  http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
// </copyright>

using System.Collections.Generic;

namespace BrainFuck
{
    /// <summary>
    ///     The label counter.
    /// </summary>
    public class LabelCounter
    {
        /// <summary>
        ///     The end labels.
        /// </summary>
        private readonly Stack<int> endLabels = new Stack<int>();

        /// <summary>
        ///     The labels.
        /// </summary>
        private readonly Stack<int> startLabels = new Stack<int>();

        /// <summary>
        ///     The i.
        /// </summary>
        private int i = -1;

        /// <summary>
        ///     The gen next.
        /// </summary>
        public void GenNext()
        {
            this.i += 1;
            this.startLabels.Push(this.i);

            this.i += 1;
            this.endLabels.Push(this.i);
        }

        /// <summary>
        ///     The pop end.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string PopEnd()
        {
            return $"label{this.endLabels.Pop()}";
        }

        /// <summary>
        ///     The pop start.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string PopStart()
        {
            return $"label{this.startLabels.Pop()}";
        }

        /// <summary>
        ///     The top end.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string TopEnd()
        {
            return $"label{this.endLabels.Peek()}";
        }

        /// <summary>
        ///     The top start.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string TopStart()
        {
            return $"label{this.startLabels.Peek()}";
        }
    }
}