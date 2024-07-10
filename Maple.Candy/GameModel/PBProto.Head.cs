
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
    /// class ["SimpleKcpNet.dll"."PBProto"."Head"]
    /// [System.Object]
    /// [ProtoBuf.IExtensible]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108], 0x02000003U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108], [80, 66, 80, 114, 111, 116, 111], [72, 101, 97, 100])]
    
                
    // interface 0x10 ProtoBuf.IExtension __pbn__extensionData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"__pbn__extensionData", "__PBN__EXTENSION_DATA")]
            
    // enum 0x18 PBProto.Cmd <Cmd>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(PBProto.Cmd),"<Cmd>k__BackingField", "CMD")]
            
    // enum 0x1C PBProto.ErrorCode <errorCode>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(PBProto.ErrorCode),"<errorCode>k__BackingField", "ERROR_CODE")]
    public partial class Head
    { 
        //public const string Const_ImageName = "SimpleKcpNet.dll";
        //public static byte[] Static_ImageName { get; } = [83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108];

        //public const string Const_Namespace = "PBProto";
        //public static byte[] Static_Namespace { get; } = [80, 66, 80, 114, 111, 116, 111];

        //public const string Const_ClassName = "Head";
        //public static byte[] Static_ClassName { get; } = [72, 101, 97, 100];

        //public const uint Const_TypeToken = 0x02000003U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Head(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Head(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Head obj) => obj._ptr;
            public static implicit operator bool(Ptr_Head obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["SimpleKcpNet.dll"."PBProto"."Head"]
        /// </summary>
        public partial class Head
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            ///   PBProto.Cmd get_Cmd()
            /// </summary>
            /// <returns>enum PBProto.Cmd</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Cmd")]
            ///  extern PBProto.Cmd GET_CMD ();

            
            /// <summary>
            ///   PBProto.ErrorCode get_errorCode()
            /// </summary>
            /// <returns>enum PBProto.ErrorCode</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_errorCode")]
            ///  extern PBProto.ErrorCode GET_ERROR_CODE ();

            
            /// <summary>
            ///   ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(System.Boolean createIfMissing)
            /// </summary>
            /// <param name="createIfMissing">struct System.Boolean</param>
            /// <returns>interface ProtoBuf.IExtension</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("global::ProtoBuf.IExtensible.GetExtensionObject")]
            ///  extern nint GLOBAL::PROTO_BUF.I_EXTENSIBLE.GET_EXTENSION_OBJECT (System.Boolean createIfMissing);

            
            /// <summary>
            ///   System.Void set_Cmd(PBProto.Cmd value)
            /// </summary>
            /// <param name="value">enum PBProto.Cmd</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Cmd")]
            ///  extern void SET_CMD (PBProto.Cmd value);

            
            /// <summary>
            ///   System.Void set_errorCode(PBProto.ErrorCode value)
            /// </summary>
            /// <param name="value">enum PBProto.ErrorCode</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_errorCode")]
            ///  extern void SET_ERROR_CODE (PBProto.ErrorCode value);
            
            

            
            /// public static partial class Search_Head
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}