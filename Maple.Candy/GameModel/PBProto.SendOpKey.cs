
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
    /// class ["SimpleKcpNet.dll"."PBProto"."SendOpKey"]
    /// [System.Object]
    /// [ProtoBuf.IExtensible]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108], 0x02000017U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108], [80, 66, 80, 114, 111, 116, 111], [83, 101, 110, 100, 79, 112, 75, 101, 121])]
    
                
    // interface 0x10 ProtoBuf.IExtension __pbn__extensionData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"__pbn__extensionData", "__PBN__EXTENSION_DATA")]
            
    // struct 0x18 System.UInt32 <roomID>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"<roomID>k__BackingField", "ROOM_ID")]
            
    // class 0x20 PBProto.OpKey <opKey>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<opKey>k__BackingField", "OP_KEY")]
    public partial class SendOpKey
    { 
        //public const string Const_ImageName = "SimpleKcpNet.dll";
        //public static byte[] Static_ImageName { get; } = [83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108];

        //public const string Const_Namespace = "PBProto";
        //public static byte[] Static_Namespace { get; } = [80, 66, 80, 114, 111, 116, 111];

        //public const string Const_ClassName = "SendOpKey";
        //public static byte[] Static_ClassName { get; } = [83, 101, 110, 100, 79, 112, 75, 101, 121];

        //public const uint Const_TypeToken = 0x02000017U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SendOpKey(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SendOpKey(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SendOpKey obj) => obj._ptr;
            public static implicit operator bool(Ptr_SendOpKey obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["SimpleKcpNet.dll"."PBProto"."SendOpKey"]
        /// </summary>
        public partial class SendOpKey
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            ///   PBProto.OpKey get_opKey()
            /// </summary>
            /// <returns>class PBProto.OpKey</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_opKey")]
            ///  extern nint GET_OP_KEY ();

            
            /// <summary>
            ///   System.UInt32 get_roomID()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_roomID")]
            ///  extern System.UInt32 GET_ROOM_ID ();

            
            /// <summary>
            ///   ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(System.Boolean createIfMissing)
            /// </summary>
            /// <param name="createIfMissing">struct System.Boolean</param>
            /// <returns>interface ProtoBuf.IExtension</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("global::ProtoBuf.IExtensible.GetExtensionObject")]
            ///  extern nint GLOBAL::PROTO_BUF.I_EXTENSIBLE.GET_EXTENSION_OBJECT (System.Boolean createIfMissing);

            
            /// <summary>
            ///   System.Void set_opKey(PBProto.OpKey value)
            /// </summary>
            /// <param name="value">class PBProto.OpKey</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_opKey")]
            ///  extern void SET_OP_KEY (nint value);

            
            /// <summary>
            ///   System.Void set_roomID(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_roomID")]
            ///  extern void SET_ROOM_ID (System.UInt32 value);
            
            

            
            /// public static partial class Search_SendOpKey
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}