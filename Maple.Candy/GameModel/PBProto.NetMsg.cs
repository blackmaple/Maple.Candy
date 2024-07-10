
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
    /// class ["SimpleKcpNet.dll"."PBProto"."NetMsg"]
    /// [System.Object]
    /// [ProtoBuf.IExtensible]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108], 0x02000002U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108], [80, 66, 80, 114, 111, 116, 111], [78, 101, 116, 77, 115, 103])]
    
                
    // interface 0x10 ProtoBuf.IExtension __pbn__extensionData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"__pbn__extensionData", "__PBN__EXTENSION_DATA")]
            
    // class 0x18 PBProto.Head <Head>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Head>k__BackingField", "HEAD")]
            
    // class 0x20 PBProto.Body <Body>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<Body>k__BackingField", "BODY")]
    public partial class NetMsg
    { 
        //public const string Const_ImageName = "SimpleKcpNet.dll";
        //public static byte[] Static_ImageName { get; } = [83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108];

        //public const string Const_Namespace = "PBProto";
        //public static byte[] Static_Namespace { get; } = [80, 66, 80, 114, 111, 116, 111];

        //public const string Const_ClassName = "NetMsg";
        //public static byte[] Static_ClassName { get; } = [78, 101, 116, 77, 115, 103];

        //public const uint Const_TypeToken = 0x02000002U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_NetMsg(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_NetMsg(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_NetMsg obj) => obj._ptr;
            public static implicit operator bool(Ptr_NetMsg obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["SimpleKcpNet.dll"."PBProto"."NetMsg"]
        /// </summary>
        public partial class NetMsg
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            ///   PBProto.Body get_Body()
            /// </summary>
            /// <returns>class PBProto.Body</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Body")]
            ///  extern nint GET_BODY ();

            
            /// <summary>
            ///   PBProto.Head get_Head()
            /// </summary>
            /// <returns>class PBProto.Head</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Head")]
            ///  extern nint GET_HEAD ();

            
            /// <summary>
            ///   ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(System.Boolean createIfMissing)
            /// </summary>
            /// <param name="createIfMissing">struct System.Boolean</param>
            /// <returns>interface ProtoBuf.IExtension</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("global::ProtoBuf.IExtensible.GetExtensionObject")]
            ///  extern nint GLOBAL::PROTO_BUF.I_EXTENSIBLE.GET_EXTENSION_OBJECT (System.Boolean createIfMissing);

            
            /// <summary>
            ///   System.Void set_Body(PBProto.Body value)
            /// </summary>
            /// <param name="value">class PBProto.Body</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Body")]
            ///  extern void SET_BODY (nint value);

            
            /// <summary>
            ///   System.Void set_Head(PBProto.Head value)
            /// </summary>
            /// <param name="value">class PBProto.Head</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Head")]
            ///  extern void SET_HEAD (nint value);
            
            

            
            /// public static partial class Search_NetMsg
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}