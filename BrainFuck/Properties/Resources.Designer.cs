﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrainFuck.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BrainFuck.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .equ ROM, 0x0000
        ///.equ RAM, 0x1000
        ///.equ LEDS, 0x2000
        ///.equ WAIT_TIME, 0x0FFF
        ///
        ///main:
        ///	addi sp, zero, RAM
        ///	add t0, zero, zero
        ///
        ///	addi s0, zero, WAIT_TIME
        ///	slli s0, s0, 10
        ///	addi s0, s0, WAIT_TIME
        ///
        ///	;init RAM to 0
        ///	addi t1, zero, RAM
        ///	addi t2, zero, LEDS
        ///ram_init_loop:
        ///	beq t1, t2, ram_init_end
        ///		stw zero, 0(t1)
        ///		addi t1, t1, 4
        ///		br ram_init_loop
        ///ram_init_end:
        ///
        ///	;CODE#
        ///	break
        ///
        ///print:
        ///	ldw t0, 0(sp)
        ///	andi t0, t0, 0xFF ; We act as if it was a byte
        ///	slli t0, t0, 2
        ///	ldw t1, font_data(t0) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string structure {
            get {
                return ResourceManager.GetString("structure", resourceCulture);
            }
        }
    }
}