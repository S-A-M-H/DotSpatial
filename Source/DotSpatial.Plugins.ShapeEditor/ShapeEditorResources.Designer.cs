﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DotSpatial.Plugins.ShapeEditor {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    internal class ShapeEditorResources {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ShapeEditorResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("DotSpatial.Plugins.ShapeEditor.ShapeEditorResources", typeof(ShapeEditorResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add Shape.
        /// </summary>
        internal static string Add_Shape {
            get {
                return ResourceManager.GetString("Add_Shape", resourceCulture);
            }
        }
        
        internal static Bitmap move {
            get {
                object obj = ResourceManager.GetObject("move", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move Vertex.
        /// </summary>
        internal static string Move_Vertex {
            get {
                return ResourceManager.GetString("Move_Vertex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New.
        /// </summary>
        internal static string New {
            get {
                return ResourceManager.GetString("New", resourceCulture);
            }
        }
        
        internal static Icon NewShape {
            get {
                object obj = ResourceManager.GetObject("NewShape", resourceCulture);
                return ((Icon)(obj));
            }
        }
        
        internal static Icon NewShapefile {
            get {
                object obj = ResourceManager.GetObject("NewShapefile", resourceCulture);
                return ((Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Snapping.
        /// </summary>
        internal static string Snapping {
            get {
                return ResourceManager.GetString("Snapping", resourceCulture);
            }
        }
        
        internal static Icon SnappingIcon {
            get {
                object obj = ResourceManager.GetObject("SnappingIcon", resourceCulture);
                return ((Icon)(obj));
            }
        }
    }
}
