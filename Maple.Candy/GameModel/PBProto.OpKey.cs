
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
    /// class ["SimpleKcpNet.dll"."PBProto"."OpKey"]
    /// [System.Object]
    /// [ProtoBuf.IExtensible]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108], 0x02000024U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108], [80, 66, 80, 114, 111, 116, 111], [79, 112, 75, 101, 121])]
    
                
    // interface 0x10 ProtoBuf.IExtension __pbn__extensionData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"__pbn__extensionData", "__PBN__EXTENSION_DATA")]
            
    // struct 0x18 System.UInt32 <opIndex>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"<opIndex>k__BackingField", "OP_INDEX")]
            
    // enum 0x1C PBProto.KeyType <keyType>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(PBProto.KeyType),"<keyType>k__BackingField", "KEY_TYPE")]
            
    // struct 0x20 System.Nullable<System.UInt32> __pbn__emoID
    // [MonoCollectorSearchFieldAttribute(typeof(System.Nullable<System.UInt32>),"__pbn__emoID", "__PBN__EMO_ID")]
            
    // class 0x28 PBProto.MoveKey <moveKey>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<moveKey>k__BackingField", "MOVE_KEY")]
            
    // class 0x30 PBProto.BombKey <bombKey>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<bombKey>k__BackingField", "BOMB_KEY")]
            
    // class 0x38 PBProto.BagKey <bagKey>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<bagKey>k__BackingField", "BAG_KEY")]
            
    // class 0x40 PBProto.SyncInfo <syncInfos>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<syncInfos>k__BackingField", "SYNC_INFOS")]
    public partial class OpKey
    { 
        //public const string Const_ImageName = "SimpleKcpNet.dll";
        //public static byte[] Static_ImageName { get; } = [83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108];

        //public const string Const_Namespace = "PBProto";
        //public static byte[] Static_Namespace { get; } = [80, 66, 80, 114, 111, 116, 111];

        //public const string Const_ClassName = "OpKey";
        //public static byte[] Static_ClassName { get; } = [79, 112, 75, 101, 121];

        //public const uint Const_TypeToken = 0x02000024U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_OpKey(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_OpKey(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_OpKey obj) => obj._ptr;
            public static implicit operator bool(Ptr_OpKey obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["SimpleKcpNet.dll"."PBProto"."OpKey"]
        /// </summary>
        public partial class OpKey
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            ///   PBProto.BagKey get_bagKey()
            /// </summary>
            /// <returns>class PBProto.BagKey</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bagKey")]
            ///  extern nint GET_BAG_KEY ();

            
            /// <summary>
            ///   PBProto.BombKey get_bombKey()
            /// </summary>
            /// <returns>class PBProto.BombKey</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombKey")]
            ///  extern nint GET_BOMB_KEY ();

            
            /// <summary>
            ///   System.UInt32 get_emoID()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_emoID")]
            ///  extern System.UInt32 GET_EMO_ID ();

            
            /// <summary>
            ///   PBProto.KeyType get_keyType()
            /// </summary>
            /// <returns>enum PBProto.KeyType</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_keyType")]
            ///  extern PBProto.KeyType GET_KEY_TYPE ();

            
            /// <summary>
            ///   PBProto.MoveKey get_moveKey()
            /// </summary>
            /// <returns>class PBProto.MoveKey</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_moveKey")]
            ///  extern nint GET_MOVE_KEY ();

            
            /// <summary>
            ///   System.UInt32 get_opIndex()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_opIndex")]
            ///  extern System.UInt32 GET_OP_INDEX ();

            
            /// <summary>
            ///   PBProto.SyncInfo get_syncInfos()
            /// </summary>
            /// <returns>class PBProto.SyncInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_syncInfos")]
            ///  extern nint GET_SYNC_INFOS ();

            
            /// <summary>
            ///   ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(System.Boolean createIfMissing)
            /// </summary>
            /// <param name="createIfMissing">struct System.Boolean</param>
            /// <returns>interface ProtoBuf.IExtension</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("global::ProtoBuf.IExtensible.GetExtensionObject")]
            ///  extern nint GLOBAL::PROTO_BUF.I_EXTENSIBLE.GET_EXTENSION_OBJECT (System.Boolean createIfMissing);

            
            /// <summary>
            ///   System.Void ResetemoID()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetemoID")]
            ///  extern void RESETEMO_ID ();

            
            /// <summary>
            ///   System.Void set_bagKey(PBProto.BagKey value)
            /// </summary>
            /// <param name="value">class PBProto.BagKey</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_bagKey")]
            ///  extern void SET_BAG_KEY (nint value);

            
            /// <summary>
            ///   System.Void set_bombKey(PBProto.BombKey value)
            /// </summary>
            /// <param name="value">class PBProto.BombKey</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_bombKey")]
            ///  extern void SET_BOMB_KEY (nint value);

            
            /// <summary>
            ///   System.Void set_emoID(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_emoID")]
            ///  extern void SET_EMO_ID (System.UInt32 value);

            
            /// <summary>
            ///   System.Void set_keyType(PBProto.KeyType value)
            /// </summary>
            /// <param name="value">enum PBProto.KeyType</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_keyType")]
            ///  extern void SET_KEY_TYPE (PBProto.KeyType value);

            
            /// <summary>
            ///   System.Void set_moveKey(PBProto.MoveKey value)
            /// </summary>
            /// <param name="value">class PBProto.MoveKey</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_moveKey")]
            ///  extern void SET_MOVE_KEY (nint value);

            
            /// <summary>
            ///   System.Void set_opIndex(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_opIndex")]
            ///  extern void SET_OP_INDEX (System.UInt32 value);

            
            /// <summary>
            ///   System.Void set_syncInfos(PBProto.SyncInfo value)
            /// </summary>
            /// <param name="value">class PBProto.SyncInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_syncInfos")]
            ///  extern void SET_SYNC_INFOS (nint value);

            
            /// <summary>
            ///   System.Boolean ShouldSerializeemoID()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldSerializeemoID")]
            ///  extern System.Boolean SHOULD_SERIALIZEEMO_ID ();
            
            

            
            /// public static partial class Search_OpKey
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}