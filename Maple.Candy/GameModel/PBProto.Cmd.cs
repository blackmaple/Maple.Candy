
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
    /// ["SimpleKcpNet.dll"."PBProto"."Cmd"]
    /// </summary>
    public enum Cmd : System.Int32
    { 

        
        CMDRequestLogin = 0x00000001,

        CMDReplyLogin = 0x00000002,

        CMDRequestPing = 0x00000003,

        CMDReplyPing = 0x00000004,

        CMDRequestRankBattleInfo = 0x00000005,

        CMDReplyRankBattleInfo = 0x00000006,

        CMDRequestMatch = 0x00000007,

        CMDCancelMatch = 0x00000008,

        CMDReplyMatch = 0x00000009,

        CMDNotifyMatchSuccess = 0x0000000A,

        CMDNotifyConfirm = 0x0000000B,

        CMDSendConfirm = 0x0000000C,

        CMDNotifyLoadRes = 0x0000000D,

        CMDSendLoadProgress = 0x0000000E,

        CMDNotifyLoadProgress = 0x0000000F,

        CMDRequestBattleStart = 0x00000010,

        CMDReplyBattleStart = 0x00000011,

        CMDNotifyNextframe = 0x00000012,

        CMDSendOpKey = 0x00000013,

        CMDRequestBattleEnd = 0x00000016,

        CMDNotifyBattleEnd = 0x00000017,

        CMDRequestOffline = 0x00000018,

        CMDNotifyOffline = 0x00000019,

        CMDExceptionError = 0x0000001A,

        CMDReturnToRoom = 0x0000001B,

        CMDRequestCreate = 0x0000001C,

        CMDReplayCreate = 0x0000001D,

        CMDRequestShopBuy = 0x0000001E,

        CMDReplyShopBuy = 0x0000001F,

        CMDRequestBagInfo = 0x00000020,

        CMDReplyBagInfo = 0x00000021,

        CMDRequestRankList = 0x00000022,

        CMDReplyRankList = 0x00000023,

        CMDRequestRoomCreate = 0x00000032,

        CMDReplyRoomCreate = 0x00000033,

        CMDRequestRoomRandomRoomID = 0x00000034,

        CMDReplyRoomRandomRoomID = 0x00000035,

        CMDRequestRoomJoin = 0x00000036,

        CMDReplyRoomJoin = 0x00000037,

        CMDNotifyRoomPosInfo = 0x00000038,

        CMDRequestRoomChat = 0x00000039,

        CMDReplyRoomChat = 0x0000003A,

        CMDNotifyRoomChat = 0x0000003B,

        CMDRequestRoomDestroy = 0x0000003C,

        CMDReplyRoomDestroy = 0x0000003D,

        CMDNotifyRoomDestroy = 0x0000003E,

        CMDRequestRoomOwnerSwitchDoor = 0x0000003F,

        CMDReplyRoomOwnerSwitchDoor = 0x00000040,

        CMDRequestRoomOwnerKick = 0x00000041,

        CMDReplyRoomOwnerKick = 0x00000042,

        CMDRequestRoomOwnerSelectMap = 0x00000043,

        CMDReplyRoomOwnerSelectMap = 0x00000044,

        CMDNotifyRoomOwnerSelectMap = 0x00000045,

        CMDRequestRoomSwitchReady = 0x00000046,

        CMDReplyRoomSwitchReady = 0x00000047,

        CMDRequestRoomChangeSeat = 0x00000048,

        CMDReplyRoomChangeSeat = 0x00000049,

        CMDRequestRoomLeave = 0x0000004A,

        CMDReplyRoomLeave = 0x0000004B,

        CMDRequestRoomOwnerGameStart = 0x0000004C,

        CMDReplyRoomOwnerGameStart = 0x0000004D,

        CMDRequestRoomBattleExit = 0x0000004E,

        CMDReplyRoomBattleExit = 0x0000004F,

        CMDRequestRoomsNum = 0x00000050,

        CMDReplyRoomsNum = 0x00000051,

        CMDRequestRoomList = 0x00000052,

        CMDReplyRoomList = 0x00000053,

        CMDRequestRandomJoinRoom = 0x00000054,

        CMDReplyRandomJoinRoom = 0x00000055,

        CMDRequestModifyRoomProperties = 0x00000056,

        CMDReplyModifyRoomProperties = 0x00000057,

        CMDNotifyModifyRoomProperties = 0x00000058,

        CMDRequestModifyTeam = 0x00000059,

        CMDReplyModifyTeam = 0x0000005A,

        CMDRequestModifyRole = 0x0000005B,

        CMDReplyModifyRole = 0x0000005C,

        CMDRequestBanIP = 0x00000065,

        CMDNotifyInfo = 0x00000066,

        CMDForceCloseClient = 0x00000067,

        CMDRequestQuitLogin = 0x00000068,

        CMDRequestChat = 0x00000069,

        CMDReplyChat = 0x0000006A,

        CMDNotifyChat = 0x0000006B,

        CMDRequestNotice = 0x0000006C,

        CMDReplyNotice = 0x0000006D,

        CMDNotifyNotice = 0x0000006E,

        CMDRequestTurntableInfo = 0x00000097,

        CMDReplyTurntableInfo = 0x00000098,

        CMDRequestTurntableDraw = 0x00000099,

        CMDReplyTurntableDraw = 0x0000009A,

        CMDRequestTurntableBoxGet = 0x0000009B,

        CMDReplyTurntableBoxGet = 0x0000009C,

        CMDRequestChangeName = 0x000000A0,

        CMDReplyChangeName = 0x000000A1,

        CMDRequestGetThankAward = 0x000000A2,

        CMDReplyGetThankAward = 0x000000A3,

        CMDRequestRedeemCodeGetAward = 0x000000A4,

        CMDReplyRedeemCodeGetAward = 0x000000A5,

        CMDRequestGetUsersInfo = 0x000000A6,

        CMDReplyGetUsersInfo = 0x000000A7,

        CMDRequestModifyHeadFrm = 0x000000A8,

        CMDReplyModifyHeadFrm = 0x000000A9,

    }


}