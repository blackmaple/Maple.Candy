
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
    /// class ["Assembly-CSharp.dll".""."PlayerDataManager"]
    /// [Singleton<PlayerDataManager>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000180U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [80, 108, 97, 121, 101, 114, 68, 97, 116, 97, 77, 97, 110, 97, 103, 101, 114])]
                
    //  class static PlayerDataManager m_Instance
       [MonoCollectorSearchFieldAttribute(typeof(PlayerDataManager.Ptr_PlayerDataManager),"m_Instance", "M_INSTANCE", true)]
                
    // class 0x10 PBProto.ReplyLogin UserLoginData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"UserLoginData", "USER_LOGIN_DATA")]
            
    // class 0x18 System.Collections.Generic.List<PBProto.RoleId> UserHaveRoleIDList
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"UserHaveRoleIDList", "USER_HAVE_ROLE_ID_LIST")]
            
    // struct 0x20 System.Int32 <NetDelay>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<NetDelay>k__BackingField", "NET_DELAY")]
            
    // struct 0x24 System.Boolean SyncCheckLog
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"SyncCheckLog", "SYNC_CHECK_LOG")]
            
    // enum 0x28 PBProto.TeamEnum <MainPlayerTeam>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(PBProto.TeamEnum),"<MainPlayerTeam>k__BackingField", "MAIN_PLAYER_TEAM")]
            
    // struct 0x2C System.UInt32 <RankRoomID>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"<RankRoomID>k__BackingField", "RANK_ROOM_ID")]
            
    // class 0x30 MapConfig <MapConfig>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<MapConfig>k__BackingField", "MAP_CONFIG")]
            
    // enum 0x38 PBProto.BattleMode <CurrentBattleMode>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(PBProto.BattleMode),"<CurrentBattleMode>k__BackingField", "CURRENT_BATTLE_MODE")]
            
    // class 0x40 System.UInt32[] <winArr>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<winArr>k__BackingField", "WIN_ARR")]
            
    // struct 0x48 System.Int32 <OnlinePlayers>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"<OnlinePlayers>k__BackingField", "ONLINE_PLAYERS")]
            
    // class 0x50 System.Collections.Generic.List<PBProto.BattleHeroData> <HeroList>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<HeroList>k__BackingField", "HERO_LIST")]
            
    // class 0x58 System.Collections.Generic.List<System.Int32> <ObserverIndexList>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<ObserverIndexList>k__BackingField", "OBSERVER_INDEX_LIST")]
            
    // struct 0x60 System.UInt32 <BattleSelfIndex>k__BackingField
      [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"<BattleSelfIndex>k__BackingField", "BATTLE_SELF_INDEX")]
            
    // struct 0x64 System.UInt32 <RandomSeed>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"<RandomSeed>k__BackingField", "RANDOM_SEED")]
            
    // struct 0x68 System.UInt32 <GameTotalTime>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"<GameTotalTime>k__BackingField", "GAME_TOTAL_TIME")]
            
    // struct 0x6C System.Boolean MoveOnce
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"MoveOnce", "MOVE_ONCE")]
            
    // struct 0x70 System.UInt32 <RoomID>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"<RoomID>k__BackingField", "ROOM_ID")]
            
    // struct 0x74 System.UInt32 <RoomMapID>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"<RoomMapID>k__BackingField", "ROOM_MAP_ID")]
            
    // class 0x78 System.String <RoomName>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<RoomName>k__BackingField", "ROOM_NAME")]
            
    // class 0x80 System.String <RoomPassword>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<RoomPassword>k__BackingField", "ROOM_PASSWORD")]
            
    // class 0x88 System.Collections.Generic.List<PBProto.RoomPosInfo> <RoomPosInfos>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<RoomPosInfos>k__BackingField", "ROOM_POS_INFOS")]
            
    // struct 0x90 System.Boolean <IsRoomOnwer>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<IsRoomOnwer>k__BackingField", "IS_ROOM_ONWER")]
            
    // struct 0x94 System.UInt32 <RoomSelfIndex>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"<RoomSelfIndex>k__BackingField", "ROOM_SELF_INDEX")]
            
    // enum 0x98 PBProto.TeamEnum <Team>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(PBProto.TeamEnum),"<Team>k__BackingField", "TEAM")]
            
    // enum 0x9C PBProto.RoleId <currentRoleID>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(PBProto.RoleId),"<currentRoleID>k__BackingField", "CURRENT_ROLE_ID")]
            
    // struct 0xA0 System.Boolean <isAutoReadyOrBegin>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<isAutoReadyOrBegin>k__BackingField", "IS_AUTO_READY_OR_BEGIN")]
            
    // struct 0xA4 System.UInt32 <CoinCount>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"<CoinCount>k__BackingField", "COIN_COUNT")]
            
    // struct 0xA8 System.UInt32 <HornCount>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.UInt32),"<HornCount>k__BackingField", "HORN_COUNT")]
            
    // struct 0xAC System.Boolean <existChgNameCard>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<existChgNameCard>k__BackingField", "EXIST_CHG_NAME_CARD")]
            
    // class 0xB0 PBProto.ReplyRankBattleInfo <RankInfo>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"<RankInfo>k__BackingField", "RANK_INFO")]
            
    // struct 0xB8 System.Boolean isFastVideo
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isFastVideo", "IS_FAST_VIDEO")]
            
    // struct 0xB9 System.Boolean isOrderPlayVideo
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isOrderPlayVideo", "IS_ORDER_PLAY_VIDEO")]
    public partial class PlayerDataManager
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "PlayerDataManager";
        //public static byte[] Static_ClassName { get; } = [80, 108, 97, 121, 101, 114, 68, 97, 116, 97, 77, 97, 110, 97, 103, 101, 114];

        //public const uint Const_TypeToken = 0x02000180U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_PlayerDataManager(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_PlayerDataManager(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_PlayerDataManager obj) => obj._ptr;
            public static implicit operator bool(Ptr_PlayerDataManager obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll".""."PlayerDataManager"]
        /// </summary>
        public partial class PlayerDataManager
        { 

            
            
            /// <summary>
            ///   System.UInt32 get_BattleSelfIndex()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_BattleSelfIndex")]
            ///  extern System.UInt32 GET_BATTLE_SELF_INDEX ();

            
            /// <summary>
            ///   System.UInt32 get_CoinCount()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CoinCount")]
            ///  extern System.UInt32 GET_COIN_COUNT ();

            
            /// <summary>
            ///   PBProto.BattleMode get_CurrentBattleMode()
            /// </summary>
            /// <returns>enum PBProto.BattleMode</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CurrentBattleMode")]
            ///  extern PBProto.BattleMode GET_CURRENT_BATTLE_MODE ();

            
            /// <summary>
            ///   PBProto.RoleId get_currentRoleID()
            /// </summary>
            /// <returns>enum PBProto.RoleId</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentRoleID")]
            ///  extern PBProto.RoleId GET_CURRENT_ROLE_ID ();

            
            /// <summary>
            ///   System.Boolean get_existChgNameCard()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_existChgNameCard")]
            ///  extern System.Boolean GET_EXIST_CHG_NAME_CARD ();

            
            /// <summary>
            ///   System.UInt32 get_GameTotalTime()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameTotalTime")]
            ///  extern System.UInt32 GET_GAME_TOTAL_TIME ();

            
            /// <summary>
            ///   System.Collections.Generic.List<PBProto.BattleHeroData> get_HeroList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PBProto.BattleHeroData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HeroList")]
            ///  extern nint GET_HERO_LIST ();

            
            /// <summary>
            ///   System.UInt32 get_HornCount()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HornCount")]
            ///  extern System.UInt32 GET_HORN_COUNT ();

            
            /// <summary>
            /// static  PlayerDataManager get_Instance()
            /// </summary>
            /// <returns>class PlayerDataManager</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Instance")]
            /// static extern nint GET_INSTANCE ();

            
            /// <summary>
            ///   System.Boolean get_isAutoReadyOrBegin()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAutoReadyOrBegin")]
            ///  extern System.Boolean GET_IS_AUTO_READY_OR_BEGIN ();

            
            /// <summary>
            ///   System.Boolean get_IsRankMode()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsRankMode")]
            ///  extern System.Boolean GET_IS_RANK_MODE ();

            
            /// <summary>
            ///   System.Boolean get_IsRoomOnwer()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsRoomOnwer")]
            ///  extern System.Boolean GET_IS_ROOM_ONWER ();

            
            /// <summary>
            ///   PBProto.TeamEnum get_MainPlayerTeam()
            /// </summary>
            /// <returns>enum PBProto.TeamEnum</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MainPlayerTeam")]
            ///  extern PBProto.TeamEnum GET_MAIN_PLAYER_TEAM ();

            
            /// <summary>
            ///   MapConfig get_MapConfig()
            /// </summary>
            /// <returns>class MapConfig</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapConfig")]
            ///  extern nint GET_MAP_CONFIG ();

            
            /// <summary>
            ///   System.Int32 get_NetDelay()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_NetDelay")]
            ///  extern System.Int32 GET_NET_DELAY ();

            
            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> get_ObserverIndexList()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ObserverIndexList")]
            ///  extern nint GET_OBSERVER_INDEX_LIST ();

            
            /// <summary>
            ///   System.Int32 get_OnlinePlayers()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OnlinePlayers")]
            ///  extern System.Int32 GET_ONLINE_PLAYERS ();

            
            /// <summary>
            ///   System.UInt32 get_RandomSeed()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RandomSeed")]
            ///  extern System.UInt32 GET_RANDOM_SEED ();

            
            /// <summary>
            ///   PBProto.ReplyRankBattleInfo get_RankInfo()
            /// </summary>
            /// <returns>class PBProto.ReplyRankBattleInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RankInfo")]
            ///  extern nint GET_RANK_INFO ();

            
            /// <summary>
            ///   System.UInt32 get_RankRoomID()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RankRoomID")]
            ///  extern System.UInt32 GET_RANK_ROOM_ID ();

            
            /// <summary>
            ///   System.UInt32 get_RoomID()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RoomID")]
            ///  extern System.UInt32 GET_ROOM_ID ();

            
            /// <summary>
            ///   System.UInt32 get_RoomMapID()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RoomMapID")]
            ///  extern System.UInt32 GET_ROOM_MAP_ID ();

            
            /// <summary>
            ///   System.String get_RoomName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RoomName")]
            ///  extern nint GET_ROOM_NAME ();

            
            /// <summary>
            ///   System.String get_RoomPassword()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RoomPassword")]
            ///  extern nint GET_ROOM_PASSWORD ();

            
            /// <summary>
            ///   System.Collections.Generic.List<PBProto.RoomPosInfo> get_RoomPosInfos()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PBProto.RoomPosInfo></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RoomPosInfos")]
            ///  extern nint GET_ROOM_POS_INFOS ();

            
            /// <summary>
            ///   System.UInt32 get_RoomSelfIndex()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RoomSelfIndex")]
            ///  extern System.UInt32 GET_ROOM_SELF_INDEX ();

            
            /// <summary>
            ///   PBProto.TeamEnum get_Team()
            /// </summary>
            /// <returns>enum PBProto.TeamEnum</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Team")]
            ///  extern PBProto.TeamEnum GET_TEAM ();

            
            /// <summary>
            ///   PBProto.BattleData get_UserBattleData()
            /// </summary>
            /// <returns>class PBProto.BattleData</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UserBattleData")]
            ///  extern nint GET_USER_BATTLE_DATA ();

            
            /// <summary>
            ///   PBProto.UserData get_UserData()
            /// </summary>
            /// <returns>class PBProto.UserData</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UserData")]
            ///  extern nint GET_USER_DATA ();

            
            /// <summary>
            ///   System.UInt32[] get_winArr()
            /// </summary>
            /// <returns>class System.UInt32[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_winArr")]
            ///  extern nint GET_WIN_ARR ();

            
            /// <summary>
            ///   System.Void ResetBattleData()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetBattleData")]
            ///  extern void RESET_BATTLE_DATA ();

            
            /// <summary>
            ///   System.Void ResetRoomInfo()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetRoomInfo")]
            ///  extern void RESET_ROOM_INFO ();

            
            /// <summary>
            ///   System.Void set_BattleSelfIndex(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_BattleSelfIndex")]
            ///  extern void SET_BATTLE_SELF_INDEX (System.UInt32 value);

            
            /// <summary>
            ///   System.Void set_CoinCount(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_CoinCount")]
            ///  extern void SET_COIN_COUNT (System.UInt32 value);

            
            /// <summary>
            ///   System.Void set_CurrentBattleMode(PBProto.BattleMode value)
            /// </summary>
            /// <param name="value">enum PBProto.BattleMode</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_CurrentBattleMode")]
            ///  extern void SET_CURRENT_BATTLE_MODE (PBProto.BattleMode value);

            
            /// <summary>
            ///   System.Void set_currentRoleID(PBProto.RoleId value)
            /// </summary>
            /// <param name="value">enum PBProto.RoleId</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_currentRoleID")]
            ///  extern void SET_CURRENT_ROLE_ID (PBProto.RoleId value);

            
            /// <summary>
            ///   System.Void set_existChgNameCard(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_existChgNameCard")]
            ///  extern void SET_EXIST_CHG_NAME_CARD (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_GameTotalTime(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_GameTotalTime")]
            ///  extern void SET_GAME_TOTAL_TIME (System.UInt32 value);

            
            /// <summary>
            ///   System.Void set_HeroList(System.Collections.Generic.List<PBProto.BattleHeroData> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<PBProto.BattleHeroData></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_HeroList")]
            ///  extern void SET_HERO_LIST (nint value);

            
            /// <summary>
            ///   System.Void set_HornCount(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_HornCount")]
            ///  extern void SET_HORN_COUNT (System.UInt32 value);

            
            /// <summary>
            ///   System.Void set_isAutoReadyOrBegin(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAutoReadyOrBegin")]
            ///  extern void SET_IS_AUTO_READY_OR_BEGIN (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_IsRoomOnwer(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_IsRoomOnwer")]
            ///  extern void SET_IS_ROOM_ONWER (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_MainPlayerTeam(PBProto.TeamEnum value)
            /// </summary>
            /// <param name="value">enum PBProto.TeamEnum</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_MainPlayerTeam")]
            ///  extern void SET_MAIN_PLAYER_TEAM (PBProto.TeamEnum value);

            
            /// <summary>
            ///   System.Void set_MapConfig(MapConfig value)
            /// </summary>
            /// <param name="value">class MapConfig</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_MapConfig")]
            ///  extern void SET_MAP_CONFIG (nint value);

            
            /// <summary>
            ///   System.Void set_NetDelay(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_NetDelay")]
            ///  extern void SET_NET_DELAY (System.Int32 value);

            
            /// <summary>
            ///   System.Void set_ObserverIndexList(System.Collections.Generic.List<System.Int32> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<System.Int32></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_ObserverIndexList")]
            ///  extern void SET_OBSERVER_INDEX_LIST (nint value);

            
            /// <summary>
            ///   System.Void set_OnlinePlayers(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_OnlinePlayers")]
            ///  extern void SET_ONLINE_PLAYERS (System.Int32 value);

            
            /// <summary>
            ///   System.Void set_RandomSeed(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_RandomSeed")]
            ///  extern void SET_RANDOM_SEED (System.UInt32 value);

            
            /// <summary>
            ///   System.Void set_RankInfo(PBProto.ReplyRankBattleInfo value)
            /// </summary>
            /// <param name="value">class PBProto.ReplyRankBattleInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_RankInfo")]
            ///  extern void SET_RANK_INFO (nint value);

            
            /// <summary>
            ///   System.Void set_RankRoomID(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_RankRoomID")]
            ///  extern void SET_RANK_ROOM_ID (System.UInt32 value);

            
            /// <summary>
            ///   System.Void set_RoomID(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_RoomID")]
            ///  extern void SET_ROOM_ID (System.UInt32 value);

            
            /// <summary>
            ///   System.Void set_RoomMapID(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_RoomMapID")]
            ///  extern void SET_ROOM_MAP_ID (System.UInt32 value);

            
            /// <summary>
            ///   System.Void set_RoomName(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_RoomName")]
            ///  extern void SET_ROOM_NAME (nint value);

            
            /// <summary>
            ///   System.Void set_RoomPassword(System.String value)
            /// </summary>
            /// <param name="value">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_RoomPassword")]
            ///  extern void SET_ROOM_PASSWORD (nint value);

            
            /// <summary>
            ///   System.Void set_RoomPosInfos(System.Collections.Generic.List<PBProto.RoomPosInfo> value)
            /// </summary>
            /// <param name="value">class System.Collections.Generic.List<PBProto.RoomPosInfo></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_RoomPosInfos")]
            ///  extern void SET_ROOM_POS_INFOS (nint value);

            
            /// <summary>
            ///   System.Void set_RoomSelfIndex(System.UInt32 value)
            /// </summary>
            /// <param name="value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_RoomSelfIndex")]
            ///  extern void SET_ROOM_SELF_INDEX (System.UInt32 value);

            
            /// <summary>
            ///   System.Void set_Team(PBProto.TeamEnum value)
            /// </summary>
            /// <param name="value">enum PBProto.TeamEnum</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Team")]
            ///  extern void SET_TEAM (PBProto.TeamEnum value);

            
            /// <summary>
            ///   System.Void set_winArr(System.UInt32[] value)
            /// </summary>
            /// <param name="value">class System.UInt32[]</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_winArr")]
            ///  extern void SET_WIN_ARR (nint value);

            
            /// <summary>
            ///   System.Void UpdateBattleData(MapConfig mapConfig, System.Collections.Generic.List<PBProto.BattleHeroData> heroLists, System.UInt32 posIndex, System.UInt32 randomSeed, System.UInt32 gameTime, PBProto.BattleMode battleMode)
            /// </summary>
            /// <param name="mapConfig">class MapConfig</param>
            /// <param name="heroLists">class System.Collections.Generic.List<PBProto.BattleHeroData></param>
            /// <param name="posIndex">struct System.UInt32</param>
            /// <param name="randomSeed">struct System.UInt32</param>
            /// <param name="gameTime">struct System.UInt32</param>
            /// <param name="battleMode">enum PBProto.BattleMode</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateBattleData")]
            ///  extern void UPDATE_BATTLE_DATA (nint mapConfig, nint heroLists, System.UInt32 posIndex, System.UInt32 randomSeed, System.UInt32 gameTime, PBProto.BattleMode battleMode);

            
            /// <summary>
            ///   System.Void UpdateRoomInfo(System.UInt32 roomID, System.UInt32 roomMapID, System.String roomName, System.String roomPassword, System.Collections.Generic.List<PBProto.RoomPosInfo> roomPosInfos)
            /// </summary>
            /// <param name="roomID">struct System.UInt32</param>
            /// <param name="roomMapID">struct System.UInt32</param>
            /// <param name="roomName">class System.String</param>
            /// <param name="roomPassword">class System.String</param>
            /// <param name="roomPosInfos">class System.Collections.Generic.List<PBProto.RoomPosInfo></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateRoomInfo")]
            ///  extern void UPDATE_ROOM_INFO (System.UInt32 roomID, System.UInt32 roomMapID, nint roomName, nint roomPassword, nint roomPosInfos);
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PlayerDataManager))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_PlayerDataManager))]
            ///  extern void .CTOR_01 ();

            
            /// public static partial class Search_PlayerDataManager
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}