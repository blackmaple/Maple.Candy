
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
    /// class ["SimpleKcpNet.dll"."PBProto"."Body"]
    /// [System.Object]
    /// [ProtoBuf.IExtensible]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108], 0x02000004U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108], [80, 66, 80, 114, 111, 116, 111], [66, 111, 100, 121])]
    
                
    // interface 0x10 ProtoBuf.IExtension __pbn__extensionData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"__pbn__extensionData", "__PBN__EXTENSION_DATA")]
            
    // class 0x18 PBProto.RequestLogin <reqLogin>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqLogin>k__BackingField", "REQ_LOGIN")]
            
    // class 0x20 PBProto.ReplyLogin <repLogin>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repLogin>k__BackingField", "REP_LOGIN")]
            
    // class 0x28 PBProto.RequestPing <reqPing>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqPing>k__BackingField", "REQ_PING")]
            
    // class 0x30 PBProto.ReplyPing <repPing>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repPing>k__BackingField", "REP_PING")]
            
    // class 0x38 PBProto.RequestCreate <reqCreate>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqCreate>k__BackingField", "REQ_CREATE")]
            
    // class 0x40 PBProto.ReplyCreate <repCreate>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repCreate>k__BackingField", "REP_CREATE")]
            
    // class 0x48 PBProto.ReplyRankBattleInfo <repRankBattleInfo>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRankBattleInfo>k__BackingField", "REP_RANK_BATTLE_INFO")]
            
    // class 0x50 PBProto.RequestMatch <reqMatch>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqMatch>k__BackingField", "REQ_MATCH")]
            
    // class 0x58 PBProto.ReplyMatch <repMatch>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repMatch>k__BackingField", "REP_MATCH")]
            
    // class 0x60 PBProto.NotifyMatchSuccess <ntfMatchSuccess>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<ntfMatchSuccess>k__BackingField", "NTF_MATCH_SUCCESS")]
            
    // class 0x68 PBProto.NotifyConfirm <ntfConfirm>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<ntfConfirm>k__BackingField", "NTF_CONFIRM")]
            
    // class 0x70 PBProto.SendConfirm <sndConfirm>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<sndConfirm>k__BackingField", "SND_CONFIRM")]
            
    // class 0x78 PBProto.NotifyLoadRes <ntfLoadRes>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<ntfLoadRes>k__BackingField", "NTF_LOAD_RES")]
            
    // class 0x80 PBProto.SendLoadProgress <sndLoadProgress>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<sndLoadProgress>k__BackingField", "SND_LOAD_PROGRESS")]
            
    // class 0x88 PBProto.NotifyLoadProgress <ntfLoadProgress>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<ntfLoadProgress>k__BackingField", "NTF_LOAD_PROGRESS")]
            
    // class 0x90 PBProto.RequestBattleStart <reqBattleStart>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqBattleStart>k__BackingField", "REQ_BATTLE_START")]
            
    // class 0x98 PBProto.RequestBattleEnd <reqBattleEnd>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqBattleEnd>k__BackingField", "REQ_BATTLE_END")]
            
    // class 0xA0 PBProto.NotifyNextframe <ntfNextFrame>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<ntfNextFrame>k__BackingField", "NTF_NEXT_FRAME")]
            
    // struct 0xA8 System.Nullable<System.Boolean> __pbn__isEmpty
    // [MonoCollectorSearchFieldAttribute(typeof(System.Nullable<System.Boolean>),"__pbn__isEmpty", "__PBN__IS_EMPTY")]
            
    // class 0xB0 PBProto.SendOpKey <sndOpKey>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<sndOpKey>k__BackingField", "SND_OP_KEY")]
            
    // class 0xB8 PBProto.NotifyOffline <ntfOffline>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<ntfOffline>k__BackingField", "NTF_OFFLINE")]
            
    // class 0xC0 PBProto.RequestShopBuy <reqShopBuy>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqShopBuy>k__BackingField", "REQ_SHOP_BUY")]
            
    // class 0xC8 PBProto.ReplyShopBuy <repShopBuy>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repShopBuy>k__BackingField", "REP_SHOP_BUY")]
            
    // class 0xD0 PBProto.ReplyBagInfo <repBagInfo>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repBagInfo>k__BackingField", "REP_BAG_INFO")]
            
    // class 0xD8 PBProto.RequestRankList <reqRankList>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRankList>k__BackingField", "REQ_RANK_LIST")]
            
    // class 0xE0 PBProto.ReplyRankList <repRankList>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRankList>k__BackingField", "REP_RANK_LIST")]
            
    // class 0xE8 PBProto.RequestRoomCreate <reqRoomCreate>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomCreate>k__BackingField", "REQ_ROOM_CREATE")]
            
    // class 0xF0 PBProto.ReplyRoomCreate <repRoomCreate>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomCreate>k__BackingField", "REP_ROOM_CREATE")]
            
    // class 0xF8 PBProto.RequestRoomRandomRoomID <reqRoomRandomRoomID>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomRandomRoomID>k__BackingField", "REQ_ROOM_RANDOM_ROOM_ID")]
            
    // class 0x100 PBProto.ReplyRoomRandomRoomID <repRoomRandomRoomID>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomRandomRoomID>k__BackingField", "REP_ROOM_RANDOM_ROOM_ID")]
            
    // class 0x108 PBProto.RequestRoomJoin <reqRoomJoin>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomJoin>k__BackingField", "REQ_ROOM_JOIN")]
            
    // class 0x110 PBProto.ReplyRoomJoin <repRoomJoin>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomJoin>k__BackingField", "REP_ROOM_JOIN")]
            
    // class 0x118 PBProto.NotifyRoomPosInfo <notifyRoomPosInfo>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<notifyRoomPosInfo>k__BackingField", "NOTIFY_ROOM_POS_INFO")]
            
    // class 0x120 PBProto.RequestRoomDestroy <reqRoomDestroy>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomDestroy>k__BackingField", "REQ_ROOM_DESTROY")]
            
    // class 0x128 PBProto.ReplyRoomDestroy <repRoomDestroy>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomDestroy>k__BackingField", "REP_ROOM_DESTROY")]
            
    // class 0x130 PBProto.NotifyRoomDestroy <notifyRoomDestroy>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<notifyRoomDestroy>k__BackingField", "NOTIFY_ROOM_DESTROY")]
            
    // class 0x138 PBProto.RequestRoomOwnerSwitchDoor <reqRoomOwnerSwitchDoor>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomOwnerSwitchDoor>k__BackingField", "REQ_ROOM_OWNER_SWITCH_DOOR")]
            
    // class 0x140 PBProto.ReplyRoomOwnerSwitchDoor <repRoomOwnerSwitchDoor>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomOwnerSwitchDoor>k__BackingField", "REP_ROOM_OWNER_SWITCH_DOOR")]
            
    // class 0x148 PBProto.RequestRoomOwnerKick <reqRoomOwnerKick>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomOwnerKick>k__BackingField", "REQ_ROOM_OWNER_KICK")]
            
    // class 0x150 PBProto.ReplyRoomOwnerKick <repRoomOwnerKick>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomOwnerKick>k__BackingField", "REP_ROOM_OWNER_KICK")]
            
    // class 0x158 PBProto.RequestRoomOwnerSelectMap <reqRoomOwnerSelectMap>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomOwnerSelectMap>k__BackingField", "REQ_ROOM_OWNER_SELECT_MAP")]
            
    // class 0x160 PBProto.ReplyRoomOwnerSelectMap <repRoomOwnerSelectMap>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomOwnerSelectMap>k__BackingField", "REP_ROOM_OWNER_SELECT_MAP")]
            
    // class 0x168 PBProto.NotifyRoomOwnerSelectMap <notifyRoomOwnerSelectMap>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<notifyRoomOwnerSelectMap>k__BackingField", "NOTIFY_ROOM_OWNER_SELECT_MAP")]
            
    // class 0x170 PBProto.RequestRoomSwitchReady <reqRoomSwitchReady>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomSwitchReady>k__BackingField", "REQ_ROOM_SWITCH_READY")]
            
    // class 0x178 PBProto.ReplyRoomSwitchReady <repRoomSwitchReady>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomSwitchReady>k__BackingField", "REP_ROOM_SWITCH_READY")]
            
    // class 0x180 PBProto.RequestRoomChangeSeat <reqRoomChangeSeat>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomChangeSeat>k__BackingField", "REQ_ROOM_CHANGE_SEAT")]
            
    // class 0x188 PBProto.ReplyRoomChangeSeat <repRoomChangeSeat>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomChangeSeat>k__BackingField", "REP_ROOM_CHANGE_SEAT")]
            
    // class 0x190 PBProto.RequestRoomLeave <reqRoomLeave>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomLeave>k__BackingField", "REQ_ROOM_LEAVE")]
            
    // class 0x198 PBProto.ReplyRoomLeave <repRoomLeave>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomLeave>k__BackingField", "REP_ROOM_LEAVE")]
            
    // class 0x1A0 PBProto.RequestRoomOwnerGameStart <reqRoomOwnerGameStart>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomOwnerGameStart>k__BackingField", "REQ_ROOM_OWNER_GAME_START")]
            
    // class 0x1A8 PBProto.ReplyRoomOwnerGameStart <repRoomOwnerGameStart>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomOwnerGameStart>k__BackingField", "REP_ROOM_OWNER_GAME_START")]
            
    // class 0x1B0 PBProto.ReuqestRoomChat <reqRoomChat>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomChat>k__BackingField", "REQ_ROOM_CHAT")]
            
    // class 0x1B8 PBProto.ReplyRoomChat <repRoomChat>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomChat>k__BackingField", "REP_ROOM_CHAT")]
            
    // class 0x1C0 PBProto.NotifyRoomChat <notifyRoomChat>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<notifyRoomChat>k__BackingField", "NOTIFY_ROOM_CHAT")]
            
    // class 0x1C8 PBProto.RequestRoomBattleExit <reqRoomBattleExit>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomBattleExit>k__BackingField", "REQ_ROOM_BATTLE_EXIT")]
            
    // class 0x1D0 PBProto.ReplyRoomBattleExit <repRoomBattleExit>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomBattleExit>k__BackingField", "REP_ROOM_BATTLE_EXIT")]
            
    // class 0x1D8 PBProto.RequestRoomsNum <reqRoomsNum>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomsNum>k__BackingField", "REQ_ROOMS_NUM")]
            
    // class 0x1E0 PBProto.ReplyRoomsNum <repRoomsNum>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomsNum>k__BackingField", "REP_ROOMS_NUM")]
            
    // class 0x1E8 PBProto.RequestRoomList <reqRoomList>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRoomList>k__BackingField", "REQ_ROOM_LIST")]
            
    // class 0x1F0 PBProto.ReplyRoomList <repRoomList>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRoomList>k__BackingField", "REP_ROOM_LIST")]
            
    // class 0x1F8 PBProto.RequestRandomJoinRoom <reqRandomJoinRoom>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRandomJoinRoom>k__BackingField", "REQ_RANDOM_JOIN_ROOM")]
            
    // class 0x200 PBProto.ReplyRandomJoinRoom <repRandomJoinRoom>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRandomJoinRoom>k__BackingField", "REP_RANDOM_JOIN_ROOM")]
            
    // class 0x208 PBProto.RequestModifyRoomProperties <reqModifyRoomProperties>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqModifyRoomProperties>k__BackingField", "REQ_MODIFY_ROOM_PROPERTIES")]
            
    // class 0x210 PBProto.ReplyModifyRoomProperties <repModifyRoomProperties>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repModifyRoomProperties>k__BackingField", "REP_MODIFY_ROOM_PROPERTIES")]
            
    // class 0x218 PBProto.NotifyModifyRoomProperties <notifyModifyRoomProperties>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<notifyModifyRoomProperties>k__BackingField", "NOTIFY_MODIFY_ROOM_PROPERTIES")]
            
    // class 0x220 PBProto.RequestModifyTeam <reqModifyTeam>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqModifyTeam>k__BackingField", "REQ_MODIFY_TEAM")]
            
    // class 0x228 PBProto.ReplyModifyTeam <repModifyTeam>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repModifyTeam>k__BackingField", "REP_MODIFY_TEAM")]
            
    // class 0x230 PBProto.RequestModifyRole <reqModifyRole>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqModifyRole>k__BackingField", "REQ_MODIFY_ROLE")]
            
    // class 0x238 PBProto.ReplyModifyRole <repModifyRole>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repModifyRole>k__BackingField", "REP_MODIFY_ROLE")]
            
    // class 0x240 PBProto.NotifyInfo <ntfInfo>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<ntfInfo>k__BackingField", "NTF_INFO")]
            
    // class 0x248 PBProto.RequestChat <reqChat>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqChat>k__BackingField", "REQ_CHAT")]
            
    // class 0x250 PBProto.ReplyChat <repChat>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repChat>k__BackingField", "REP_CHAT")]
            
    // class 0x258 PBProto.NotifyChat <notifyChat>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<notifyChat>k__BackingField", "NOTIFY_CHAT")]
            
    // class 0x260 PBProto.RequestNotice <reqNotice>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqNotice>k__BackingField", "REQ_NOTICE")]
            
    // class 0x268 PBProto.ReplyNotice <repNotice>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repNotice>k__BackingField", "REP_NOTICE")]
            
    // class 0x270 PBProto.NotifyNotice <notifyNotice>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<notifyNotice>k__BackingField", "NOTIFY_NOTICE")]
            
    // class 0x278 PBProto.RequestTurntableInfo <reqTurntableInfo>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqTurntableInfo>k__BackingField", "REQ_TURNTABLE_INFO")]
            
    // class 0x280 PBProto.ReplyTurntableInfo <repTurntableInfo>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repTurntableInfo>k__BackingField", "REP_TURNTABLE_INFO")]
            
    // class 0x288 PBProto.RequestTurntableDraw <reqTurntableDraw>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqTurntableDraw>k__BackingField", "REQ_TURNTABLE_DRAW")]
            
    // class 0x290 PBProto.ReplyTurntableDraw <repTurntableDraw>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repTurntableDraw>k__BackingField", "REP_TURNTABLE_DRAW")]
            
    // class 0x298 PBProto.RequestTurntableBoxGet <reqTurntableBoxGet>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqTurntableBoxGet>k__BackingField", "REQ_TURNTABLE_BOX_GET")]
            
    // class 0x2A0 PBProto.ReplyTurntableBoxGet <repTurntableBoxGet>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repTurntableBoxGet>k__BackingField", "REP_TURNTABLE_BOX_GET")]
            
    // class 0x2A8 PBProto.RequestChangeName <reqChangeName>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqChangeName>k__BackingField", "REQ_CHANGE_NAME")]
            
    // class 0x2B0 PBProto.ReplyChangeName <repChangeName>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repChangeName>k__BackingField", "REP_CHANGE_NAME")]
            
    // class 0x2B8 PBProto.RequestGetThankAward <reqGetThankAward>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqGetThankAward>k__BackingField", "REQ_GET_THANK_AWARD")]
            
    // class 0x2C0 PBProto.ReplyGetThankAward <repGetThankAward>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repGetThankAward>k__BackingField", "REP_GET_THANK_AWARD")]
            
    // class 0x2C8 PBProto.RequestRedeemCodeGetAward <reqRedeemCodeGetAward>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqRedeemCodeGetAward>k__BackingField", "REQ_REDEEM_CODE_GET_AWARD")]
            
    // class 0x2D0 PBProto.ReplyRedeemCodeGetAward <repRedeemCodeGetAward>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repRedeemCodeGetAward>k__BackingField", "REP_REDEEM_CODE_GET_AWARD")]
            
    // class 0x2D8 PBProto.RequestGetUsersInfo <reqGetUsersInfo>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqGetUsersInfo>k__BackingField", "REQ_GET_USERS_INFO")]
            
    // class 0x2E0 PBProto.ReplyGetUsersInfo <repGetUsersInfo>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repGetUsersInfo>k__BackingField", "REP_GET_USERS_INFO")]
            
    // class 0x2E8 PBProto.RequestModifyHeadFrm <reqModifyHeadFrm>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<reqModifyHeadFrm>k__BackingField", "REQ_MODIFY_HEAD_FRM")]
            
    // class 0x2F0 PBProto.ReplyModifyHeadFrm <repModifyHeadFrm>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<repModifyHeadFrm>k__BackingField", "REP_MODIFY_HEAD_FRM")]
    public partial class Body
    { 
        //public const string Const_ImageName = "SimpleKcpNet.dll";
        //public static byte[] Static_ImageName { get; } = [83, 105, 109, 112, 108, 101, 75, 99, 112, 78, 101, 116, 46, 100, 108, 108];

        //public const string Const_Namespace = "PBProto";
        //public static byte[] Static_Namespace { get; } = [80, 66, 80, 114, 111, 116, 111];

        //public const string Const_ClassName = "Body";
        //public static byte[] Static_ClassName { get; } = [66, 111, 100, 121];

        //public const uint Const_TypeToken = 0x02000004U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Body(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Body(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Body obj) => obj._ptr;
            public static implicit operator bool(Ptr_Body obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["SimpleKcpNet.dll"."PBProto"."Body"]
        /// </summary>
        public partial class Body
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            ///   System.Boolean get_isEmpty()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEmpty")]
            ///  extern System.Boolean GET_IS_EMPTY ();

            
            /// <summary>
            ///   PBProto.NotifyChat get_notifyChat()
            /// </summary>
            /// <returns>class PBProto.NotifyChat</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_notifyChat")]
            ///  extern nint GET_NOTIFY_CHAT ();

            
            /// <summary>
            ///   PBProto.NotifyModifyRoomProperties get_notifyModifyRoomProperties()
            /// </summary>
            /// <returns>class PBProto.NotifyModifyRoomProperties</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_notifyModifyRoomProperties")]
            ///  extern nint GET_NOTIFY_MODIFY_ROOM_PROPERTIES ();

            
            /// <summary>
            ///   PBProto.NotifyNotice get_notifyNotice()
            /// </summary>
            /// <returns>class PBProto.NotifyNotice</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_notifyNotice")]
            ///  extern nint GET_NOTIFY_NOTICE ();

            
            /// <summary>
            ///   PBProto.NotifyRoomChat get_notifyRoomChat()
            /// </summary>
            /// <returns>class PBProto.NotifyRoomChat</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_notifyRoomChat")]
            ///  extern nint GET_NOTIFY_ROOM_CHAT ();

            
            /// <summary>
            ///   PBProto.NotifyRoomDestroy get_notifyRoomDestroy()
            /// </summary>
            /// <returns>class PBProto.NotifyRoomDestroy</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_notifyRoomDestroy")]
            ///  extern nint GET_NOTIFY_ROOM_DESTROY ();

            
            /// <summary>
            ///   PBProto.NotifyRoomOwnerSelectMap get_notifyRoomOwnerSelectMap()
            /// </summary>
            /// <returns>class PBProto.NotifyRoomOwnerSelectMap</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_notifyRoomOwnerSelectMap")]
            ///  extern nint GET_NOTIFY_ROOM_OWNER_SELECT_MAP ();

            
            /// <summary>
            ///   PBProto.NotifyRoomPosInfo get_notifyRoomPosInfo()
            /// </summary>
            /// <returns>class PBProto.NotifyRoomPosInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_notifyRoomPosInfo")]
            ///  extern nint GET_NOTIFY_ROOM_POS_INFO ();

            
            /// <summary>
            ///   PBProto.NotifyConfirm get_ntfConfirm()
            /// </summary>
            /// <returns>class PBProto.NotifyConfirm</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ntfConfirm")]
            ///  extern nint GET_NTF_CONFIRM ();

            
            /// <summary>
            ///   PBProto.NotifyInfo get_ntfInfo()
            /// </summary>
            /// <returns>class PBProto.NotifyInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ntfInfo")]
            ///  extern nint GET_NTF_INFO ();

            
            /// <summary>
            ///   PBProto.NotifyLoadProgress get_ntfLoadProgress()
            /// </summary>
            /// <returns>class PBProto.NotifyLoadProgress</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ntfLoadProgress")]
            ///  extern nint GET_NTF_LOAD_PROGRESS ();

            
            /// <summary>
            ///   PBProto.NotifyLoadRes get_ntfLoadRes()
            /// </summary>
            /// <returns>class PBProto.NotifyLoadRes</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ntfLoadRes")]
            ///  extern nint GET_NTF_LOAD_RES ();

            
            /// <summary>
            ///   PBProto.NotifyMatchSuccess get_ntfMatchSuccess()
            /// </summary>
            /// <returns>class PBProto.NotifyMatchSuccess</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ntfMatchSuccess")]
            ///  extern nint GET_NTF_MATCH_SUCCESS ();

            
            /// <summary>
            ///   PBProto.NotifyNextframe get_ntfNextFrame()
            /// </summary>
            /// <returns>class PBProto.NotifyNextframe</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ntfNextFrame")]
            ///  extern nint GET_NTF_NEXT_FRAME ();

            
            /// <summary>
            ///   PBProto.NotifyOffline get_ntfOffline()
            /// </summary>
            /// <returns>class PBProto.NotifyOffline</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ntfOffline")]
            ///  extern nint GET_NTF_OFFLINE ();

            
            /// <summary>
            ///   PBProto.ReplyBagInfo get_repBagInfo()
            /// </summary>
            /// <returns>class PBProto.ReplyBagInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repBagInfo")]
            ///  extern nint GET_REP_BAG_INFO ();

            
            /// <summary>
            ///   PBProto.ReplyChangeName get_repChangeName()
            /// </summary>
            /// <returns>class PBProto.ReplyChangeName</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repChangeName")]
            ///  extern nint GET_REP_CHANGE_NAME ();

            
            /// <summary>
            ///   PBProto.ReplyChat get_repChat()
            /// </summary>
            /// <returns>class PBProto.ReplyChat</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repChat")]
            ///  extern nint GET_REP_CHAT ();

            
            /// <summary>
            ///   PBProto.ReplyCreate get_repCreate()
            /// </summary>
            /// <returns>class PBProto.ReplyCreate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repCreate")]
            ///  extern nint GET_REP_CREATE ();

            
            /// <summary>
            ///   PBProto.ReplyGetThankAward get_repGetThankAward()
            /// </summary>
            /// <returns>class PBProto.ReplyGetThankAward</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repGetThankAward")]
            ///  extern nint GET_REP_GET_THANK_AWARD ();

            
            /// <summary>
            ///   PBProto.ReplyGetUsersInfo get_repGetUsersInfo()
            /// </summary>
            /// <returns>class PBProto.ReplyGetUsersInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repGetUsersInfo")]
            ///  extern nint GET_REP_GET_USERS_INFO ();

            
            /// <summary>
            ///   PBProto.ReplyLogin get_repLogin()
            /// </summary>
            /// <returns>class PBProto.ReplyLogin</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repLogin")]
            ///  extern nint GET_REP_LOGIN ();

            
            /// <summary>
            ///   PBProto.ReplyMatch get_repMatch()
            /// </summary>
            /// <returns>class PBProto.ReplyMatch</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repMatch")]
            ///  extern nint GET_REP_MATCH ();

            
            /// <summary>
            ///   PBProto.ReplyModifyHeadFrm get_repModifyHeadFrm()
            /// </summary>
            /// <returns>class PBProto.ReplyModifyHeadFrm</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repModifyHeadFrm")]
            ///  extern nint GET_REP_MODIFY_HEAD_FRM ();

            
            /// <summary>
            ///   PBProto.ReplyModifyRole get_repModifyRole()
            /// </summary>
            /// <returns>class PBProto.ReplyModifyRole</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repModifyRole")]
            ///  extern nint GET_REP_MODIFY_ROLE ();

            
            /// <summary>
            ///   PBProto.ReplyModifyRoomProperties get_repModifyRoomProperties()
            /// </summary>
            /// <returns>class PBProto.ReplyModifyRoomProperties</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repModifyRoomProperties")]
            ///  extern nint GET_REP_MODIFY_ROOM_PROPERTIES ();

            
            /// <summary>
            ///   PBProto.ReplyModifyTeam get_repModifyTeam()
            /// </summary>
            /// <returns>class PBProto.ReplyModifyTeam</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repModifyTeam")]
            ///  extern nint GET_REP_MODIFY_TEAM ();

            
            /// <summary>
            ///   PBProto.ReplyNotice get_repNotice()
            /// </summary>
            /// <returns>class PBProto.ReplyNotice</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repNotice")]
            ///  extern nint GET_REP_NOTICE ();

            
            /// <summary>
            ///   PBProto.ReplyPing get_repPing()
            /// </summary>
            /// <returns>class PBProto.ReplyPing</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repPing")]
            ///  extern nint GET_REP_PING ();

            
            /// <summary>
            ///   PBProto.ReplyRandomJoinRoom get_repRandomJoinRoom()
            /// </summary>
            /// <returns>class PBProto.ReplyRandomJoinRoom</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRandomJoinRoom")]
            ///  extern nint GET_REP_RANDOM_JOIN_ROOM ();

            
            /// <summary>
            ///   PBProto.ReplyRankBattleInfo get_repRankBattleInfo()
            /// </summary>
            /// <returns>class PBProto.ReplyRankBattleInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRankBattleInfo")]
            ///  extern nint GET_REP_RANK_BATTLE_INFO ();

            
            /// <summary>
            ///   PBProto.ReplyRankList get_repRankList()
            /// </summary>
            /// <returns>class PBProto.ReplyRankList</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRankList")]
            ///  extern nint GET_REP_RANK_LIST ();

            
            /// <summary>
            ///   PBProto.ReplyRedeemCodeGetAward get_repRedeemCodeGetAward()
            /// </summary>
            /// <returns>class PBProto.ReplyRedeemCodeGetAward</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRedeemCodeGetAward")]
            ///  extern nint GET_REP_REDEEM_CODE_GET_AWARD ();

            
            /// <summary>
            ///   PBProto.ReplyRoomBattleExit get_repRoomBattleExit()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomBattleExit</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomBattleExit")]
            ///  extern nint GET_REP_ROOM_BATTLE_EXIT ();

            
            /// <summary>
            ///   PBProto.ReplyRoomChangeSeat get_repRoomChangeSeat()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomChangeSeat</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomChangeSeat")]
            ///  extern nint GET_REP_ROOM_CHANGE_SEAT ();

            
            /// <summary>
            ///   PBProto.ReplyRoomChat get_repRoomChat()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomChat</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomChat")]
            ///  extern nint GET_REP_ROOM_CHAT ();

            
            /// <summary>
            ///   PBProto.ReplyRoomCreate get_repRoomCreate()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomCreate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomCreate")]
            ///  extern nint GET_REP_ROOM_CREATE ();

            
            /// <summary>
            ///   PBProto.ReplyRoomDestroy get_repRoomDestroy()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomDestroy</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomDestroy")]
            ///  extern nint GET_REP_ROOM_DESTROY ();

            
            /// <summary>
            ///   PBProto.ReplyRoomJoin get_repRoomJoin()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomJoin</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomJoin")]
            ///  extern nint GET_REP_ROOM_JOIN ();

            
            /// <summary>
            ///   PBProto.ReplyRoomLeave get_repRoomLeave()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomLeave</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomLeave")]
            ///  extern nint GET_REP_ROOM_LEAVE ();

            
            /// <summary>
            ///   PBProto.ReplyRoomList get_repRoomList()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomList</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomList")]
            ///  extern nint GET_REP_ROOM_LIST ();

            
            /// <summary>
            ///   PBProto.ReplyRoomOwnerGameStart get_repRoomOwnerGameStart()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomOwnerGameStart</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomOwnerGameStart")]
            ///  extern nint GET_REP_ROOM_OWNER_GAME_START ();

            
            /// <summary>
            ///   PBProto.ReplyRoomOwnerKick get_repRoomOwnerKick()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomOwnerKick</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomOwnerKick")]
            ///  extern nint GET_REP_ROOM_OWNER_KICK ();

            
            /// <summary>
            ///   PBProto.ReplyRoomOwnerSelectMap get_repRoomOwnerSelectMap()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomOwnerSelectMap</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomOwnerSelectMap")]
            ///  extern nint GET_REP_ROOM_OWNER_SELECT_MAP ();

            
            /// <summary>
            ///   PBProto.ReplyRoomOwnerSwitchDoor get_repRoomOwnerSwitchDoor()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomOwnerSwitchDoor</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomOwnerSwitchDoor")]
            ///  extern nint GET_REP_ROOM_OWNER_SWITCH_DOOR ();

            
            /// <summary>
            ///   PBProto.ReplyRoomRandomRoomID get_repRoomRandomRoomID()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomRandomRoomID</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomRandomRoomID")]
            ///  extern nint GET_REP_ROOM_RANDOM_ROOM_ID ();

            
            /// <summary>
            ///   PBProto.ReplyRoomsNum get_repRoomsNum()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomsNum</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomsNum")]
            ///  extern nint GET_REP_ROOMS_NUM ();

            
            /// <summary>
            ///   PBProto.ReplyRoomSwitchReady get_repRoomSwitchReady()
            /// </summary>
            /// <returns>class PBProto.ReplyRoomSwitchReady</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repRoomSwitchReady")]
            ///  extern nint GET_REP_ROOM_SWITCH_READY ();

            
            /// <summary>
            ///   PBProto.ReplyShopBuy get_repShopBuy()
            /// </summary>
            /// <returns>class PBProto.ReplyShopBuy</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repShopBuy")]
            ///  extern nint GET_REP_SHOP_BUY ();

            
            /// <summary>
            ///   PBProto.ReplyTurntableBoxGet get_repTurntableBoxGet()
            /// </summary>
            /// <returns>class PBProto.ReplyTurntableBoxGet</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repTurntableBoxGet")]
            ///  extern nint GET_REP_TURNTABLE_BOX_GET ();

            
            /// <summary>
            ///   PBProto.ReplyTurntableDraw get_repTurntableDraw()
            /// </summary>
            /// <returns>class PBProto.ReplyTurntableDraw</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repTurntableDraw")]
            ///  extern nint GET_REP_TURNTABLE_DRAW ();

            
            /// <summary>
            ///   PBProto.ReplyTurntableInfo get_repTurntableInfo()
            /// </summary>
            /// <returns>class PBProto.ReplyTurntableInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_repTurntableInfo")]
            ///  extern nint GET_REP_TURNTABLE_INFO ();

            
            /// <summary>
            ///   PBProto.RequestBattleEnd get_reqBattleEnd()
            /// </summary>
            /// <returns>class PBProto.RequestBattleEnd</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqBattleEnd")]
            ///  extern nint GET_REQ_BATTLE_END ();

            
            /// <summary>
            ///   PBProto.RequestBattleStart get_reqBattleStart()
            /// </summary>
            /// <returns>class PBProto.RequestBattleStart</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqBattleStart")]
            ///  extern nint GET_REQ_BATTLE_START ();

            
            /// <summary>
            ///   PBProto.RequestChangeName get_reqChangeName()
            /// </summary>
            /// <returns>class PBProto.RequestChangeName</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqChangeName")]
            ///  extern nint GET_REQ_CHANGE_NAME ();

            
            /// <summary>
            ///   PBProto.RequestChat get_reqChat()
            /// </summary>
            /// <returns>class PBProto.RequestChat</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqChat")]
            ///  extern nint GET_REQ_CHAT ();

            
            /// <summary>
            ///   PBProto.RequestCreate get_reqCreate()
            /// </summary>
            /// <returns>class PBProto.RequestCreate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqCreate")]
            ///  extern nint GET_REQ_CREATE ();

            
            /// <summary>
            ///   PBProto.RequestGetThankAward get_reqGetThankAward()
            /// </summary>
            /// <returns>class PBProto.RequestGetThankAward</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqGetThankAward")]
            ///  extern nint GET_REQ_GET_THANK_AWARD ();

            
            /// <summary>
            ///   PBProto.RequestGetUsersInfo get_reqGetUsersInfo()
            /// </summary>
            /// <returns>class PBProto.RequestGetUsersInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqGetUsersInfo")]
            ///  extern nint GET_REQ_GET_USERS_INFO ();

            
            /// <summary>
            ///   PBProto.RequestLogin get_reqLogin()
            /// </summary>
            /// <returns>class PBProto.RequestLogin</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqLogin")]
            ///  extern nint GET_REQ_LOGIN ();

            
            /// <summary>
            ///   PBProto.RequestMatch get_reqMatch()
            /// </summary>
            /// <returns>class PBProto.RequestMatch</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqMatch")]
            ///  extern nint GET_REQ_MATCH ();

            
            /// <summary>
            ///   PBProto.RequestModifyHeadFrm get_reqModifyHeadFrm()
            /// </summary>
            /// <returns>class PBProto.RequestModifyHeadFrm</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqModifyHeadFrm")]
            ///  extern nint GET_REQ_MODIFY_HEAD_FRM ();

            
            /// <summary>
            ///   PBProto.RequestModifyRole get_reqModifyRole()
            /// </summary>
            /// <returns>class PBProto.RequestModifyRole</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqModifyRole")]
            ///  extern nint GET_REQ_MODIFY_ROLE ();

            
            /// <summary>
            ///   PBProto.RequestModifyRoomProperties get_reqModifyRoomProperties()
            /// </summary>
            /// <returns>class PBProto.RequestModifyRoomProperties</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqModifyRoomProperties")]
            ///  extern nint GET_REQ_MODIFY_ROOM_PROPERTIES ();

            
            /// <summary>
            ///   PBProto.RequestModifyTeam get_reqModifyTeam()
            /// </summary>
            /// <returns>class PBProto.RequestModifyTeam</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqModifyTeam")]
            ///  extern nint GET_REQ_MODIFY_TEAM ();

            
            /// <summary>
            ///   PBProto.RequestNotice get_reqNotice()
            /// </summary>
            /// <returns>class PBProto.RequestNotice</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqNotice")]
            ///  extern nint GET_REQ_NOTICE ();

            
            /// <summary>
            ///   PBProto.RequestPing get_reqPing()
            /// </summary>
            /// <returns>class PBProto.RequestPing</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqPing")]
            ///  extern nint GET_REQ_PING ();

            
            /// <summary>
            ///   PBProto.RequestRandomJoinRoom get_reqRandomJoinRoom()
            /// </summary>
            /// <returns>class PBProto.RequestRandomJoinRoom</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRandomJoinRoom")]
            ///  extern nint GET_REQ_RANDOM_JOIN_ROOM ();

            
            /// <summary>
            ///   PBProto.RequestRankList get_reqRankList()
            /// </summary>
            /// <returns>class PBProto.RequestRankList</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRankList")]
            ///  extern nint GET_REQ_RANK_LIST ();

            
            /// <summary>
            ///   PBProto.RequestRedeemCodeGetAward get_reqRedeemCodeGetAward()
            /// </summary>
            /// <returns>class PBProto.RequestRedeemCodeGetAward</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRedeemCodeGetAward")]
            ///  extern nint GET_REQ_REDEEM_CODE_GET_AWARD ();

            
            /// <summary>
            ///   PBProto.RequestRoomBattleExit get_reqRoomBattleExit()
            /// </summary>
            /// <returns>class PBProto.RequestRoomBattleExit</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomBattleExit")]
            ///  extern nint GET_REQ_ROOM_BATTLE_EXIT ();

            
            /// <summary>
            ///   PBProto.RequestRoomChangeSeat get_reqRoomChangeSeat()
            /// </summary>
            /// <returns>class PBProto.RequestRoomChangeSeat</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomChangeSeat")]
            ///  extern nint GET_REQ_ROOM_CHANGE_SEAT ();

            
            /// <summary>
            ///   PBProto.ReuqestRoomChat get_reqRoomChat()
            /// </summary>
            /// <returns>class PBProto.ReuqestRoomChat</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomChat")]
            ///  extern nint GET_REQ_ROOM_CHAT ();

            
            /// <summary>
            ///   PBProto.RequestRoomCreate get_reqRoomCreate()
            /// </summary>
            /// <returns>class PBProto.RequestRoomCreate</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomCreate")]
            ///  extern nint GET_REQ_ROOM_CREATE ();

            
            /// <summary>
            ///   PBProto.RequestRoomDestroy get_reqRoomDestroy()
            /// </summary>
            /// <returns>class PBProto.RequestRoomDestroy</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomDestroy")]
            ///  extern nint GET_REQ_ROOM_DESTROY ();

            
            /// <summary>
            ///   PBProto.RequestRoomJoin get_reqRoomJoin()
            /// </summary>
            /// <returns>class PBProto.RequestRoomJoin</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomJoin")]
            ///  extern nint GET_REQ_ROOM_JOIN ();

            
            /// <summary>
            ///   PBProto.RequestRoomLeave get_reqRoomLeave()
            /// </summary>
            /// <returns>class PBProto.RequestRoomLeave</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomLeave")]
            ///  extern nint GET_REQ_ROOM_LEAVE ();

            
            /// <summary>
            ///   PBProto.RequestRoomList get_reqRoomList()
            /// </summary>
            /// <returns>class PBProto.RequestRoomList</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomList")]
            ///  extern nint GET_REQ_ROOM_LIST ();

            
            /// <summary>
            ///   PBProto.RequestRoomOwnerGameStart get_reqRoomOwnerGameStart()
            /// </summary>
            /// <returns>class PBProto.RequestRoomOwnerGameStart</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomOwnerGameStart")]
            ///  extern nint GET_REQ_ROOM_OWNER_GAME_START ();

            
            /// <summary>
            ///   PBProto.RequestRoomOwnerKick get_reqRoomOwnerKick()
            /// </summary>
            /// <returns>class PBProto.RequestRoomOwnerKick</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomOwnerKick")]
            ///  extern nint GET_REQ_ROOM_OWNER_KICK ();

            
            /// <summary>
            ///   PBProto.RequestRoomOwnerSelectMap get_reqRoomOwnerSelectMap()
            /// </summary>
            /// <returns>class PBProto.RequestRoomOwnerSelectMap</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomOwnerSelectMap")]
            ///  extern nint GET_REQ_ROOM_OWNER_SELECT_MAP ();

            
            /// <summary>
            ///   PBProto.RequestRoomOwnerSwitchDoor get_reqRoomOwnerSwitchDoor()
            /// </summary>
            /// <returns>class PBProto.RequestRoomOwnerSwitchDoor</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomOwnerSwitchDoor")]
            ///  extern nint GET_REQ_ROOM_OWNER_SWITCH_DOOR ();

            
            /// <summary>
            ///   PBProto.RequestRoomRandomRoomID get_reqRoomRandomRoomID()
            /// </summary>
            /// <returns>class PBProto.RequestRoomRandomRoomID</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomRandomRoomID")]
            ///  extern nint GET_REQ_ROOM_RANDOM_ROOM_ID ();

            
            /// <summary>
            ///   PBProto.RequestRoomsNum get_reqRoomsNum()
            /// </summary>
            /// <returns>class PBProto.RequestRoomsNum</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomsNum")]
            ///  extern nint GET_REQ_ROOMS_NUM ();

            
            /// <summary>
            ///   PBProto.RequestRoomSwitchReady get_reqRoomSwitchReady()
            /// </summary>
            /// <returns>class PBProto.RequestRoomSwitchReady</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqRoomSwitchReady")]
            ///  extern nint GET_REQ_ROOM_SWITCH_READY ();

            
            /// <summary>
            ///   PBProto.RequestShopBuy get_reqShopBuy()
            /// </summary>
            /// <returns>class PBProto.RequestShopBuy</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqShopBuy")]
            ///  extern nint GET_REQ_SHOP_BUY ();

            
            /// <summary>
            ///   PBProto.RequestTurntableBoxGet get_reqTurntableBoxGet()
            /// </summary>
            /// <returns>class PBProto.RequestTurntableBoxGet</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqTurntableBoxGet")]
            ///  extern nint GET_REQ_TURNTABLE_BOX_GET ();

            
            /// <summary>
            ///   PBProto.RequestTurntableDraw get_reqTurntableDraw()
            /// </summary>
            /// <returns>class PBProto.RequestTurntableDraw</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqTurntableDraw")]
            ///  extern nint GET_REQ_TURNTABLE_DRAW ();

            
            /// <summary>
            ///   PBProto.RequestTurntableInfo get_reqTurntableInfo()
            /// </summary>
            /// <returns>class PBProto.RequestTurntableInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reqTurntableInfo")]
            ///  extern nint GET_REQ_TURNTABLE_INFO ();

            
            /// <summary>
            ///   PBProto.SendConfirm get_sndConfirm()
            /// </summary>
            /// <returns>class PBProto.SendConfirm</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sndConfirm")]
            ///  extern nint GET_SND_CONFIRM ();

            
            /// <summary>
            ///   PBProto.SendLoadProgress get_sndLoadProgress()
            /// </summary>
            /// <returns>class PBProto.SendLoadProgress</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sndLoadProgress")]
            ///  extern nint GET_SND_LOAD_PROGRESS ();

            
            /// <summary>
            ///   PBProto.SendOpKey get_sndOpKey()
            /// </summary>
            /// <returns>class PBProto.SendOpKey</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sndOpKey")]
            ///  extern nint GET_SND_OP_KEY ();

            
            /// <summary>
            ///   ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(System.Boolean createIfMissing)
            /// </summary>
            /// <param name="createIfMissing">struct System.Boolean</param>
            /// <returns>interface ProtoBuf.IExtension</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("global::ProtoBuf.IExtensible.GetExtensionObject")]
            ///  extern nint GLOBAL::PROTO_BUF.I_EXTENSIBLE.GET_EXTENSION_OBJECT (System.Boolean createIfMissing);

            
            /// <summary>
            ///   System.Void ResetisEmpty()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetisEmpty")]
            ///  extern void RESETIS_EMPTY ();

            
            /// <summary>
            ///   System.Void set_isEmpty(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isEmpty")]
            ///  extern void SET_IS_EMPTY (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_notifyChat(PBProto.NotifyChat value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyChat</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_notifyChat")]
            ///  extern void SET_NOTIFY_CHAT (nint value);

            
            /// <summary>
            ///   System.Void set_notifyModifyRoomProperties(PBProto.NotifyModifyRoomProperties value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyModifyRoomProperties</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_notifyModifyRoomProperties")]
            ///  extern void SET_NOTIFY_MODIFY_ROOM_PROPERTIES (nint value);

            
            /// <summary>
            ///   System.Void set_notifyNotice(PBProto.NotifyNotice value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyNotice</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_notifyNotice")]
            ///  extern void SET_NOTIFY_NOTICE (nint value);

            
            /// <summary>
            ///   System.Void set_notifyRoomChat(PBProto.NotifyRoomChat value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyRoomChat</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_notifyRoomChat")]
            ///  extern void SET_NOTIFY_ROOM_CHAT (nint value);

            
            /// <summary>
            ///   System.Void set_notifyRoomDestroy(PBProto.NotifyRoomDestroy value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyRoomDestroy</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_notifyRoomDestroy")]
            ///  extern void SET_NOTIFY_ROOM_DESTROY (nint value);

            
            /// <summary>
            ///   System.Void set_notifyRoomOwnerSelectMap(PBProto.NotifyRoomOwnerSelectMap value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyRoomOwnerSelectMap</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_notifyRoomOwnerSelectMap")]
            ///  extern void SET_NOTIFY_ROOM_OWNER_SELECT_MAP (nint value);

            
            /// <summary>
            ///   System.Void set_notifyRoomPosInfo(PBProto.NotifyRoomPosInfo value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyRoomPosInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_notifyRoomPosInfo")]
            ///  extern void SET_NOTIFY_ROOM_POS_INFO (nint value);

            
            /// <summary>
            ///   System.Void set_ntfConfirm(PBProto.NotifyConfirm value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyConfirm</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ntfConfirm")]
            ///  extern void SET_NTF_CONFIRM (nint value);

            
            /// <summary>
            ///   System.Void set_ntfInfo(PBProto.NotifyInfo value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ntfInfo")]
            ///  extern void SET_NTF_INFO (nint value);

            
            /// <summary>
            ///   System.Void set_ntfLoadProgress(PBProto.NotifyLoadProgress value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyLoadProgress</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ntfLoadProgress")]
            ///  extern void SET_NTF_LOAD_PROGRESS (nint value);

            
            /// <summary>
            ///   System.Void set_ntfLoadRes(PBProto.NotifyLoadRes value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyLoadRes</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ntfLoadRes")]
            ///  extern void SET_NTF_LOAD_RES (nint value);

            
            /// <summary>
            ///   System.Void set_ntfMatchSuccess(PBProto.NotifyMatchSuccess value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyMatchSuccess</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ntfMatchSuccess")]
            ///  extern void SET_NTF_MATCH_SUCCESS (nint value);

            
            /// <summary>
            ///   System.Void set_ntfNextFrame(PBProto.NotifyNextframe value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyNextframe</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ntfNextFrame")]
            ///  extern void SET_NTF_NEXT_FRAME (nint value);

            
            /// <summary>
            ///   System.Void set_ntfOffline(PBProto.NotifyOffline value)
            /// </summary>
            /// <param name="value">class PBProto.NotifyOffline</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ntfOffline")]
            ///  extern void SET_NTF_OFFLINE (nint value);

            
            /// <summary>
            ///   System.Void set_repBagInfo(PBProto.ReplyBagInfo value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyBagInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repBagInfo")]
            ///  extern void SET_REP_BAG_INFO (nint value);

            
            /// <summary>
            ///   System.Void set_repChangeName(PBProto.ReplyChangeName value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyChangeName</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repChangeName")]
            ///  extern void SET_REP_CHANGE_NAME (nint value);

            
            /// <summary>
            ///   System.Void set_repChat(PBProto.ReplyChat value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyChat</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repChat")]
            ///  extern void SET_REP_CHAT (nint value);

            
            /// <summary>
            ///   System.Void set_repCreate(PBProto.ReplyCreate value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyCreate</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repCreate")]
            ///  extern void SET_REP_CREATE (nint value);

            
            /// <summary>
            ///   System.Void set_repGetThankAward(PBProto.ReplyGetThankAward value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyGetThankAward</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repGetThankAward")]
            ///  extern void SET_REP_GET_THANK_AWARD (nint value);

            
            /// <summary>
            ///   System.Void set_repGetUsersInfo(PBProto.ReplyGetUsersInfo value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyGetUsersInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repGetUsersInfo")]
            ///  extern void SET_REP_GET_USERS_INFO (nint value);

            
            /// <summary>
            ///   System.Void set_repLogin(PBProto.ReplyLogin value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyLogin</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repLogin")]
            ///  extern void SET_REP_LOGIN (nint value);

            
            /// <summary>
            ///   System.Void set_repMatch(PBProto.ReplyMatch value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyMatch</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repMatch")]
            ///  extern void SET_REP_MATCH (nint value);

            
            /// <summary>
            ///   System.Void set_repModifyHeadFrm(PBProto.ReplyModifyHeadFrm value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyModifyHeadFrm</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repModifyHeadFrm")]
            ///  extern void SET_REP_MODIFY_HEAD_FRM (nint value);

            
            /// <summary>
            ///   System.Void set_repModifyRole(PBProto.ReplyModifyRole value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyModifyRole</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repModifyRole")]
            ///  extern void SET_REP_MODIFY_ROLE (nint value);

            
            /// <summary>
            ///   System.Void set_repModifyRoomProperties(PBProto.ReplyModifyRoomProperties value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyModifyRoomProperties</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repModifyRoomProperties")]
            ///  extern void SET_REP_MODIFY_ROOM_PROPERTIES (nint value);

            
            /// <summary>
            ///   System.Void set_repModifyTeam(PBProto.ReplyModifyTeam value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyModifyTeam</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repModifyTeam")]
            ///  extern void SET_REP_MODIFY_TEAM (nint value);

            
            /// <summary>
            ///   System.Void set_repNotice(PBProto.ReplyNotice value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyNotice</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repNotice")]
            ///  extern void SET_REP_NOTICE (nint value);

            
            /// <summary>
            ///   System.Void set_repPing(PBProto.ReplyPing value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyPing</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repPing")]
            ///  extern void SET_REP_PING (nint value);

            
            /// <summary>
            ///   System.Void set_repRandomJoinRoom(PBProto.ReplyRandomJoinRoom value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRandomJoinRoom</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRandomJoinRoom")]
            ///  extern void SET_REP_RANDOM_JOIN_ROOM (nint value);

            
            /// <summary>
            ///   System.Void set_repRankBattleInfo(PBProto.ReplyRankBattleInfo value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRankBattleInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRankBattleInfo")]
            ///  extern void SET_REP_RANK_BATTLE_INFO (nint value);

            
            /// <summary>
            ///   System.Void set_repRankList(PBProto.ReplyRankList value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRankList</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRankList")]
            ///  extern void SET_REP_RANK_LIST (nint value);

            
            /// <summary>
            ///   System.Void set_repRedeemCodeGetAward(PBProto.ReplyRedeemCodeGetAward value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRedeemCodeGetAward</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRedeemCodeGetAward")]
            ///  extern void SET_REP_REDEEM_CODE_GET_AWARD (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomBattleExit(PBProto.ReplyRoomBattleExit value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomBattleExit</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomBattleExit")]
            ///  extern void SET_REP_ROOM_BATTLE_EXIT (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomChangeSeat(PBProto.ReplyRoomChangeSeat value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomChangeSeat</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomChangeSeat")]
            ///  extern void SET_REP_ROOM_CHANGE_SEAT (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomChat(PBProto.ReplyRoomChat value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomChat</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomChat")]
            ///  extern void SET_REP_ROOM_CHAT (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomCreate(PBProto.ReplyRoomCreate value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomCreate</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomCreate")]
            ///  extern void SET_REP_ROOM_CREATE (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomDestroy(PBProto.ReplyRoomDestroy value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomDestroy</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomDestroy")]
            ///  extern void SET_REP_ROOM_DESTROY (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomJoin(PBProto.ReplyRoomJoin value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomJoin</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomJoin")]
            ///  extern void SET_REP_ROOM_JOIN (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomLeave(PBProto.ReplyRoomLeave value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomLeave</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomLeave")]
            ///  extern void SET_REP_ROOM_LEAVE (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomList(PBProto.ReplyRoomList value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomList</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomList")]
            ///  extern void SET_REP_ROOM_LIST (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomOwnerGameStart(PBProto.ReplyRoomOwnerGameStart value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomOwnerGameStart</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomOwnerGameStart")]
            ///  extern void SET_REP_ROOM_OWNER_GAME_START (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomOwnerKick(PBProto.ReplyRoomOwnerKick value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomOwnerKick</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomOwnerKick")]
            ///  extern void SET_REP_ROOM_OWNER_KICK (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomOwnerSelectMap(PBProto.ReplyRoomOwnerSelectMap value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomOwnerSelectMap</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomOwnerSelectMap")]
            ///  extern void SET_REP_ROOM_OWNER_SELECT_MAP (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomOwnerSwitchDoor(PBProto.ReplyRoomOwnerSwitchDoor value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomOwnerSwitchDoor</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomOwnerSwitchDoor")]
            ///  extern void SET_REP_ROOM_OWNER_SWITCH_DOOR (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomRandomRoomID(PBProto.ReplyRoomRandomRoomID value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomRandomRoomID</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomRandomRoomID")]
            ///  extern void SET_REP_ROOM_RANDOM_ROOM_ID (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomsNum(PBProto.ReplyRoomsNum value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomsNum</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomsNum")]
            ///  extern void SET_REP_ROOMS_NUM (nint value);

            
            /// <summary>
            ///   System.Void set_repRoomSwitchReady(PBProto.ReplyRoomSwitchReady value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRoomSwitchReady</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repRoomSwitchReady")]
            ///  extern void SET_REP_ROOM_SWITCH_READY (nint value);

            
            /// <summary>
            ///   System.Void set_repShopBuy(PBProto.ReplyShopBuy value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyShopBuy</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repShopBuy")]
            ///  extern void SET_REP_SHOP_BUY (nint value);

            
            /// <summary>
            ///   System.Void set_repTurntableBoxGet(PBProto.ReplyTurntableBoxGet value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyTurntableBoxGet</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repTurntableBoxGet")]
            ///  extern void SET_REP_TURNTABLE_BOX_GET (nint value);

            
            /// <summary>
            ///   System.Void set_repTurntableDraw(PBProto.ReplyTurntableDraw value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyTurntableDraw</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repTurntableDraw")]
            ///  extern void SET_REP_TURNTABLE_DRAW (nint value);

            
            /// <summary>
            ///   System.Void set_repTurntableInfo(PBProto.ReplyTurntableInfo value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyTurntableInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_repTurntableInfo")]
            ///  extern void SET_REP_TURNTABLE_INFO (nint value);

            
            /// <summary>
            ///   System.Void set_reqBattleEnd(PBProto.RequestBattleEnd value)
            /// </summary>
            /// <param name="value">class PBProto.RequestBattleEnd</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqBattleEnd")]
            ///  extern void SET_REQ_BATTLE_END (nint value);

            
            /// <summary>
            ///   System.Void set_reqBattleStart(PBProto.RequestBattleStart value)
            /// </summary>
            /// <param name="value">class PBProto.RequestBattleStart</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqBattleStart")]
            ///  extern void SET_REQ_BATTLE_START (nint value);

            
            /// <summary>
            ///   System.Void set_reqChangeName(PBProto.RequestChangeName value)
            /// </summary>
            /// <param name="value">class PBProto.RequestChangeName</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqChangeName")]
            ///  extern void SET_REQ_CHANGE_NAME (nint value);

            
            /// <summary>
            ///   System.Void set_reqChat(PBProto.RequestChat value)
            /// </summary>
            /// <param name="value">class PBProto.RequestChat</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqChat")]
            ///  extern void SET_REQ_CHAT (nint value);

            
            /// <summary>
            ///   System.Void set_reqCreate(PBProto.RequestCreate value)
            /// </summary>
            /// <param name="value">class PBProto.RequestCreate</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqCreate")]
            ///  extern void SET_REQ_CREATE (nint value);

            
            /// <summary>
            ///   System.Void set_reqGetThankAward(PBProto.RequestGetThankAward value)
            /// </summary>
            /// <param name="value">class PBProto.RequestGetThankAward</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqGetThankAward")]
            ///  extern void SET_REQ_GET_THANK_AWARD (nint value);

            
            /// <summary>
            ///   System.Void set_reqGetUsersInfo(PBProto.RequestGetUsersInfo value)
            /// </summary>
            /// <param name="value">class PBProto.RequestGetUsersInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqGetUsersInfo")]
            ///  extern void SET_REQ_GET_USERS_INFO (nint value);

            
            /// <summary>
            ///   System.Void set_reqLogin(PBProto.RequestLogin value)
            /// </summary>
            /// <param name="value">class PBProto.RequestLogin</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqLogin")]
            ///  extern void SET_REQ_LOGIN (nint value);

            
            /// <summary>
            ///   System.Void set_reqMatch(PBProto.RequestMatch value)
            /// </summary>
            /// <param name="value">class PBProto.RequestMatch</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqMatch")]
            ///  extern void SET_REQ_MATCH (nint value);

            
            /// <summary>
            ///   System.Void set_reqModifyHeadFrm(PBProto.RequestModifyHeadFrm value)
            /// </summary>
            /// <param name="value">class PBProto.RequestModifyHeadFrm</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqModifyHeadFrm")]
            ///  extern void SET_REQ_MODIFY_HEAD_FRM (nint value);

            
            /// <summary>
            ///   System.Void set_reqModifyRole(PBProto.RequestModifyRole value)
            /// </summary>
            /// <param name="value">class PBProto.RequestModifyRole</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqModifyRole")]
            ///  extern void SET_REQ_MODIFY_ROLE (nint value);

            
            /// <summary>
            ///   System.Void set_reqModifyRoomProperties(PBProto.RequestModifyRoomProperties value)
            /// </summary>
            /// <param name="value">class PBProto.RequestModifyRoomProperties</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqModifyRoomProperties")]
            ///  extern void SET_REQ_MODIFY_ROOM_PROPERTIES (nint value);

            
            /// <summary>
            ///   System.Void set_reqModifyTeam(PBProto.RequestModifyTeam value)
            /// </summary>
            /// <param name="value">class PBProto.RequestModifyTeam</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqModifyTeam")]
            ///  extern void SET_REQ_MODIFY_TEAM (nint value);

            
            /// <summary>
            ///   System.Void set_reqNotice(PBProto.RequestNotice value)
            /// </summary>
            /// <param name="value">class PBProto.RequestNotice</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqNotice")]
            ///  extern void SET_REQ_NOTICE (nint value);

            
            /// <summary>
            ///   System.Void set_reqPing(PBProto.RequestPing value)
            /// </summary>
            /// <param name="value">class PBProto.RequestPing</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqPing")]
            ///  extern void SET_REQ_PING (nint value);

            
            /// <summary>
            ///   System.Void set_reqRandomJoinRoom(PBProto.RequestRandomJoinRoom value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRandomJoinRoom</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRandomJoinRoom")]
            ///  extern void SET_REQ_RANDOM_JOIN_ROOM (nint value);

            
            /// <summary>
            ///   System.Void set_reqRankList(PBProto.RequestRankList value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRankList</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRankList")]
            ///  extern void SET_REQ_RANK_LIST (nint value);

            
            /// <summary>
            ///   System.Void set_reqRedeemCodeGetAward(PBProto.RequestRedeemCodeGetAward value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRedeemCodeGetAward</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRedeemCodeGetAward")]
            ///  extern void SET_REQ_REDEEM_CODE_GET_AWARD (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomBattleExit(PBProto.RequestRoomBattleExit value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomBattleExit</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomBattleExit")]
            ///  extern void SET_REQ_ROOM_BATTLE_EXIT (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomChangeSeat(PBProto.RequestRoomChangeSeat value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomChangeSeat</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomChangeSeat")]
            ///  extern void SET_REQ_ROOM_CHANGE_SEAT (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomChat(PBProto.ReuqestRoomChat value)
            /// </summary>
            /// <param name="value">class PBProto.ReuqestRoomChat</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomChat")]
            ///  extern void SET_REQ_ROOM_CHAT (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomCreate(PBProto.RequestRoomCreate value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomCreate</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomCreate")]
            ///  extern void SET_REQ_ROOM_CREATE (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomDestroy(PBProto.RequestRoomDestroy value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomDestroy</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomDestroy")]
            ///  extern void SET_REQ_ROOM_DESTROY (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomJoin(PBProto.RequestRoomJoin value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomJoin</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomJoin")]
            ///  extern void SET_REQ_ROOM_JOIN (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomLeave(PBProto.RequestRoomLeave value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomLeave</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomLeave")]
            ///  extern void SET_REQ_ROOM_LEAVE (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomList(PBProto.RequestRoomList value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomList</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomList")]
            ///  extern void SET_REQ_ROOM_LIST (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomOwnerGameStart(PBProto.RequestRoomOwnerGameStart value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomOwnerGameStart</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomOwnerGameStart")]
            ///  extern void SET_REQ_ROOM_OWNER_GAME_START (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomOwnerKick(PBProto.RequestRoomOwnerKick value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomOwnerKick</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomOwnerKick")]
            ///  extern void SET_REQ_ROOM_OWNER_KICK (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomOwnerSelectMap(PBProto.RequestRoomOwnerSelectMap value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomOwnerSelectMap</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomOwnerSelectMap")]
            ///  extern void SET_REQ_ROOM_OWNER_SELECT_MAP (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomOwnerSwitchDoor(PBProto.RequestRoomOwnerSwitchDoor value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomOwnerSwitchDoor</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomOwnerSwitchDoor")]
            ///  extern void SET_REQ_ROOM_OWNER_SWITCH_DOOR (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomRandomRoomID(PBProto.RequestRoomRandomRoomID value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomRandomRoomID</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomRandomRoomID")]
            ///  extern void SET_REQ_ROOM_RANDOM_ROOM_ID (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomsNum(PBProto.RequestRoomsNum value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomsNum</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomsNum")]
            ///  extern void SET_REQ_ROOMS_NUM (nint value);

            
            /// <summary>
            ///   System.Void set_reqRoomSwitchReady(PBProto.RequestRoomSwitchReady value)
            /// </summary>
            /// <param name="value">class PBProto.RequestRoomSwitchReady</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqRoomSwitchReady")]
            ///  extern void SET_REQ_ROOM_SWITCH_READY (nint value);

            
            /// <summary>
            ///   System.Void set_reqShopBuy(PBProto.RequestShopBuy value)
            /// </summary>
            /// <param name="value">class PBProto.RequestShopBuy</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqShopBuy")]
            ///  extern void SET_REQ_SHOP_BUY (nint value);

            
            /// <summary>
            ///   System.Void set_reqTurntableBoxGet(PBProto.RequestTurntableBoxGet value)
            /// </summary>
            /// <param name="value">class PBProto.RequestTurntableBoxGet</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqTurntableBoxGet")]
            ///  extern void SET_REQ_TURNTABLE_BOX_GET (nint value);

            
            /// <summary>
            ///   System.Void set_reqTurntableDraw(PBProto.RequestTurntableDraw value)
            /// </summary>
            /// <param name="value">class PBProto.RequestTurntableDraw</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqTurntableDraw")]
            ///  extern void SET_REQ_TURNTABLE_DRAW (nint value);

            
            /// <summary>
            ///   System.Void set_reqTurntableInfo(PBProto.RequestTurntableInfo value)
            /// </summary>
            /// <param name="value">class PBProto.RequestTurntableInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_reqTurntableInfo")]
            ///  extern void SET_REQ_TURNTABLE_INFO (nint value);

            
            /// <summary>
            ///   System.Void set_sndConfirm(PBProto.SendConfirm value)
            /// </summary>
            /// <param name="value">class PBProto.SendConfirm</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_sndConfirm")]
            ///  extern void SET_SND_CONFIRM (nint value);

            
            /// <summary>
            ///   System.Void set_sndLoadProgress(PBProto.SendLoadProgress value)
            /// </summary>
            /// <param name="value">class PBProto.SendLoadProgress</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_sndLoadProgress")]
            ///  extern void SET_SND_LOAD_PROGRESS (nint value);

            
            /// <summary>
            ///   System.Void set_sndOpKey(PBProto.SendOpKey value)
            /// </summary>
            /// <param name="value">class PBProto.SendOpKey</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_sndOpKey")]
            ///  extern void SET_SND_OP_KEY (nint value);

            
            /// <summary>
            ///   System.Boolean ShouldSerializeisEmpty()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShouldSerializeisEmpty")]
            ///  extern System.Boolean SHOULD_SERIALIZEIS_EMPTY ();
            
            

            
            /// public static partial class Search_Body
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}