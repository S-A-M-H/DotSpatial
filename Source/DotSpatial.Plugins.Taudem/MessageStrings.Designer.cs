﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotSpatial.Plugins.Taudem {
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
    internal class MessageStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessageStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotSpatial.Plugins.Taudem.MessageStrings", typeof(MessageStrings).Assembly);
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
        ///   Looks up a localized string similar to Application Error.
        /// </summary>
        internal static string ApplicationError {
            get {
                return ResourceManager.GetString("ApplicationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automatic Watershed Delineation encountered an error which generally occurs from too many outlets/inlets being delineated, especially ones close together. Please lower the snap threshold and rerun to minimize outlets/inlets not direclty on the streams..
        /// </summary>
        internal static string AutomaticWatershedDilineationEncounteredError {
            get {
                return ResourceManager.GetString("AutomaticWatershedDilineationEncounteredError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error in opening {0}.
        /// </summary>
        internal static string ErrorInOpening {
            get {
                return ResourceManager.GetString("ErrorInOpening", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} does not exists!.
        /// </summary>
        internal static string FileDoesNotExists {
            get {
                return ResourceManager.GetString("FileDoesNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TauDEM Error {0}.
        /// </summary>
        internal static string TaudemError {
            get {
                return ResourceManager.GetString("TaudemError", resourceCulture);
            }
        }
    }
}
