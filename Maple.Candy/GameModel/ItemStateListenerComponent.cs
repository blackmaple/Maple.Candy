
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.Candy
{
    
    
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."ItemStateListenerComponent"]
    /// [System.Object]
    /// [Entitas.IComponent]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000261U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [73, 116, 101, 109, 83, 116, 97, 116, 101, 76, 105, 115, 116, 101, 110, 101, 114, 67, 111, 109, 112, 111, 110, 101, 110, 116])]
    
                
    // class 0x10 System.Collections.Generic.List<IItemStateListener> value
     [MonoCollectorSearchFieldAttribute(typeof(PMonoList_S<ItemView.Ptr_ItemView>),"value", "VALUE")]
    public partial class ItemStateListenerComponent
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "ItemStateListenerComponent";
        //public static byte[] Static_ClassName { get; } = [73, 116, 101, 109, 83, 116, 97, 116, 101, 76, 105, 115, 116, 101, 110, 101, 114, 67, 111, 109, 112, 111, 110, 101, 110, 116];

        //public const uint Const_TypeToken = 0x02000261U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ItemStateListenerComponent(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ItemStateListenerComponent(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ItemStateListenerComponent obj) => obj._ptr;
            public static implicit operator bool(Ptr_ItemStateListenerComponent obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll".""."ItemStateListenerComponent"]
        /// </summary>
        public partial class ItemStateListenerComponent
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();
            
            

            
            /// public static partial class Search_ItemStateListenerComponent
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}