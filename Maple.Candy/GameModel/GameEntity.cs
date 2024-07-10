
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
    /// class ["Assembly-CSharp.dll".""."GameEntity"]
    /// [Entitas.Entity]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020002AAU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [71, 97, 109, 101, 69, 110, 116, 105, 116, 121])]

    //  class static DestroyedComponent destroyedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"destroyedComponent", "DESTROYED_COMPONENT", true)]

    //  class static MainPlayerComponent mainPlayerComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"mainPlayerComponent", "MAIN_PLAYER_COMPONENT", true)]

    //  class static MaxBombComponent maxBombComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"maxBombComponent", "MAX_BOMB_COMPONENT", true)]

    //  class static MaxBombPowerComponent maxBombPowerComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"maxBombPowerComponent", "MAX_BOMB_POWER_COMPONENT", true)]

    //  class static MaxShooesComponent maxShooesComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"maxShooesComponent", "MAX_SHOOES_COMPONENT", true)]

    //  class static PhasingComponent phasingComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"phasingComponent", "PHASING_COMPONENT", true)]

    // class 0x10 Entitas.EntityComponentChanged OnComponentAdded
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentAdded", "ON_COMPONENT_ADDED")]

    // class 0x18 Entitas.EntityComponentChanged OnComponentRemoved
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentRemoved", "ON_COMPONENT_REMOVED")]

    // class 0x20 Entitas.EntityComponentReplaced OnComponentReplaced
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentReplaced", "ON_COMPONENT_REPLACED")]

    // class 0x28 Entitas.EntityEvent OnEntityReleased
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityReleased", "ON_ENTITY_RELEASED")]

    // class 0x30 Entitas.EntityEvent OnDestroyEntity
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnDestroyEntity", "ON_DESTROY_ENTITY")]

    // class 0x38 System.Collections.Generic.List<Entitas.IComponent> _componentBuffer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentBuffer", "_COMPONENT_BUFFER")]

    // class 0x40 System.Collections.Generic.List<System.Int32> _indexBuffer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_indexBuffer", "_INDEX_BUFFER")]

    // struct 0x48 System.Int32 _creationIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_creationIndex", "_CREATION_INDEX")]

    // struct 0x4C System.Boolean _isEnabled
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"_isEnabled", "_IS_ENABLED")]

    // struct 0x50 System.Int32 _totalComponents
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_totalComponents", "_TOTAL_COMPONENTS")]

    // class 0x58 Entitas.IComponent[] _components
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_components", "_COMPONENTS")]

    // class 0x60 System.Collections.Generic.Stack<Entitas.IComponent>[] _componentPools
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentPools", "_COMPONENT_POOLS")]

    // class 0x68 Entitas.ContextInfo _contextInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_contextInfo", "_CONTEXT_INFO")]

    // interface 0x70 Entitas.IAERC _aerc
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_aerc", "_AERC")]

    // class 0x78 Entitas.IComponent[] _componentsCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentsCache", "_COMPONENTS_CACHE")]

    // class 0x80 System.Int32[] _componentIndicesCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentIndicesCache", "_COMPONENT_INDICES_CACHE")]

    // class 0x88 System.String _toStringCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_toStringCache", "_TO_STRING_CACHE")]

    // class 0x90 System.Text.StringBuilder _toStringBuilder
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_toStringBuilder", "_TO_STRING_BUILDER")]
    public partial class GameEntity
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GameEntity";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 69, 110, 116, 105, 116, 121];

        //public const uint Const_TypeToken = 0x020002AAU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameEntity(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameEntity(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameEntity obj) => obj._ptr;
            public static implicit operator bool(Ptr_GameEntity obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."GameEntity"]
    /// </summary>
    public partial class GameEntity
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void add_OnComponentAdded(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentAdded")]
        ///  extern void ADD_ON_COMPONENT_ADDED (nint value);


        /// <summary>
        ///   System.Void add_OnComponentRemoved(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentRemoved")]
        ///  extern void ADD_ON_COMPONENT_REMOVED (nint value);


        /// <summary>
        ///   System.Void add_OnComponentReplaced(Entitas.EntityComponentReplaced value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentReplaced</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentReplaced")]
        ///  extern void ADD_ON_COMPONENT_REPLACED (nint value);


        /// <summary>
        ///   System.Void add_OnDestroyEntity(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnDestroyEntity")]
        ///  extern void ADD_ON_DESTROY_ENTITY (nint value);


        /// <summary>
        ///   System.Void add_OnEntityReleased(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityReleased")]
        ///  extern void ADD_ON_ENTITY_RELEASED (nint value);


        /// <summary>
        ///   System.Void AddActivatingTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddActivatingTime")]
        ///  extern void ADD_ACTIVATING_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void AddActiveGridID(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddActiveGridID")]
        ///  extern void ADD_ACTIVE_GRID_ID (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void AddAsset(System.Int32 newAssetID)
        /// </summary>
        /// <param name="newAssetID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAsset")]
        ///  extern void ADD_ASSET (System.Int32 newAssetID);


        /// <summary>
        ///   System.Void AddAudioService(IAudioService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IAudioService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAudioService")]
        ///  extern void ADD_AUDIO_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void AddBag(System.Collections.Generic.List<GameEntity> newLst)
        /// </summary>
        /// <param name="newLst">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBag")]
        ///  extern void ADD_BAG (nint newLst);


        /// <summary>
        ///   System.Void AddBagIndex(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBagIndex")]
        ///  extern void ADD_BAG_INDEX (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddBagItemCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBagItemCount")]
        ///  extern void ADD_BAG_ITEM_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddBattleMode(PBProto.BattleMode newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.BattleMode</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBattleMode")]
        ///  extern void ADD_BATTLE_MODE (PBProto.BattleMode newValue);


        /// <summary>
        ///   System.Void AddBlowUpFlames(GameEntity[,] newArr, System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newArr">class GameEntity[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBlowUpFlames")]
        ///  extern void ADD_BLOW_UP_FLAMES (nint newArr, nint newList);


        /// <summary>
        ///   System.Void AddBombConfig(BombConfig newValue)
        /// </summary>
        /// <param name="newValue">class BombConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombConfig")]
        ///  extern void ADD_BOMB_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void AddBombCount(System.Int32 newValue, System.Int32 newItemCount)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <param name="newItemCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombCount")]
        ///  extern void ADD_BOMB_COUNT (System.Int32 newValue, System.Int32 newItemCount);


        /// <summary>
        ///   System.Void AddBombPower(System.Int32 newValue, System.Int32 newItemCount)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <param name="newItemCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombPower")]
        ///  extern void ADD_BOMB_POWER (System.Int32 newValue, System.Int32 newItemCount);


        /// <summary>
        ///   System.Void AddBombs(System.Collections.Generic.List<GameEntity>[,] newArr, System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newArr">class System.Collections.Generic.List<GameEntity>[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombs")]
        ///  extern void ADD_BOMBS (nint newArr, nint newList);


        /// <summary>
        ///   System.Void AddBombState(BombState newValue)
        /// </summary>
        /// <param name="newValue">enum BombState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombState")]
        ///  extern void ADD_BOMB_STATE (BombState newValue);


        /// <summary>
        ///   System.Void AddBombType(BombType newValue)
        /// </summary>
        /// <param name="newValue">enum BombType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombType")]
        ///  extern void ADD_BOMB_TYPE (BombType newValue);


        /// <summary>
        ///   System.Void AddBuffInvincible(SimpleFixMath.Fix newDuration)
        /// </summary>
        /// <param name="newDuration">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBuffInvincible")]
        ///  extern void ADD_BUFF_INVINCIBLE (SimpleFixMath.Fix newDuration);


        /// <summary>
        ///   System.Void AddBuffSlow(SimpleFixMath.Fix newDuration)
        /// </summary>
        /// <param name="newDuration">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBuffSlow")]
        ///  extern void ADD_BUFF_SLOW (SimpleFixMath.Fix newDuration);


        /// <summary>
        ///   System.Void AddBuffXJP(SimpleFixMath.Fix newDuration)
        /// </summary>
        /// <param name="newDuration">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBuffXJP")]
        ///  extern void ADD_BUFF_XJP (SimpleFixMath.Fix newDuration);


        /// <summary>
        ///   System.Void AddBuildings(GameEntity[,] newBunsArr, System.Collections.Generic.List<GameEntity> newBunsLst, GameEntity[,] newSculptureArr, System.Collections.Generic.List<GameEntity> newSculptureLst)
        /// </summary>
        /// <param name="newBunsArr">class GameEntity[,]</param>
        /// <param name="newBunsLst">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newSculptureArr">class GameEntity[,]</param>
        /// <param name="newSculptureLst">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBuildings")]
        ///  extern void ADD_BUILDINGS (nint newBunsArr, nint newBunsLst, nint newSculptureArr, nint newSculptureLst);


        /// <summary>
        ///   System.Void AddBunCount(System.Int32 newOwnerTeam, System.Int32 newEnemyTeam)
        /// </summary>
        /// <param name="newOwnerTeam">struct System.Int32</param>
        /// <param name="newEnemyTeam">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBunCount")]
        ///  extern void ADD_BUN_COUNT (System.Int32 newOwnerTeam, System.Int32 newEnemyTeam);


        /// <summary>
        ///   System.Void AddBunOrStoneCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBunOrStoneCount")]
        ///  extern void ADD_BUN_OR_STONE_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddCanPushBomb(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCanPushBomb")]
        ///  extern void ADD_CAN_PUSH_BOMB (System.Boolean newValue);


        /// <summary>
        ///   System.Void AddCatchCatCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCatchCatCount")]
        ///  extern void ADD_CATCH_CAT_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddComponent(System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddComponent")]
        ///  extern void ADD_COMPONENT (System.Int32 index, nint component);


        /// <summary>
        ///   System.Void AddComposeGrids(System.Collections.Generic.List<SimpleFixMath.FixVector2> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<SimpleFixMath.FixVector2></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddComposeGrids")]
        ///  extern void ADD_COMPOSE_GRIDS (nint newValue);


        /// <summary>
        ///   System.Void AddComposeWallType(ComposeWallType newValue)
        /// </summary>
        /// <param name="newValue">enum ComposeWallType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddComposeWallType")]
        ///  extern void ADD_COMPOSE_WALL_TYPE (ComposeWallType newValue);


        /// <summary>
        ///   System.Void AddConfigService(IConfigService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IConfigService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddConfigService")]
        ///  extern void ADD_CONFIG_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void AddDebugMessageCompoenet(System.String newMessage)
        /// </summary>
        /// <param name="newMessage">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDebugMessageCompoenet")]
        ///  extern void ADD_DEBUG_MESSAGE_COMPOENET (nint newMessage);


        /// <summary>
        ///   System.Void AddDoorDirType(DoorDirType newValue)
        /// </summary>
        /// <param name="newValue">enum DoorDirType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDoorDirType")]
        ///  extern void ADD_DOOR_DIR_TYPE (DoorDirType newValue);


        /// <summary>
        ///   System.Void AddEmoTyp(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEmoTyp")]
        ///  extern void ADD_EMO_TYP (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddEnablePassWall(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEnablePassWall")]
        ///  extern void ADD_ENABLE_PASS_WALL (System.Boolean newValue);


        /// <summary>
        ///   System.Void AddEntityEndLocalTime(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEntityEndLocalTime")]
        ///  extern void ADD_ENTITY_END_LOCAL_TIME (System.Single newValue);


        /// <summary>
        ///   System.Void AddEntityEndTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEntityEndTime")]
        ///  extern void ADD_ENTITY_END_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void AddEntityExpectEndTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEntityExpectEndTime")]
        ///  extern void ADD_ENTITY_EXPECT_END_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void AddEntityFactoryService(EntityFactoryService newInstance)
        /// </summary>
        /// <param name="newInstance">class EntityFactoryService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEntityFactoryService")]
        ///  extern void ADD_ENTITY_FACTORY_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void AddEntityStartLocalTime(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEntityStartLocalTime")]
        ///  extern void ADD_ENTITY_START_LOCAL_TIME (System.Single newValue);


        /// <summary>
        ///   System.Void AddEntityStartTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEntityStartTime")]
        ///  extern void ADD_ENTITY_START_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void AddExpectPosition(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddExpectPosition")]
        ///  extern void ADD_EXPECT_POSITION (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void AddFirstEnterGrid(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFirstEnterGrid")]
        ///  extern void ADD_FIRST_ENTER_GRID (System.Boolean newValue);


        /// <summary>
        ///   System.Void AddFirstKillToWinTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFirstKillToWinTeam")]
        ///  extern void ADD_FIRST_KILL_TO_WIN_TEAM (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.Void AddFlameHitCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFlameHitCount")]
        ///  extern void ADD_FLAME_HIT_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddFlames(GameEntity[,] newArr, System.Collections.Generic.List<GameEntity> newList, System.Collections.Generic.List<GameEntity> newLatest_list)
        /// </summary>
        /// <param name="newArr">class GameEntity[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newLatest_list">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFlames")]
        ///  extern void ADD_FLAMES (nint newArr, nint newList, nint newLatest_list);


        /// <summary>
        ///   System.Void AddFlyingDirection(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFlyingDirection")]
        ///  extern void ADD_FLYING_DIRECTION (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void AddFlyStep(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFlyStep")]
        ///  extern void ADD_FLY_STEP (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddFlyTarget(SimpleFixMath.FixVector2 newPos, SimpleFixMath.FixVector2 newGridID)
        /// </summary>
        /// <param name="newPos">struct SimpleFixMath.FixVector2</param>
        /// <param name="newGridID">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFlyTarget")]
        ///  extern void ADD_FLY_TARGET (SimpleFixMath.FixVector2 newPos, SimpleFixMath.FixVector2 newGridID);


        /// <summary>
        ///   System.Void AddGameFrame(System.UInt32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.UInt32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameFrame")]
        ///  extern void ADD_GAME_FRAME (System.UInt32 newValue);


        /// <summary>
        ///   System.Void AddGameProgress(GameProgressState newValue)
        /// </summary>
        /// <param name="newValue">enum GameProgressState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameProgress")]
        ///  extern void ADD_GAME_PROGRESS (GameProgressState newValue);


        /// <summary>
        ///   System.Void AddGameResult(GameReuslt newValue, System.Collections.Generic.List<System.UInt32> newWinnerList)
        /// </summary>
        /// <param name="newValue">enum GameReuslt</param>
        /// <param name="newWinnerList">class System.Collections.Generic.List<System.UInt32></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameResult")]
        ///  extern void ADD_GAME_RESULT (GameReuslt newValue, nint newWinnerList);


        /// <summary>
        ///   System.Void AddGameTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameTime")]
        ///  extern void ADD_GAME_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void AddGameTotalSec(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameTotalSec")]
        ///  extern void ADD_GAME_TOTAL_SEC (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddGemMaxScore(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGemMaxScore")]
        ///  extern void ADD_GEM_MAX_SCORE (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddGM(GMParam newValue)
        /// </summary>
        /// <param name="newValue">class GMParam</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGM")]
        ///  extern void ADD_GM (nint newValue);


        /// <summary>
        ///   System.Void AddGridBounds(Bounds2D newValue)
        /// </summary>
        /// <param name="newValue">class Bounds2D</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGridBounds")]
        ///  extern void ADD_GRID_BOUNDS (nint newValue);


        /// <summary>
        ///   System.Void AddGridID(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGridID")]
        ///  extern void ADD_GRID_ID (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void AddHeroArr(GameEntity[] newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHeroArr")]
        ///  extern void ADD_HERO_ARR (nint newValue);


        /// <summary>
        ///   System.Void AddHeroConfig(RoleConfig newValue)
        /// </summary>
        /// <param name="newValue">class RoleConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHeroConfig")]
        ///  extern void ADD_HERO_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void AddHeroData(PBProto.BattleHeroData newValue)
        /// </summary>
        /// <param name="newValue">class PBProto.BattleHeroData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHeroData")]
        ///  extern void ADD_HERO_DATA (nint newValue);


        /// <summary>
        ///   System.Void AddInputDirection(PBProto.MoveDirectionType newValue, PBProto.MoveDirectionType newLast)
        /// </summary>
        /// <param name="newValue">enum PBProto.MoveDirectionType</param>
        /// <param name="newLast">enum PBProto.MoveDirectionType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInputDirection")]
        ///  extern void ADD_INPUT_DIRECTION (PBProto.MoveDirectionType newValue, PBProto.MoveDirectionType newLast);


        /// <summary>
        ///   System.Void AddInputService(IInputService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IInputService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInputService")]
        ///  extern void ADD_INPUT_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void AddIsBlowedUp(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddIsBlowedUp")]
        ///  extern void ADD_IS_BLOWED_UP (System.Boolean newValue);


        /// <summary>
        ///   System.Void AddIsPetrified(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddIsPetrified")]
        ///  extern void ADD_IS_PETRIFIED (System.Boolean newValue);


        /// <summary>
        ///   System.Void AddIsTransparent(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddIsTransparent")]
        ///  extern void ADD_IS_TRANSPARENT (System.Boolean newValue);


        /// <summary>
        ///   System.Void AddItemBird(System.Collections.Generic.Queue<GameEntity> newQueue, SimpleFixMath.Fix newTimer, ItemBirdState newState)
        /// </summary>
        /// <param name="newQueue">class System.Collections.Generic.Queue<GameEntity></param>
        /// <param name="newTimer">struct SimpleFixMath.Fix</param>
        /// <param name="newState">enum ItemBirdState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddItemBird")]
        ///  extern void ADD_ITEM_BIRD (nint newQueue, SimpleFixMath.Fix newTimer, ItemBirdState newState);


        /// <summary>
        ///   System.Void AddItems(System.Collections.Generic.Queue<GameEntity>[,] newQueue, System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newQueue">class System.Collections.Generic.Queue<GameEntity>[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddItems")]
        ///  extern void ADD_ITEMS (nint newQueue, nint newList);


        /// <summary>
        ///   System.Void AddItemState(ItemState newValue)
        /// </summary>
        /// <param name="newValue">enum ItemState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddItemState")]
        ///  extern void ADD_ITEM_STATE (ItemState newValue);


        /// <summary>
        ///   System.Void AddItemType(ItemType newValue)
        /// </summary>
        /// <param name="newValue">enum ItemType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddItemType")]
        ///  extern void ADD_ITEM_TYPE (ItemType newValue);


        /// <summary>
        ///   System.Void AddKillerUid(System.UInt64 newValue)
        /// </summary>
        /// <param name="newValue">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddKillerUid")]
        ///  extern void ADD_KILLER_UID (System.UInt64 newValue);


        /// <summary>
        ///   System.Void AddLastApproachTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLastApproachTime")]
        ///  extern void ADD_LAST_APPROACH_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void AddLastGridID(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLastGridID")]
        ///  extern void ADD_LAST_GRID_ID (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void AddLastKillTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLastKillTeam")]
        ///  extern void ADD_LAST_KILL_TEAM (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.Void AddLastPickPoint(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLastPickPoint")]
        ///  extern void ADD_LAST_PICK_POINT (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.Void AddLocalBombs(System.Collections.Generic.List<GameEntity>[,] newArr)
        /// </summary>
        /// <param name="newArr">class System.Collections.Generic.List<GameEntity>[,]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLocalBombs")]
        ///  extern void ADD_LOCAL_BOMBS (nint newArr);


        /// <summary>
        ///   System.Void AddLocalPlayers(System.Collections.Generic.List<GameEntity> newLst)
        /// </summary>
        /// <param name="newLst">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLocalPlayers")]
        ///  extern void ADD_LOCAL_PLAYERS (nint newLst);


        /// <summary>
        ///   System.Void AddLogicDT(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLogicDT")]
        ///  extern void ADD_LOGIC_DT (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void AddMainPlayerInfos(GameEntity newLogicEntity, PBProto.MoveDirectionType newMoveDir, PBProto.MoveDirectionType newFaceDir, SafeVector2 newPos, UnityEngine.Vector2 newLastPos)
        /// </summary>
        /// <param name="newLogicEntity">class GameEntity</param>
        /// <param name="newMoveDir">enum PBProto.MoveDirectionType</param>
        /// <param name="newFaceDir">enum PBProto.MoveDirectionType</param>
        /// <param name="newPos">class SafeVector2</param>
        /// <param name="newLastPos">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMainPlayerInfos")]
        ///  extern void ADD_MAIN_PLAYER_INFOS (nint newLogicEntity, PBProto.MoveDirectionType newMoveDir, PBProto.MoveDirectionType newFaceDir, nint newPos, UnityEngine.Vector2 newLastPos);


        /// <summary>
        ///   System.Void AddMapBounds(SimpleFixMath.FixVector2 newMax, SimpleFixMath.FixVector2 newMin)
        /// </summary>
        /// <param name="newMax">struct SimpleFixMath.FixVector2</param>
        /// <param name="newMin">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapBounds")]
        ///  extern void ADD_MAP_BOUNDS (SimpleFixMath.FixVector2 newMax, SimpleFixMath.FixVector2 newMin);


        /// <summary>
        ///   System.Void AddMapConfig(MapConfig newValue)
        /// </summary>
        /// <param name="newValue">class MapConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapConfig")]
        ///  extern void ADD_MAP_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void AddMapElems(GameEntity[,] newWallArr, GameEntity[,] newDoorArr, System.Collections.Generic.List<GameEntity> newComposeWallList, GameEntity[,] newBrickArr, System.Collections.Generic.List<GameEntity> newBrickList, GameEntity[,] newMoveBrickArr, System.Collections.Generic.List<GameEntity> newMoveBrickList, GameEntity[,] newGrassArr, System.Collections.Generic.List<GameEntity> newGrassList)
        /// </summary>
        /// <param name="newWallArr">class GameEntity[,]</param>
        /// <param name="newDoorArr">class GameEntity[,]</param>
        /// <param name="newComposeWallList">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newBrickArr">class GameEntity[,]</param>
        /// <param name="newBrickList">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newMoveBrickArr">class GameEntity[,]</param>
        /// <param name="newMoveBrickList">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newGrassArr">class GameEntity[,]</param>
        /// <param name="newGrassList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapElems")]
        ///  extern void ADD_MAP_ELEMS (nint newWallArr, nint newDoorArr, nint newComposeWallList, nint newBrickArr, nint newBrickList, nint newMoveBrickArr, nint newMoveBrickList, nint newGrassArr, nint newGrassList);


        /// <summary>
        ///   System.Void AddMapElemState(MapElemState newValue)
        /// </summary>
        /// <param name="newValue">enum MapElemState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapElemState")]
        ///  extern void ADD_MAP_ELEM_STATE (MapElemState newValue);


        /// <summary>
        ///   System.Void AddMapElemType(MapElemType newValue)
        /// </summary>
        /// <param name="newValue">enum MapElemType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapElemType")]
        ///  extern void ADD_MAP_ELEM_TYPE (MapElemType newValue);


        /// <summary>
        ///   System.Void AddMapGrids(GameEntity[,] newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity[,]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapGrids")]
        ///  extern void ADD_MAP_GRIDS (nint newValue);


        /// <summary>
        ///   System.Void AddMapType(PBProto.MapType newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.MapType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapType")]
        ///  extern void ADD_MAP_TYPE (PBProto.MapType newValue);


        /// <summary>
        ///   System.Void AddMovable(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMovable")]
        ///  extern void ADD_MOVABLE (System.Boolean newValue);


        /// <summary>
        ///   System.Void AddMoveDirection(PBProto.MoveDirectionType newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.MoveDirectionType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMoveDirection")]
        ///  extern void ADD_MOVE_DIRECTION (PBProto.MoveDirectionType newValue);


        /// <summary>
        ///   System.Void AddMoveSpeed(System.Int32 newIndex, SimpleFixMath.Fix newValue, System.Int32 newItemCount)
        /// </summary>
        /// <param name="newIndex">struct System.Int32</param>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <param name="newItemCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMoveSpeed")]
        ///  extern void ADD_MOVE_SPEED (System.Int32 newIndex, SimpleFixMath.Fix newValue, System.Int32 newItemCount);


        /// <summary>
        ///   System.Void AddNetHeroIndex(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddNetHeroIndex")]
        ///  extern void ADD_NET_HERO_INDEX (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddNetState(NetState newValue)
        /// </summary>
        /// <param name="newValue">enum NetState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddNetState")]
        ///  extern void ADD_NET_STATE (NetState newValue);


        /// <summary>
        ///   System.Void AddOwnerGridID(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOwnerGridID")]
        ///  extern void ADD_OWNER_GRID_ID (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void AddOwnerUID(System.UInt64 newValue)
        /// </summary>
        /// <param name="newValue">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOwnerUID")]
        ///  extern void ADD_OWNER_UID (System.UInt64 newValue);


        /// <summary>
        ///   System.Void AddParentGrids(System.Collections.Generic.List<SimpleFixMath.FixVector2> newList)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<SimpleFixMath.FixVector2></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddParentGrids")]
        ///  extern void ADD_PARENT_GRIDS (nint newList);


        /// <summary>
        ///   System.Void AddPhasingPeriod(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPhasingPeriod")]
        ///  extern void ADD_PHASING_PERIOD (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void AddPickType(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPickType")]
        ///  extern void ADD_PICK_TYPE (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.Void AddPosition(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPosition")]
        ///  extern void ADD_POSITION (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void AddPowerHitGrids(System.Collections.Generic.Dictionary<PBProto.MoveDirectionType,System.Collections.Generic.List<SimpleFixMath.FixVector2>> newDict)
        /// </summary>
        /// <param name="newDict">class System.Collections.Generic.Dictionary<PBProto.MoveDirectionType,System.Collections.Generic.List<SimpleFixMath.FixVector2>></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPowerHitGrids")]
        ///  extern void ADD_POWER_HIT_GRIDS (nint newDict);


        /// <summary>
        ///   System.Void AddPushTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPushTime")]
        ///  extern void ADD_PUSH_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void AddRandom(System.Random newValue)
        /// </summary>
        /// <param name="newValue">class System.Random</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRandom")]
        ///  extern void ADD_RANDOM (nint newValue);


        /// <summary>
        ///   System.Void AddRelifeCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRelifeCount")]
        ///  extern void ADD_RELIFE_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddRelifeInfo(SimpleFixMath.Fix newTime, SimpleFixMath.FixVector2 newGridID)
        /// </summary>
        /// <param name="newTime">struct SimpleFixMath.Fix</param>
        /// <param name="newGridID">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRelifeInfo")]
        ///  extern void ADD_RELIFE_INFO (SimpleFixMath.Fix newTime, SimpleFixMath.FixVector2 newGridID);


        /// <summary>
        ///   System.Void AddRelifeWaitTime(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRelifeWaitTime")]
        ///  extern void ADD_RELIFE_WAIT_TIME (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddRoleState(RoleState newValue)
        /// </summary>
        /// <param name="newValue">enum RoleState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRoleState")]
        ///  extern void ADD_ROLE_STATE (RoleState newValue);


        /// <summary>
        ///   System.Void AddRootParent(System.Int32 newIndex)
        /// </summary>
        /// <param name="newIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRootParent")]
        ///  extern void ADD_ROOT_PARENT (System.Int32 newIndex);


        /// <summary>
        ///   System.Void AddSonGrids(System.Collections.Generic.List<SimpleFixMath.FixVector2> newList)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<SimpleFixMath.FixVector2></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSonGrids")]
        ///  extern void ADD_SON_GRIDS (nint newList);


        /// <summary>
        ///   System.Void AddStatisData(System.Int32 newKillCount, System.Int32 newRescueCount, System.Int32 newDeadCount, System.Int32 newCombKillTimes, System.Int32 newMoveGridCount)
        /// </summary>
        /// <param name="newKillCount">struct System.Int32</param>
        /// <param name="newRescueCount">struct System.Int32</param>
        /// <param name="newDeadCount">struct System.Int32</param>
        /// <param name="newCombKillTimes">struct System.Int32</param>
        /// <param name="newMoveGridCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddStatisData")]
        ///  extern void ADD_STATIS_DATA (System.Int32 newKillCount, System.Int32 newRescueCount, System.Int32 newDeadCount, System.Int32 newCombKillTimes, System.Int32 newMoveGridCount);


        /// <summary>
        ///   System.Void AddStoneCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddStoneCount")]
        ///  extern void ADD_STONE_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTeam")]
        ///  extern void ADD_TEAM (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.Void AddTimerBomb(System.Int32 newCountDown)
        /// </summary>
        /// <param name="newCountDown">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTimerBomb")]
        ///  extern void ADD_TIMER_BOMB (System.Int32 newCountDown);


        /// <summary>
        ///   System.Void AddTimerService(ITimer newInstance)
        /// </summary>
        /// <param name="newInstance">interface ITimer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTimerService")]
        ///  extern void ADD_TIMER_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void AddTransparentBombEndTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTransparentBombEndTime")]
        ///  extern void ADD_TRANSPARENT_BOMB_END_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void AddTrappedCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTrappedCount")]
        ///  extern void ADD_TRAPPED_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddTrappedEndTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTrappedEndTime")]
        ///  extern void ADD_TRAPPED_END_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void AddTreasureData(System.Int32 newRedGemCount, System.Int32 newYellowGemCount, System.Int32 newGreenGemCount, ItemType newLastPickItem)
        /// </summary>
        /// <param name="newRedGemCount">struct System.Int32</param>
        /// <param name="newYellowGemCount">struct System.Int32</param>
        /// <param name="newGreenGemCount">struct System.Int32</param>
        /// <param name="newLastPickItem">enum ItemType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTreasureData")]
        ///  extern void ADD_TREASURE_DATA (System.Int32 newRedGemCount, System.Int32 newYellowGemCount, System.Int32 newGreenGemCount, ItemType newLastPickItem);


        /// <summary>
        ///   System.Void AddTreasureGemLeader(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTreasureGemLeader")]
        ///  extern void ADD_TREASURE_GEM_LEADER (System.Boolean newValue);


        /// <summary>
        ///   System.Void AddTryBomb(TryBombStatus newStatus)
        /// </summary>
        /// <param name="newStatus">enum TryBombStatus</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTryBomb")]
        ///  extern void ADD_TRY_BOMB (TryBombStatus newStatus);


        /// <summary>
        ///   System.Void AddTwoTeamMatch(PBProto.TeamEnum newTeam1, PBProto.TeamEnum newTeam2)
        /// </summary>
        /// <param name="newTeam1">enum PBProto.TeamEnum</param>
        /// <param name="newTeam2">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTwoTeamMatch")]
        ///  extern void ADD_TWO_TEAM_MATCH (PBProto.TeamEnum newTeam1, PBProto.TeamEnum newTeam2);


        /// <summary>
        ///   System.Void AddUID(System.UInt64 newValue)
        /// </summary>
        /// <param name="newValue">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUID")]
        ///  extern void ADD_UID (System.UInt64 newValue);


        /// <summary>
        ///   System.Void AddUnexplodeBomb(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUnexplodeBomb")]
        ///  extern void ADD_UNEXPLODE_BOMB (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddUnitType(UnitType newValue)
        /// </summary>
        /// <param name="newValue">enum UnitType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUnitType")]
        ///  extern void ADD_UNIT_TYPE (UnitType newValue);


        /// <summary>
        ///   System.Void AddUseBagNum(PBProto.UseBagNum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.UseBagNum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUseBagNum")]
        ///  extern void ADD_USE_BAG_NUM (PBProto.UseBagNum newValue);


        /// <summary>
        ///   System.Void AddUsedItemID(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUsedItemID")]
        ///  extern void ADD_USED_ITEM_ID (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddView(IView newInstance)
        /// </summary>
        /// <param name="newInstance">interface IView</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddView")]
        ///  extern void ADD_VIEW (nint newInstance);


        /// <summary>
        ///   System.Void AddViewField(System.Int32[,] newArr)
        /// </summary>
        /// <param name="newArr">class System.Int32[,]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddViewField")]
        ///  extern void ADD_VIEW_FIELD (nint newArr);


        /// <summary>
        ///   System.Void AddWinnerTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWinnerTeam")]
        ///  extern void ADD_WINNER_TEAM (PBProto.TeamEnum newValue);


        /// <summary>
        ///   Entitas.ContextInfo createDefaultContextInfo()
        /// </summary>
        /// <returns>class Entitas.ContextInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("createDefaultContextInfo")]
        ///  extern nint CREATE_DEFAULT_CONTEXT_INFO ();


        /// <summary>
        ///   System.Void Destroy()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy")]
        ///  extern void DESTROY ();


        /// <summary>
        ///   ActivatingTimeComponent get_activatingTime()
        /// </summary>
        /// <returns>class ActivatingTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_activatingTime")]
        ///  extern nint GET_ACTIVATING_TIME ();


        /// <summary>
        ///   ActiveGridIDComponent get_activeGridID()
        /// </summary>
        /// <returns>class ActiveGridIDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_activeGridID")]
        ///  extern nint GET_ACTIVE_GRID_ID ();


        /// <summary>
        ///   Entitas.IAERC get_aerc()
        /// </summary>
        /// <returns>interface Entitas.IAERC</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_aerc")]
        ///  extern nint GET_AERC ();


        /// <summary>
        ///   AnyAssetListenerComponent get_anyAssetListener()
        /// </summary>
        /// <returns>class AnyAssetListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_anyAssetListener")]
        ///  extern nint GET_ANY_ASSET_LISTENER ();


        /// <summary>
        ///   AnyFlamesListenerComponent get_anyFlamesListener()
        /// </summary>
        /// <returns>class AnyFlamesListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_anyFlamesListener")]
        ///  extern nint GET_ANY_FLAMES_LISTENER ();


        /// <summary>
        ///   AnyGameProgressListenerComponent get_anyGameProgressListener()
        /// </summary>
        /// <returns>class AnyGameProgressListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_anyGameProgressListener")]
        ///  extern nint GET_ANY_GAME_PROGRESS_LISTENER ();


        /// <summary>
        ///   AnyGMListenerComponent get_anyGMListener()
        /// </summary>
        /// <returns>class AnyGMListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_anyGMListener")]
        ///  extern nint GET_ANY_GM_LISTENER ();


        /// <summary>
        ///   AnyViewFieldListenerComponent get_anyViewFieldListener()
        /// </summary>
        /// <returns>class AnyViewFieldListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_anyViewFieldListener")]
        ///  extern nint GET_ANY_VIEW_FIELD_LISTENER ();


        /// <summary>
        ///   AnyViewListenerComponent get_anyViewListener()
        /// </summary>
        /// <returns>class AnyViewListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_anyViewListener")]
        ///  extern nint GET_ANY_VIEW_LISTENER ();


        /// <summary>
        ///   AssetComponent get_asset()
        /// </summary>
        /// <returns>class AssetComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_asset")]
        ///  extern nint GET_ASSET ();


        /// <summary>
        ///   AudioServiceComponent get_audioService()
        /// </summary>
        /// <returns>class AudioServiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_audioService")]
        ///  extern nint GET_AUDIO_SERVICE ();


        /// <summary>
        ///   BagComponent get_bag()
        /// </summary>
        /// <returns>class BagComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bag")]
        ///  extern nint GET_BAG ();


        /// <summary>
        ///   BagIndexComponent get_bagIndex()
        /// </summary>
        /// <returns>class BagIndexComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bagIndex")]
        ///  extern nint GET_BAG_INDEX ();


        /// <summary>
        ///   BagItemCountComponent get_bagItemCount()
        /// </summary>
        /// <returns>class BagItemCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bagItemCount")]
        ///  extern nint GET_BAG_ITEM_COUNT ();


        /// <summary>
        ///   BagListenerComponent get_bagListener()
        /// </summary>
        /// <returns>class BagListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bagListener")]
        ///  extern nint GET_BAG_LISTENER ();


        /// <summary>
        ///   BattleModeComponent get_battleMode()
        /// </summary>
        /// <returns>class BattleModeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_battleMode")]
        ///  extern nint GET_BATTLE_MODE ();


        /// <summary>
        ///   BlowUpFlamesComponent get_blowUpFlames()
        /// </summary>
        /// <returns>class BlowUpFlamesComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_blowUpFlames")]
        ///  extern nint GET_BLOW_UP_FLAMES ();


        /// <summary>
        ///   BombConfigComponent get_bombConfig()
        /// </summary>
        /// <returns>class BombConfigComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombConfig")]
        ///  extern nint GET_BOMB_CONFIG ();


        /// <summary>
        ///   BombCountComponent get_bombCount()
        /// </summary>
        /// <returns>class BombCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombCount")]
        ///  extern nint GET_BOMB_COUNT ();


        /// <summary>
        ///   BombCountListenerComponent get_bombCountListener()
        /// </summary>
        /// <returns>class BombCountListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombCountListener")]
        ///  extern nint GET_BOMB_COUNT_LISTENER ();


        /// <summary>
        ///   BombPowerComponent get_bombPower()
        /// </summary>
        /// <returns>class BombPowerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombPower")]
        ///  extern nint GET_BOMB_POWER ();


        /// <summary>
        ///   BombPowerListenerComponent get_bombPowerListener()
        /// </summary>
        /// <returns>class BombPowerListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombPowerListener")]
        ///  extern nint GET_BOMB_POWER_LISTENER ();


        /// <summary>
        ///   BombsComponent get_bombs()
        /// </summary>
        /// <returns>class BombsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombs")]
        ///  extern nint GET_BOMBS ();


        /// <summary>
        ///   BombStateComponent get_bombState()
        /// </summary>
        /// <returns>class BombStateComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombState")]
        ///  extern nint GET_BOMB_STATE ();


        /// <summary>
        ///   BombStateListenerComponent get_bombStateListener()
        /// </summary>
        /// <returns>class BombStateListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombStateListener")]
        ///  extern nint GET_BOMB_STATE_LISTENER ();


        /// <summary>
        ///   BombTypeComponent get_bombType()
        /// </summary>
        /// <returns>class BombTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombType")]
        ///  extern nint GET_BOMB_TYPE ();


        /// <summary>
        ///   BuffInvincible get_buffInvincible()
        /// </summary>
        /// <returns>class BuffInvincible</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_buffInvincible")]
        ///  extern nint GET_BUFF_INVINCIBLE ();


        /// <summary>
        ///   BuffInvincibleListenerComponent get_buffInvincibleListener()
        /// </summary>
        /// <returns>class BuffInvincibleListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_buffInvincibleListener")]
        ///  extern nint GET_BUFF_INVINCIBLE_LISTENER ();


        /// <summary>
        ///   BuffInvincibleRemovedListenerComponent get_buffInvincibleRemovedListener()
        /// </summary>
        /// <returns>class BuffInvincibleRemovedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_buffInvincibleRemovedListener")]
        ///  extern nint GET_BUFF_INVINCIBLE_REMOVED_LISTENER ();


        /// <summary>
        ///   BuffSlow get_buffSlow()
        /// </summary>
        /// <returns>class BuffSlow</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_buffSlow")]
        ///  extern nint GET_BUFF_SLOW ();


        /// <summary>
        ///   BuffXJP get_buffXJP()
        /// </summary>
        /// <returns>class BuffXJP</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_buffXJP")]
        ///  extern nint GET_BUFF_XJP ();


        /// <summary>
        ///   BuildingsComponent get_buildings()
        /// </summary>
        /// <returns>class BuildingsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_buildings")]
        ///  extern nint GET_BUILDINGS ();


        /// <summary>
        ///   BunCountComponent get_bunCount()
        /// </summary>
        /// <returns>class BunCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bunCount")]
        ///  extern nint GET_BUN_COUNT ();


        /// <summary>
        ///   BunCountListenerComponent get_bunCountListener()
        /// </summary>
        /// <returns>class BunCountListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bunCountListener")]
        ///  extern nint GET_BUN_COUNT_LISTENER ();


        /// <summary>
        ///   BunOrStoneCountComponent get_bunOrStoneCount()
        /// </summary>
        /// <returns>class BunOrStoneCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bunOrStoneCount")]
        ///  extern nint GET_BUN_OR_STONE_COUNT ();


        /// <summary>
        ///   CanPushBombComponent get_canPushBomb()
        /// </summary>
        /// <returns>class CanPushBombComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_canPushBomb")]
        ///  extern nint GET_CAN_PUSH_BOMB ();


        /// <summary>
        ///   CatchCatCountComponent get_catchCatCount()
        /// </summary>
        /// <returns>class CatchCatCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_catchCatCount")]
        ///  extern nint GET_CATCH_CAT_COUNT ();


        /// <summary>
        ///   System.Collections.Generic.Stack<Entitas.IComponent>[] get_componentPools()
        /// </summary>
        /// <returns>class System.Collections.Generic.Stack<Entitas.IComponent>[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_componentPools")]
        ///  extern nint GET_COMPONENT_POOLS ();


        /// <summary>
        ///   ComposeGridsComponent get_composeGrids()
        /// </summary>
        /// <returns>class ComposeGridsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_composeGrids")]
        ///  extern nint GET_COMPOSE_GRIDS ();


        /// <summary>
        ///   ComposeWallTypeComponent get_composeWallType()
        /// </summary>
        /// <returns>class ComposeWallTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_composeWallType")]
        ///  extern nint GET_COMPOSE_WALL_TYPE ();


        /// <summary>
        ///   ConfigServiceComponent get_configService()
        /// </summary>
        /// <returns>class ConfigServiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_configService")]
        ///  extern nint GET_CONFIG_SERVICE ();


        /// <summary>
        ///   Entitas.ContextInfo get_contextInfo()
        /// </summary>
        /// <returns>class Entitas.ContextInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_contextInfo")]
        ///  extern nint GET_CONTEXT_INFO ();


        /// <summary>
        ///   System.Int32 get_creationIndex()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_creationIndex")]
        ///  extern System.Int32 GET_CREATION_INDEX ();


        /// <summary>
        ///   DebugMessageCompoenet get_debugMessageCompoenet()
        /// </summary>
        /// <returns>class DebugMessageCompoenet</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_debugMessageCompoenet")]
        ///  extern nint GET_DEBUG_MESSAGE_COMPOENET ();


        /// <summary>
        ///   DestroyedListenerComponent get_destroyedListener()
        /// </summary>
        /// <returns>class DestroyedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_destroyedListener")]
        ///  extern nint GET_DESTROYED_LISTENER ();


        /// <summary>
        ///   DoorDirTypeComponent get_doorDirType()
        /// </summary>
        /// <returns>class DoorDirTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_doorDirType")]
        ///  extern nint GET_DOOR_DIR_TYPE ();


        /// <summary>
        ///   EmoTypComponent get_emoTyp()
        /// </summary>
        /// <returns>class EmoTypComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_emoTyp")]
        ///  extern nint GET_EMO_TYP ();


        /// <summary>
        ///   EmoTypListenerComponent get_emoTypListener()
        /// </summary>
        /// <returns>class EmoTypListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_emoTypListener")]
        ///  extern nint GET_EMO_TYP_LISTENER ();


        /// <summary>
        ///   EnablePassWallComponent get_enablePassWall()
        /// </summary>
        /// <returns>class EnablePassWallComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_enablePassWall")]
        ///  extern nint GET_ENABLE_PASS_WALL ();


        /// <summary>
        ///   EntityEndLocalTimeComponent get_entityEndLocalTime()
        /// </summary>
        /// <returns>class EntityEndLocalTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_entityEndLocalTime")]
        ///  extern nint GET_ENTITY_END_LOCAL_TIME ();


        /// <summary>
        ///   EntityEndTimeComponent get_entityEndTime()
        /// </summary>
        /// <returns>class EntityEndTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_entityEndTime")]
        ///  extern nint GET_ENTITY_END_TIME ();


        /// <summary>
        ///   EntityExpectEndTimeComponent get_entityExpectEndTime()
        /// </summary>
        /// <returns>class EntityExpectEndTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_entityExpectEndTime")]
        ///  extern nint GET_ENTITY_EXPECT_END_TIME ();


        /// <summary>
        ///   EntityFactoryServiceComponent get_entityFactoryService()
        /// </summary>
        /// <returns>class EntityFactoryServiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_entityFactoryService")]
        ///  extern nint GET_ENTITY_FACTORY_SERVICE ();


        /// <summary>
        ///   EntityStartLocalTimeComponent get_entityStartLocalTime()
        /// </summary>
        /// <returns>class EntityStartLocalTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_entityStartLocalTime")]
        ///  extern nint GET_ENTITY_START_LOCAL_TIME ();


        /// <summary>
        ///   EntityStartTimeComponent get_entityStartTime()
        /// </summary>
        /// <returns>class EntityStartTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_entityStartTime")]
        ///  extern nint GET_ENTITY_START_TIME ();


        /// <summary>
        ///   ExpectPositionComponent get_expectPosition()
        /// </summary>
        /// <returns>class ExpectPositionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_expectPosition")]
        ///  extern nint GET_EXPECT_POSITION ();


        /// <summary>
        ///   FirstEnterGridComponent get_firstEnterGrid()
        /// </summary>
        /// <returns>class FirstEnterGridComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_firstEnterGrid")]
        ///  extern nint GET_FIRST_ENTER_GRID ();


        /// <summary>
        ///   FirstKillToWinTeamComponent get_firstKillToWinTeam()
        /// </summary>
        /// <returns>class FirstKillToWinTeamComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_firstKillToWinTeam")]
        ///  extern nint GET_FIRST_KILL_TO_WIN_TEAM ();


        /// <summary>
        ///   FlameHitCountComponent get_flameHitCount()
        /// </summary>
        /// <returns>class FlameHitCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_flameHitCount")]
        ///  extern nint GET_FLAME_HIT_COUNT ();


        /// <summary>
        ///   FlamesComponent get_flames()
        /// </summary>
        /// <returns>class FlamesComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_flames")]
        ///  extern nint GET_FLAMES ();


        /// <summary>
        ///   FlyingDirectionComponent get_flyingDirection()
        /// </summary>
        /// <returns>class FlyingDirectionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_flyingDirection")]
        ///  extern nint GET_FLYING_DIRECTION ();


        /// <summary>
        ///   FlyStepComponent get_flyStep()
        /// </summary>
        /// <returns>class FlyStepComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_flyStep")]
        ///  extern nint GET_FLY_STEP ();


        /// <summary>
        ///   FlyTargetComponent get_flyTarget()
        /// </summary>
        /// <returns>class FlyTargetComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_flyTarget")]
        ///  extern nint GET_FLY_TARGET ();


        /// <summary>
        ///   GameFrameComponent get_gameFrame()
        /// </summary>
        /// <returns>class GameFrameComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameFrame")]
        ///  extern nint GET_GAME_FRAME ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameEntity))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameEntity))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void AddAnyAssetListener(System.Collections.Generic.List<IAnyAssetListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyAssetListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyAssetListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_ASSET_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddAnyAssetListener(IAnyAssetListener value)
        /// </summary>
        /// <param name="value">interface IAnyAssetListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyAssetListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_ASSET_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddAnyFlamesListener(System.Collections.Generic.List<IAnyFlamesListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyFlamesListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyFlamesListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_FLAMES_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddAnyFlamesListener(IAnyFlamesListener value)
        /// </summary>
        /// <param name="value">interface IAnyFlamesListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyFlamesListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_FLAMES_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddAnyGameProgressListener(System.Collections.Generic.List<IAnyGameProgressListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyGameProgressListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyGameProgressListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_GAME_PROGRESS_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddAnyGameProgressListener(IAnyGameProgressListener value)
        /// </summary>
        /// <param name="value">interface IAnyGameProgressListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyGameProgressListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_GAME_PROGRESS_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddAnyGMListener(System.Collections.Generic.List<IAnyGMListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyGMListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyGMListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_GM_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddAnyGMListener(IAnyGMListener value)
        /// </summary>
        /// <param name="value">interface IAnyGMListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyGMListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_GM_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddAnyViewFieldListener(System.Collections.Generic.List<IAnyViewFieldListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyViewFieldListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyViewFieldListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_VIEW_FIELD_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddAnyViewFieldListener(IAnyViewFieldListener value)
        /// </summary>
        /// <param name="value">interface IAnyViewFieldListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyViewFieldListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_VIEW_FIELD_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddAnyViewListener(System.Collections.Generic.List<IAnyViewListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyViewListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyViewListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_VIEW_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddAnyViewListener(IAnyViewListener value)
        /// </summary>
        /// <param name="value">interface IAnyViewListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAnyViewListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ANY_VIEW_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddBagListener(System.Collections.Generic.List<IBagListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBagListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBagListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BAG_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddBagListener(IBagListener value)
        /// </summary>
        /// <param name="value">interface IBagListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBagListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BAG_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddBombCountListener(System.Collections.Generic.List<IBombCountListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBombCountListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BOMB_COUNT_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddBombCountListener(IBombCountListener value)
        /// </summary>
        /// <param name="value">interface IBombCountListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BOMB_COUNT_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddBombPowerListener(System.Collections.Generic.List<IBombPowerListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBombPowerListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombPowerListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BOMB_POWER_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddBombPowerListener(IBombPowerListener value)
        /// </summary>
        /// <param name="value">interface IBombPowerListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombPowerListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BOMB_POWER_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddBombStateListener(System.Collections.Generic.List<IBombStateListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBombStateListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BOMB_STATE_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddBombStateListener(IBombStateListener value)
        /// </summary>
        /// <param name="value">interface IBombStateListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBombStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BOMB_STATE_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddBuffInvincibleListener(System.Collections.Generic.List<IBuffInvincibleListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBuffInvincibleListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBuffInvincibleListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BUFF_INVINCIBLE_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddBuffInvincibleListener(IBuffInvincibleListener value)
        /// </summary>
        /// <param name="value">interface IBuffInvincibleListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBuffInvincibleListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BUFF_INVINCIBLE_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddBuffInvincibleRemovedListener(System.Collections.Generic.List<IBuffInvincibleRemovedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBuffInvincibleRemovedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBuffInvincibleRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BUFF_INVINCIBLE_REMOVED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddBuffInvincibleRemovedListener(IBuffInvincibleRemovedListener value)
        /// </summary>
        /// <param name="value">interface IBuffInvincibleRemovedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBuffInvincibleRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BUFF_INVINCIBLE_REMOVED_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddBunCountListener(System.Collections.Generic.List<IBunCountListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBunCountListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBunCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BUN_COUNT_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddBunCountListener(IBunCountListener value)
        /// </summary>
        /// <param name="value">interface IBunCountListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddBunCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_BUN_COUNT_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddDestroyedListener(System.Collections.Generic.List<IDestroyedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IDestroyedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDestroyedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_DESTROYED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddDestroyedListener(IDestroyedListener value)
        /// </summary>
        /// <param name="value">interface IDestroyedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDestroyedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_DESTROYED_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddEmoTypListener(System.Collections.Generic.List<IEmoTypListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IEmoTypListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEmoTypListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_EMO_TYP_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddEmoTypListener(IEmoTypListener value)
        /// </summary>
        /// <param name="value">interface IEmoTypListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEmoTypListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_EMO_TYP_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddIsPetrifiedListener(System.Collections.Generic.List<IIsPetrifiedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IIsPetrifiedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddIsPetrifiedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_IS_PETRIFIED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddIsPetrifiedListener(IIsPetrifiedListener value)
        /// </summary>
        /// <param name="value">interface IIsPetrifiedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddIsPetrifiedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_IS_PETRIFIED_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddItemStateListener(System.Collections.Generic.List<IItemStateListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IItemStateListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddItemStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ITEM_STATE_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddItemStateListener(IItemStateListener value)
        /// </summary>
        /// <param name="value">interface IItemStateListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddItemStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ITEM_STATE_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddMapElemStateListener(System.Collections.Generic.List<IMapElemStateListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IMapElemStateListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapElemStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_MAP_ELEM_STATE_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddMapElemStateListener(IMapElemStateListener value)
        /// </summary>
        /// <param name="value">interface IMapElemStateListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapElemStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_MAP_ELEM_STATE_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddMoveDirectionListener(System.Collections.Generic.List<IMoveDirectionListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IMoveDirectionListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMoveDirectionListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_MOVE_DIRECTION_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddMoveDirectionListener(IMoveDirectionListener value)
        /// </summary>
        /// <param name="value">interface IMoveDirectionListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMoveDirectionListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_MOVE_DIRECTION_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddMoveSpeedListener(System.Collections.Generic.List<IMoveSpeedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IMoveSpeedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMoveSpeedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_MOVE_SPEED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddMoveSpeedListener(IMoveSpeedListener value)
        /// </summary>
        /// <param name="value">interface IMoveSpeedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMoveSpeedListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_MOVE_SPEED_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddNetStateListener(System.Collections.Generic.List<INetStateListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<INetStateListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddNetStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_NET_STATE_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddNetStateListener(INetStateListener value)
        /// </summary>
        /// <param name="value">interface INetStateListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddNetStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_NET_STATE_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddPickTypeListener(System.Collections.Generic.List<IPickTypeListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPickTypeListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPickTypeListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_PICK_TYPE_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddPickTypeListener(IPickTypeListener value)
        /// </summary>
        /// <param name="value">interface IPickTypeListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPickTypeListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_PICK_TYPE_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddPositionListener(System.Collections.Generic.List<IPositionListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPositionListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPositionListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_POSITION_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddPositionListener(IPositionListener value)
        /// </summary>
        /// <param name="value">interface IPositionListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPositionListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_POSITION_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddRoleStateListener(System.Collections.Generic.List<IRoleStateListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IRoleStateListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRoleStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ROLE_STATE_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddRoleStateListener(IRoleStateListener value)
        /// </summary>
        /// <param name="value">interface IRoleStateListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRoleStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_ROLE_STATE_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddStatisDataListener(System.Collections.Generic.List<IStatisDataListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IStatisDataListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddStatisDataListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_STATIS_DATA_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddStatisDataListener(IStatisDataListener value)
        /// </summary>
        /// <param name="value">interface IStatisDataListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddStatisDataListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_STATIS_DATA_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddStoneCountListener(System.Collections.Generic.List<IStoneCountListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IStoneCountListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddStoneCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_STONE_COUNT_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddStoneCountListener(IStoneCountListener value)
        /// </summary>
        /// <param name="value">interface IStoneCountListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddStoneCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_STONE_COUNT_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddTimerBombListener(System.Collections.Generic.List<ITimerBombListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<ITimerBombListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTimerBombListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_TIMER_BOMB_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddTimerBombListener(ITimerBombListener value)
        /// </summary>
        /// <param name="value">interface ITimerBombListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTimerBombListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_TIMER_BOMB_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddTreasureDataListener(System.Collections.Generic.List<ITreasureDataListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<ITreasureDataListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTreasureDataListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_TREASURE_DATA_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddTreasureDataListener(ITreasureDataListener value)
        /// </summary>
        /// <param name="value">interface ITreasureDataListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTreasureDataListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_TREASURE_DATA_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddTreasureGemLeaderListener(System.Collections.Generic.List<ITreasureGemLeaderListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<ITreasureGemLeaderListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTreasureGemLeaderListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_TREASURE_GEM_LEADER_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddTreasureGemLeaderListener(ITreasureGemLeaderListener value)
        /// </summary>
        /// <param name="value">interface ITreasureGemLeaderListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTreasureGemLeaderListener", Search = typeof(Search_GameEntity))]
        ///  extern void ADD_TREASURE_GEM_LEADER_LISTENER_01 (nint value);


        /// <summary>
        ///   Entitas.IComponent CreateComponent(System.Int32 index, System.Type type)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>interface Entitas.IComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_GameEntity))]
        ///  extern nint CREATE_COMPONENT_00 (System.Int32 index, nint type);


        /// <summary>
        ///   T CreateComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_GameEntity))]
        ///  extern nint CREATE_COMPONENT_01 (System.Int32 index);


        /// public static partial class Search_GameEntity
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


        /// <summary>
        ///   System.Void AddAnyAssetListener(System.Collections.Generic.List<IAnyAssetListener> newValue)
        /// </summary>
        /// public static bool ADD_ANY_ASSET_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyAssetListener", "System.Collections.Generic.List<IAnyAssetListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyAssetListener(IAnyAssetListener value)
        /// </summary>
        /// public static bool ADD_ANY_ASSET_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyAssetListener", "IAnyAssetListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyFlamesListener(System.Collections.Generic.List<IAnyFlamesListener> newValue)
        /// </summary>
        /// public static bool ADD_ANY_FLAMES_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyFlamesListener", "System.Collections.Generic.List<IAnyFlamesListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyFlamesListener(IAnyFlamesListener value)
        /// </summary>
        /// public static bool ADD_ANY_FLAMES_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyFlamesListener", "IAnyFlamesListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyGameProgressListener(System.Collections.Generic.List<IAnyGameProgressListener> newValue)
        /// </summary>
        /// public static bool ADD_ANY_GAME_PROGRESS_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyGameProgressListener", "System.Collections.Generic.List<IAnyGameProgressListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyGameProgressListener(IAnyGameProgressListener value)
        /// </summary>
        /// public static bool ADD_ANY_GAME_PROGRESS_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyGameProgressListener", "IAnyGameProgressListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyGMListener(System.Collections.Generic.List<IAnyGMListener> newValue)
        /// </summary>
        /// public static bool ADD_ANY_GM_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyGMListener", "System.Collections.Generic.List<IAnyGMListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyGMListener(IAnyGMListener value)
        /// </summary>
        /// public static bool ADD_ANY_GM_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyGMListener", "IAnyGMListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyViewFieldListener(System.Collections.Generic.List<IAnyViewFieldListener> newValue)
        /// </summary>
        /// public static bool ADD_ANY_VIEW_FIELD_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyViewFieldListener", "System.Collections.Generic.List<IAnyViewFieldListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyViewFieldListener(IAnyViewFieldListener value)
        /// </summary>
        /// public static bool ADD_ANY_VIEW_FIELD_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyViewFieldListener", "IAnyViewFieldListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyViewListener(System.Collections.Generic.List<IAnyViewListener> newValue)
        /// </summary>
        /// public static bool ADD_ANY_VIEW_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyViewListener", "System.Collections.Generic.List<IAnyViewListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddAnyViewListener(IAnyViewListener value)
        /// </summary>
        /// public static bool ADD_ANY_VIEW_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddAnyViewListener", "IAnyViewListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBagListener(System.Collections.Generic.List<IBagListener> newValue)
        /// </summary>
        /// public static bool ADD_BAG_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBagListener", "System.Collections.Generic.List<IBagListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBagListener(IBagListener value)
        /// </summary>
        /// public static bool ADD_BAG_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBagListener", "IBagListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBombCountListener(System.Collections.Generic.List<IBombCountListener> newValue)
        /// </summary>
        /// public static bool ADD_BOMB_COUNT_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBombCountListener", "System.Collections.Generic.List<IBombCountListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBombCountListener(IBombCountListener value)
        /// </summary>
        /// public static bool ADD_BOMB_COUNT_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBombCountListener", "IBombCountListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBombPowerListener(System.Collections.Generic.List<IBombPowerListener> newValue)
        /// </summary>
        /// public static bool ADD_BOMB_POWER_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBombPowerListener", "System.Collections.Generic.List<IBombPowerListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBombPowerListener(IBombPowerListener value)
        /// </summary>
        /// public static bool ADD_BOMB_POWER_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBombPowerListener", "IBombPowerListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBombStateListener(System.Collections.Generic.List<IBombStateListener> newValue)
        /// </summary>
        /// public static bool ADD_BOMB_STATE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBombStateListener", "System.Collections.Generic.List<IBombStateListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBombStateListener(IBombStateListener value)
        /// </summary>
        /// public static bool ADD_BOMB_STATE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBombStateListener", "IBombStateListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBuffInvincibleListener(System.Collections.Generic.List<IBuffInvincibleListener> newValue)
        /// </summary>
        /// public static bool ADD_BUFF_INVINCIBLE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBuffInvincibleListener", "System.Collections.Generic.List<IBuffInvincibleListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBuffInvincibleListener(IBuffInvincibleListener value)
        /// </summary>
        /// public static bool ADD_BUFF_INVINCIBLE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBuffInvincibleListener", "IBuffInvincibleListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBuffInvincibleRemovedListener(System.Collections.Generic.List<IBuffInvincibleRemovedListener> newValue)
        /// </summary>
        /// public static bool ADD_BUFF_INVINCIBLE_REMOVED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBuffInvincibleRemovedListener", "System.Collections.Generic.List<IBuffInvincibleRemovedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBuffInvincibleRemovedListener(IBuffInvincibleRemovedListener value)
        /// </summary>
        /// public static bool ADD_BUFF_INVINCIBLE_REMOVED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBuffInvincibleRemovedListener", "IBuffInvincibleRemovedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBunCountListener(System.Collections.Generic.List<IBunCountListener> newValue)
        /// </summary>
        /// public static bool ADD_BUN_COUNT_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBunCountListener", "System.Collections.Generic.List<IBunCountListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddBunCountListener(IBunCountListener value)
        /// </summary>
        /// public static bool ADD_BUN_COUNT_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddBunCountListener", "IBunCountListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddDestroyedListener(System.Collections.Generic.List<IDestroyedListener> newValue)
        /// </summary>
        /// public static bool ADD_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddDestroyedListener", "System.Collections.Generic.List<IDestroyedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddDestroyedListener(IDestroyedListener value)
        /// </summary>
        /// public static bool ADD_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddDestroyedListener", "IDestroyedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddEmoTypListener(System.Collections.Generic.List<IEmoTypListener> newValue)
        /// </summary>
        /// public static bool ADD_EMO_TYP_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddEmoTypListener", "System.Collections.Generic.List<IEmoTypListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddEmoTypListener(IEmoTypListener value)
        /// </summary>
        /// public static bool ADD_EMO_TYP_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddEmoTypListener", "IEmoTypListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddIsPetrifiedListener(System.Collections.Generic.List<IIsPetrifiedListener> newValue)
        /// </summary>
        /// public static bool ADD_IS_PETRIFIED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddIsPetrifiedListener", "System.Collections.Generic.List<IIsPetrifiedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddIsPetrifiedListener(IIsPetrifiedListener value)
        /// </summary>
        /// public static bool ADD_IS_PETRIFIED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddIsPetrifiedListener", "IIsPetrifiedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddItemStateListener(System.Collections.Generic.List<IItemStateListener> newValue)
        /// </summary>
        /// public static bool ADD_ITEM_STATE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddItemStateListener", "System.Collections.Generic.List<IItemStateListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddItemStateListener(IItemStateListener value)
        /// </summary>
        /// public static bool ADD_ITEM_STATE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddItemStateListener", "IItemStateListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddMapElemStateListener(System.Collections.Generic.List<IMapElemStateListener> newValue)
        /// </summary>
        /// public static bool ADD_MAP_ELEM_STATE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddMapElemStateListener", "System.Collections.Generic.List<IMapElemStateListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddMapElemStateListener(IMapElemStateListener value)
        /// </summary>
        /// public static bool ADD_MAP_ELEM_STATE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddMapElemStateListener", "IMapElemStateListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddMoveDirectionListener(System.Collections.Generic.List<IMoveDirectionListener> newValue)
        /// </summary>
        /// public static bool ADD_MOVE_DIRECTION_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddMoveDirectionListener", "System.Collections.Generic.List<IMoveDirectionListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddMoveDirectionListener(IMoveDirectionListener value)
        /// </summary>
        /// public static bool ADD_MOVE_DIRECTION_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddMoveDirectionListener", "IMoveDirectionListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddMoveSpeedListener(System.Collections.Generic.List<IMoveSpeedListener> newValue)
        /// </summary>
        /// public static bool ADD_MOVE_SPEED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddMoveSpeedListener", "System.Collections.Generic.List<IMoveSpeedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddMoveSpeedListener(IMoveSpeedListener value)
        /// </summary>
        /// public static bool ADD_MOVE_SPEED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddMoveSpeedListener", "IMoveSpeedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddNetStateListener(System.Collections.Generic.List<INetStateListener> newValue)
        /// </summary>
        /// public static bool ADD_NET_STATE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddNetStateListener", "System.Collections.Generic.List<INetStateListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddNetStateListener(INetStateListener value)
        /// </summary>
        /// public static bool ADD_NET_STATE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddNetStateListener", "INetStateListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPickTypeListener(System.Collections.Generic.List<IPickTypeListener> newValue)
        /// </summary>
        /// public static bool ADD_PICK_TYPE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPickTypeListener", "System.Collections.Generic.List<IPickTypeListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPickTypeListener(IPickTypeListener value)
        /// </summary>
        /// public static bool ADD_PICK_TYPE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPickTypeListener", "IPickTypeListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPositionListener(System.Collections.Generic.List<IPositionListener> newValue)
        /// </summary>
        /// public static bool ADD_POSITION_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPositionListener", "System.Collections.Generic.List<IPositionListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPositionListener(IPositionListener value)
        /// </summary>
        /// public static bool ADD_POSITION_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPositionListener", "IPositionListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddRoleStateListener(System.Collections.Generic.List<IRoleStateListener> newValue)
        /// </summary>
        /// public static bool ADD_ROLE_STATE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddRoleStateListener", "System.Collections.Generic.List<IRoleStateListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddRoleStateListener(IRoleStateListener value)
        /// </summary>
        /// public static bool ADD_ROLE_STATE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddRoleStateListener", "IRoleStateListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddStatisDataListener(System.Collections.Generic.List<IStatisDataListener> newValue)
        /// </summary>
        /// public static bool ADD_STATIS_DATA_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddStatisDataListener", "System.Collections.Generic.List<IStatisDataListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddStatisDataListener(IStatisDataListener value)
        /// </summary>
        /// public static bool ADD_STATIS_DATA_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddStatisDataListener", "IStatisDataListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddStoneCountListener(System.Collections.Generic.List<IStoneCountListener> newValue)
        /// </summary>
        /// public static bool ADD_STONE_COUNT_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddStoneCountListener", "System.Collections.Generic.List<IStoneCountListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddStoneCountListener(IStoneCountListener value)
        /// </summary>
        /// public static bool ADD_STONE_COUNT_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddStoneCountListener", "IStoneCountListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddTimerBombListener(System.Collections.Generic.List<ITimerBombListener> newValue)
        /// </summary>
        /// public static bool ADD_TIMER_BOMB_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddTimerBombListener", "System.Collections.Generic.List<ITimerBombListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddTimerBombListener(ITimerBombListener value)
        /// </summary>
        /// public static bool ADD_TIMER_BOMB_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddTimerBombListener", "ITimerBombListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddTreasureDataListener(System.Collections.Generic.List<ITreasureDataListener> newValue)
        /// </summary>
        /// public static bool ADD_TREASURE_DATA_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddTreasureDataListener", "System.Collections.Generic.List<ITreasureDataListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddTreasureDataListener(ITreasureDataListener value)
        /// </summary>
        /// public static bool ADD_TREASURE_DATA_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddTreasureDataListener", "ITreasureDataListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddTreasureGemLeaderListener(System.Collections.Generic.List<ITreasureGemLeaderListener> newValue)
        /// </summary>
        /// public static bool ADD_TREASURE_GEM_LEADER_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddTreasureGemLeaderListener", "System.Collections.Generic.List<ITreasureGemLeaderListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddTreasureGemLeaderListener(ITreasureGemLeaderListener value)
        /// </summary>
        /// public static bool ADD_TREASURE_GEM_LEADER_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddTreasureGemLeaderListener", "ITreasureGemLeaderListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   Entitas.IComponent CreateComponent(System.Int32 index, System.Type type)
        /// </summary>
        /// public static bool CREATE_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateComponent", "System.Int32", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T CreateComponent(System.Int32 index)
        /// </summary>
        /// public static bool CREATE_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateComponent", "System.Int32");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."GameEntity"]
    /// </summary>
    public partial class GameEntity
    {



        /// <summary>
        ///   GameProgressComponent get_gameProgress()
        /// </summary>
        /// <returns>class GameProgressComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameProgress")]
        ///  extern nint GET_GAME_PROGRESS ();


        /// <summary>
        ///   GameResultComponent get_gameResult()
        /// </summary>
        /// <returns>class GameResultComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameResult")]
        ///  extern nint GET_GAME_RESULT ();


        /// <summary>
        ///   GameTimeComponent get_gameTime()
        /// </summary>
        /// <returns>class GameTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameTime")]
        ///  extern nint GET_GAME_TIME ();


        /// <summary>
        ///   GameTotalSecComponent get_gameTotalSec()
        /// </summary>
        /// <returns>class GameTotalSecComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameTotalSec")]
        ///  extern nint GET_GAME_TOTAL_SEC ();


        /// <summary>
        ///   GemMaxScoreComponent get_gemMaxScore()
        /// </summary>
        /// <returns>class GemMaxScoreComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gemMaxScore")]
        ///  extern nint GET_GEM_MAX_SCORE ();


        /// <summary>
        ///   GMComponent get_gM()
        /// </summary>
        /// <returns>class GMComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gM")]
        ///  extern nint GET_G_M ();


        /// <summary>
        ///   GridBoundsComponent get_gridBounds()
        /// </summary>
        /// <returns>class GridBoundsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gridBounds")]
        ///  extern nint GET_GRID_BOUNDS ();


        /// <summary>
        ///   GridIDComponent get_gridID()
        /// </summary>
        /// <returns>class GridIDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gridID")]
        ///  extern nint GET_GRID_ID ();


        /// <summary>
        ///   System.Boolean get_hasActivatingTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasActivatingTime")]
        ///  extern System.Boolean GET_HAS_ACTIVATING_TIME ();


        /// <summary>
        ///   System.Boolean get_hasActiveGridID()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasActiveGridID")]
        ///  extern System.Boolean GET_HAS_ACTIVE_GRID_ID ();


        /// <summary>
        ///   System.Boolean get_hasAnyAssetListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnyAssetListener")]
        ///  extern System.Boolean GET_HAS_ANY_ASSET_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasAnyFlamesListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnyFlamesListener")]
        ///  extern System.Boolean GET_HAS_ANY_FLAMES_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasAnyGameProgressListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnyGameProgressListener")]
        ///  extern System.Boolean GET_HAS_ANY_GAME_PROGRESS_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasAnyGMListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnyGMListener")]
        ///  extern System.Boolean GET_HAS_ANY_GM_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasAnyViewFieldListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnyViewFieldListener")]
        ///  extern System.Boolean GET_HAS_ANY_VIEW_FIELD_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasAnyViewListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAnyViewListener")]
        ///  extern System.Boolean GET_HAS_ANY_VIEW_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasAsset()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAsset")]
        ///  extern System.Boolean GET_HAS_ASSET ();


        /// <summary>
        ///   System.Boolean get_hasAudioService()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAudioService")]
        ///  extern System.Boolean GET_HAS_AUDIO_SERVICE ();


        /// <summary>
        ///   System.Boolean get_hasBag()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBag")]
        ///  extern System.Boolean GET_HAS_BAG ();


        /// <summary>
        ///   System.Boolean get_hasBagIndex()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBagIndex")]
        ///  extern System.Boolean GET_HAS_BAG_INDEX ();


        /// <summary>
        ///   System.Boolean get_hasBagItemCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBagItemCount")]
        ///  extern System.Boolean GET_HAS_BAG_ITEM_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasBagListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBagListener")]
        ///  extern System.Boolean GET_HAS_BAG_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasBattleMode()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBattleMode")]
        ///  extern System.Boolean GET_HAS_BATTLE_MODE ();


        /// <summary>
        ///   System.Boolean get_hasBlowUpFlames()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBlowUpFlames")]
        ///  extern System.Boolean GET_HAS_BLOW_UP_FLAMES ();


        /// <summary>
        ///   System.Boolean get_hasBombConfig()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBombConfig")]
        ///  extern System.Boolean GET_HAS_BOMB_CONFIG ();


        /// <summary>
        ///   System.Boolean get_hasBombCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBombCount")]
        ///  extern System.Boolean GET_HAS_BOMB_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasBombCountListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBombCountListener")]
        ///  extern System.Boolean GET_HAS_BOMB_COUNT_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasBombPower()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBombPower")]
        ///  extern System.Boolean GET_HAS_BOMB_POWER ();


        /// <summary>
        ///   System.Boolean get_hasBombPowerListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBombPowerListener")]
        ///  extern System.Boolean GET_HAS_BOMB_POWER_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasBombs()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBombs")]
        ///  extern System.Boolean GET_HAS_BOMBS ();


        /// <summary>
        ///   System.Boolean get_hasBombState()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBombState")]
        ///  extern System.Boolean GET_HAS_BOMB_STATE ();


        /// <summary>
        ///   System.Boolean get_hasBombStateListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBombStateListener")]
        ///  extern System.Boolean GET_HAS_BOMB_STATE_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasBombType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBombType")]
        ///  extern System.Boolean GET_HAS_BOMB_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasBuffInvincible()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBuffInvincible")]
        ///  extern System.Boolean GET_HAS_BUFF_INVINCIBLE ();


        /// <summary>
        ///   System.Boolean get_hasBuffInvincibleListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBuffInvincibleListener")]
        ///  extern System.Boolean GET_HAS_BUFF_INVINCIBLE_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasBuffInvincibleRemovedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBuffInvincibleRemovedListener")]
        ///  extern System.Boolean GET_HAS_BUFF_INVINCIBLE_REMOVED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasBuffSlow()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBuffSlow")]
        ///  extern System.Boolean GET_HAS_BUFF_SLOW ();


        /// <summary>
        ///   System.Boolean get_hasBuffXJP()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBuffXJP")]
        ///  extern System.Boolean GET_HAS_BUFF_XJP ();


        /// <summary>
        ///   System.Boolean get_hasBuildings()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBuildings")]
        ///  extern System.Boolean GET_HAS_BUILDINGS ();


        /// <summary>
        ///   System.Boolean get_hasBunCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBunCount")]
        ///  extern System.Boolean GET_HAS_BUN_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasBunCountListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBunCountListener")]
        ///  extern System.Boolean GET_HAS_BUN_COUNT_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasBunOrStoneCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBunOrStoneCount")]
        ///  extern System.Boolean GET_HAS_BUN_OR_STONE_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasCanPushBomb()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCanPushBomb")]
        ///  extern System.Boolean GET_HAS_CAN_PUSH_BOMB ();


        /// <summary>
        ///   System.Boolean get_hasCatchCatCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCatchCatCount")]
        ///  extern System.Boolean GET_HAS_CATCH_CAT_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasComposeGrids()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasComposeGrids")]
        ///  extern System.Boolean GET_HAS_COMPOSE_GRIDS ();


        /// <summary>
        ///   System.Boolean get_hasComposeWallType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasComposeWallType")]
        ///  extern System.Boolean GET_HAS_COMPOSE_WALL_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasConfigService()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasConfigService")]
        ///  extern System.Boolean GET_HAS_CONFIG_SERVICE ();


        /// <summary>
        ///   System.Boolean get_hasDebugMessageCompoenet()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDebugMessageCompoenet")]
        ///  extern System.Boolean GET_HAS_DEBUG_MESSAGE_COMPOENET ();


        /// <summary>
        ///   System.Boolean get_hasDestroyedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDestroyedListener")]
        ///  extern System.Boolean GET_HAS_DESTROYED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasDoorDirType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDoorDirType")]
        ///  extern System.Boolean GET_HAS_DOOR_DIR_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasEmoTyp()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEmoTyp")]
        ///  extern System.Boolean GET_HAS_EMO_TYP ();


        /// <summary>
        ///   System.Boolean get_hasEmoTypListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEmoTypListener")]
        ///  extern System.Boolean GET_HAS_EMO_TYP_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasEnablePassWall()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEnablePassWall")]
        ///  extern System.Boolean GET_HAS_ENABLE_PASS_WALL ();


        /// <summary>
        ///   System.Boolean get_hasEntityEndLocalTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEntityEndLocalTime")]
        ///  extern System.Boolean GET_HAS_ENTITY_END_LOCAL_TIME ();


        /// <summary>
        ///   System.Boolean get_hasEntityEndTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEntityEndTime")]
        ///  extern System.Boolean GET_HAS_ENTITY_END_TIME ();


        /// <summary>
        ///   System.Boolean get_hasEntityExpectEndTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEntityExpectEndTime")]
        ///  extern System.Boolean GET_HAS_ENTITY_EXPECT_END_TIME ();


        /// <summary>
        ///   System.Boolean get_hasEntityFactoryService()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEntityFactoryService")]
        ///  extern System.Boolean GET_HAS_ENTITY_FACTORY_SERVICE ();


        /// <summary>
        ///   System.Boolean get_hasEntityStartLocalTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEntityStartLocalTime")]
        ///  extern System.Boolean GET_HAS_ENTITY_START_LOCAL_TIME ();


        /// <summary>
        ///   System.Boolean get_hasEntityStartTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEntityStartTime")]
        ///  extern System.Boolean GET_HAS_ENTITY_START_TIME ();


        /// <summary>
        ///   System.Boolean get_hasExpectPosition()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasExpectPosition")]
        ///  extern System.Boolean GET_HAS_EXPECT_POSITION ();


        /// <summary>
        ///   System.Boolean get_hasFirstEnterGrid()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFirstEnterGrid")]
        ///  extern System.Boolean GET_HAS_FIRST_ENTER_GRID ();


        /// <summary>
        ///   System.Boolean get_hasFirstKillToWinTeam()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFirstKillToWinTeam")]
        ///  extern System.Boolean GET_HAS_FIRST_KILL_TO_WIN_TEAM ();


        /// <summary>
        ///   System.Boolean get_hasFlameHitCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFlameHitCount")]
        ///  extern System.Boolean GET_HAS_FLAME_HIT_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasFlames()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFlames")]
        ///  extern System.Boolean GET_HAS_FLAMES ();


        /// <summary>
        ///   System.Boolean get_hasFlyingDirection()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFlyingDirection")]
        ///  extern System.Boolean GET_HAS_FLYING_DIRECTION ();


        /// <summary>
        ///   System.Boolean get_hasFlyStep()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFlyStep")]
        ///  extern System.Boolean GET_HAS_FLY_STEP ();


        /// <summary>
        ///   System.Boolean get_hasFlyTarget()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFlyTarget")]
        ///  extern System.Boolean GET_HAS_FLY_TARGET ();


        /// <summary>
        ///   System.Boolean get_hasGameFrame()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameFrame")]
        ///  extern System.Boolean GET_HAS_GAME_FRAME ();


        /// <summary>
        ///   System.Boolean get_hasGameProgress()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameProgress")]
        ///  extern System.Boolean GET_HAS_GAME_PROGRESS ();


        /// <summary>
        ///   System.Boolean get_hasGameResult()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameResult")]
        ///  extern System.Boolean GET_HAS_GAME_RESULT ();


        /// <summary>
        ///   System.Boolean get_hasGameTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameTime")]
        ///  extern System.Boolean GET_HAS_GAME_TIME ();


        /// <summary>
        ///   System.Boolean get_hasGameTotalSec()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameTotalSec")]
        ///  extern System.Boolean GET_HAS_GAME_TOTAL_SEC ();


        /// <summary>
        ///   System.Boolean get_hasGemMaxScore()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGemMaxScore")]
        ///  extern System.Boolean GET_HAS_GEM_MAX_SCORE ();


        /// <summary>
        ///   System.Boolean get_hasGM()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGM")]
        ///  extern System.Boolean GET_HAS_GM ();


        /// <summary>
        ///   System.Boolean get_hasGridBounds()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGridBounds")]
        ///  extern System.Boolean GET_HAS_GRID_BOUNDS ();


        /// <summary>
        ///   System.Boolean get_hasGridID()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGridID")]
        ///  extern System.Boolean GET_HAS_GRID_ID ();


        /// <summary>
        ///   System.Boolean get_hasHeroArr()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHeroArr")]
        ///  extern System.Boolean GET_HAS_HERO_ARR ();


        /// <summary>
        ///   System.Boolean get_hasHeroConfig()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHeroConfig")]
        ///  extern System.Boolean GET_HAS_HERO_CONFIG ();


        /// <summary>
        ///   System.Boolean get_hasHeroData()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHeroData")]
        ///  extern System.Boolean GET_HAS_HERO_DATA ();


        /// <summary>
        ///   System.Boolean get_hasInputDirection()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInputDirection")]
        ///  extern System.Boolean GET_HAS_INPUT_DIRECTION ();


        /// <summary>
        ///   System.Boolean get_hasInputService()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInputService")]
        ///  extern System.Boolean GET_HAS_INPUT_SERVICE ();


        /// <summary>
        ///   System.Boolean get_hasIsBlowedUp()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasIsBlowedUp")]
        ///  extern System.Boolean GET_HAS_IS_BLOWED_UP ();


        /// <summary>
        ///   System.Boolean get_hasIsPetrified()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasIsPetrified")]
        ///  extern System.Boolean GET_HAS_IS_PETRIFIED ();


        /// <summary>
        ///   System.Boolean get_hasIsPetrifiedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasIsPetrifiedListener")]
        ///  extern System.Boolean GET_HAS_IS_PETRIFIED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasIsTransparent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasIsTransparent")]
        ///  extern System.Boolean GET_HAS_IS_TRANSPARENT ();


        /// <summary>
        ///   System.Boolean get_hasItemBird()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasItemBird")]
        ///  extern System.Boolean GET_HAS_ITEM_BIRD ();


        /// <summary>
        ///   System.Boolean get_hasItems()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasItems")]
        ///  extern System.Boolean GET_HAS_ITEMS ();


        /// <summary>
        ///   System.Boolean get_hasItemState()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasItemState")]
        ///  extern System.Boolean GET_HAS_ITEM_STATE ();


        /// <summary>
        ///   System.Boolean get_hasItemStateListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasItemStateListener")]
        ///  extern System.Boolean GET_HAS_ITEM_STATE_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasItemType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasItemType")]
        ///  extern System.Boolean GET_HAS_ITEM_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasKillerUid()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasKillerUid")]
        ///  extern System.Boolean GET_HAS_KILLER_UID ();


        /// <summary>
        ///   System.Boolean get_hasLastApproachTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLastApproachTime")]
        ///  extern System.Boolean GET_HAS_LAST_APPROACH_TIME ();


        /// <summary>
        ///   System.Boolean get_hasLastGridID()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLastGridID")]
        ///  extern System.Boolean GET_HAS_LAST_GRID_ID ();


        /// <summary>
        ///   System.Boolean get_hasLastKillTeam()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLastKillTeam")]
        ///  extern System.Boolean GET_HAS_LAST_KILL_TEAM ();


        /// <summary>
        ///   System.Boolean get_hasLastPickPoint()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLastPickPoint")]
        ///  extern System.Boolean GET_HAS_LAST_PICK_POINT ();


        /// <summary>
        ///   System.Boolean get_hasLocalBombs()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLocalBombs")]
        ///  extern System.Boolean GET_HAS_LOCAL_BOMBS ();


        /// <summary>
        ///   System.Boolean get_hasLocalPlayers()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLocalPlayers")]
        ///  extern System.Boolean GET_HAS_LOCAL_PLAYERS ();


        /// <summary>
        ///   System.Boolean get_hasLogicDT()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLogicDT")]
        ///  extern System.Boolean GET_HAS_LOGIC_DT ();


        /// <summary>
        ///   System.Boolean get_hasMainPlayerInfos()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMainPlayerInfos")]
        ///  extern System.Boolean GET_HAS_MAIN_PLAYER_INFOS ();


        /// <summary>
        ///   System.Boolean get_hasMapBounds()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapBounds")]
        ///  extern System.Boolean GET_HAS_MAP_BOUNDS ();


        /// <summary>
        ///   System.Boolean get_hasMapConfig()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapConfig")]
        ///  extern System.Boolean GET_HAS_MAP_CONFIG ();


        /// <summary>
        ///   System.Boolean get_hasMapElems()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapElems")]
        ///  extern System.Boolean GET_HAS_MAP_ELEMS ();


        /// <summary>
        ///   System.Boolean get_hasMapElemState()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapElemState")]
        ///  extern System.Boolean GET_HAS_MAP_ELEM_STATE ();


        /// <summary>
        ///   System.Boolean get_hasMapElemStateListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapElemStateListener")]
        ///  extern System.Boolean GET_HAS_MAP_ELEM_STATE_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasMapElemType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapElemType")]
        ///  extern System.Boolean GET_HAS_MAP_ELEM_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasMapGrids()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapGrids")]
        ///  extern System.Boolean GET_HAS_MAP_GRIDS ();


        /// <summary>
        ///   System.Boolean get_hasMapType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapType")]
        ///  extern System.Boolean GET_HAS_MAP_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasMovable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMovable")]
        ///  extern System.Boolean GET_HAS_MOVABLE ();


        /// <summary>
        ///   System.Boolean get_hasMoveDirection()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMoveDirection")]
        ///  extern System.Boolean GET_HAS_MOVE_DIRECTION ();


        /// <summary>
        ///   System.Boolean get_hasMoveDirectionListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMoveDirectionListener")]
        ///  extern System.Boolean GET_HAS_MOVE_DIRECTION_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasMoveSpeed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMoveSpeed")]
        ///  extern System.Boolean GET_HAS_MOVE_SPEED ();


        /// <summary>
        ///   System.Boolean get_hasMoveSpeedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMoveSpeedListener")]
        ///  extern System.Boolean GET_HAS_MOVE_SPEED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasNetHeroIndex()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasNetHeroIndex")]
        ///  extern System.Boolean GET_HAS_NET_HERO_INDEX ();


        /// <summary>
        ///   System.Boolean get_hasNetState()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasNetState")]
        ///  extern System.Boolean GET_HAS_NET_STATE ();


        /// <summary>
        ///   System.Boolean get_hasNetStateListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasNetStateListener")]
        ///  extern System.Boolean GET_HAS_NET_STATE_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasOwnerGridID()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOwnerGridID")]
        ///  extern System.Boolean GET_HAS_OWNER_GRID_ID ();


        /// <summary>
        ///   System.Boolean get_hasOwnerUID()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOwnerUID")]
        ///  extern System.Boolean GET_HAS_OWNER_UID ();


        /// <summary>
        ///   System.Boolean get_hasParentGrids()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasParentGrids")]
        ///  extern System.Boolean GET_HAS_PARENT_GRIDS ();


        /// <summary>
        ///   System.Boolean get_hasPhasingPeriod()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPhasingPeriod")]
        ///  extern System.Boolean GET_HAS_PHASING_PERIOD ();


        /// <summary>
        ///   System.Boolean get_hasPickType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPickType")]
        ///  extern System.Boolean GET_HAS_PICK_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasPickTypeListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPickTypeListener")]
        ///  extern System.Boolean GET_HAS_PICK_TYPE_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasPosition()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPosition")]
        ///  extern System.Boolean GET_HAS_POSITION ();


        /// <summary>
        ///   System.Boolean get_hasPositionListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPositionListener")]
        ///  extern System.Boolean GET_HAS_POSITION_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasPowerHitGrids()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPowerHitGrids")]
        ///  extern System.Boolean GET_HAS_POWER_HIT_GRIDS ();


        /// <summary>
        ///   System.Boolean get_hasPushTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPushTime")]
        ///  extern System.Boolean GET_HAS_PUSH_TIME ();


        /// <summary>
        ///   System.Boolean get_hasRandom()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRandom")]
        ///  extern System.Boolean GET_HAS_RANDOM ();


        /// <summary>
        ///   System.Boolean get_hasRelifeCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRelifeCount")]
        ///  extern System.Boolean GET_HAS_RELIFE_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasRelifeInfo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRelifeInfo")]
        ///  extern System.Boolean GET_HAS_RELIFE_INFO ();


        /// <summary>
        ///   System.Boolean get_hasRelifeWaitTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRelifeWaitTime")]
        ///  extern System.Boolean GET_HAS_RELIFE_WAIT_TIME ();


        /// <summary>
        ///   System.Boolean get_hasRoleState()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRoleState")]
        ///  extern System.Boolean GET_HAS_ROLE_STATE ();


        /// <summary>
        ///   System.Boolean get_hasRoleStateListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRoleStateListener")]
        ///  extern System.Boolean GET_HAS_ROLE_STATE_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasRootParent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRootParent")]
        ///  extern System.Boolean GET_HAS_ROOT_PARENT ();


        /// <summary>
        ///   System.Boolean get_hasSonGrids()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSonGrids")]
        ///  extern System.Boolean GET_HAS_SON_GRIDS ();


        /// <summary>
        ///   System.Boolean get_hasStatisData()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasStatisData")]
        ///  extern System.Boolean GET_HAS_STATIS_DATA ();


        /// <summary>
        ///   System.Boolean get_hasStatisDataListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasStatisDataListener")]
        ///  extern System.Boolean GET_HAS_STATIS_DATA_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasStoneCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasStoneCount")]
        ///  extern System.Boolean GET_HAS_STONE_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasStoneCountListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasStoneCountListener")]
        ///  extern System.Boolean GET_HAS_STONE_COUNT_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasTeam()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTeam")]
        ///  extern System.Boolean GET_HAS_TEAM ();


        /// <summary>
        ///   System.Boolean get_hasTimerBomb()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTimerBomb")]
        ///  extern System.Boolean GET_HAS_TIMER_BOMB ();


        /// <summary>
        ///   System.Boolean get_hasTimerBombListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTimerBombListener")]
        ///  extern System.Boolean GET_HAS_TIMER_BOMB_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasTimerService()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTimerService")]
        ///  extern System.Boolean GET_HAS_TIMER_SERVICE ();


        /// <summary>
        ///   System.Boolean get_hasTransparentBombEndTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTransparentBombEndTime")]
        ///  extern System.Boolean GET_HAS_TRANSPARENT_BOMB_END_TIME ();


        /// <summary>
        ///   System.Boolean get_hasTrappedCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTrappedCount")]
        ///  extern System.Boolean GET_HAS_TRAPPED_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasTrappedEndTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTrappedEndTime")]
        ///  extern System.Boolean GET_HAS_TRAPPED_END_TIME ();


        /// <summary>
        ///   System.Boolean get_hasTreasureData()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTreasureData")]
        ///  extern System.Boolean GET_HAS_TREASURE_DATA ();


        /// <summary>
        ///   System.Boolean get_hasTreasureDataListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTreasureDataListener")]
        ///  extern System.Boolean GET_HAS_TREASURE_DATA_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasTreasureGemLeader()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTreasureGemLeader")]
        ///  extern System.Boolean GET_HAS_TREASURE_GEM_LEADER ();


        /// <summary>
        ///   System.Boolean get_hasTreasureGemLeaderListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTreasureGemLeaderListener")]
        ///  extern System.Boolean GET_HAS_TREASURE_GEM_LEADER_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasTryBomb()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTryBomb")]
        ///  extern System.Boolean GET_HAS_TRY_BOMB ();


        /// <summary>
        ///   System.Boolean get_hasTwoTeamMatch()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTwoTeamMatch")]
        ///  extern System.Boolean GET_HAS_TWO_TEAM_MATCH ();


        /// <summary>
        ///   System.Boolean get_hasUID()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUID")]
        ///  extern System.Boolean GET_HAS_UID ();


        /// <summary>
        ///   System.Boolean get_hasUnexplodeBomb()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnexplodeBomb")]
        ///  extern System.Boolean GET_HAS_UNEXPLODE_BOMB ();


        /// <summary>
        ///   System.Boolean get_hasUnitType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnitType")]
        ///  extern System.Boolean GET_HAS_UNIT_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasUseBagNum()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUseBagNum")]
        ///  extern System.Boolean GET_HAS_USE_BAG_NUM ();


        /// <summary>
        ///   System.Boolean get_hasUsedItemID()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUsedItemID")]
        ///  extern System.Boolean GET_HAS_USED_ITEM_ID ();


        /// <summary>
        ///   System.Boolean get_hasView()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasView")]
        ///  extern System.Boolean GET_HAS_VIEW ();


        /// <summary>
        ///   System.Boolean get_hasViewField()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasViewField")]
        ///  extern System.Boolean GET_HAS_VIEW_FIELD ();


        /// <summary>
        ///   System.Boolean get_hasWinnerTeam()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWinnerTeam")]
        ///  extern System.Boolean GET_HAS_WINNER_TEAM ();


        /// <summary>
        ///   HeroArrComponent get_heroArr()
        /// </summary>
        /// <returns>class HeroArrComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_heroArr")]
        ///  extern nint GET_HERO_ARR ();


        /// <summary>
        ///   HeroConfigComponent get_heroConfig()
        /// </summary>
        /// <returns>class HeroConfigComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_heroConfig")]
        ///  extern nint GET_HERO_CONFIG ();


        /// <summary>
        ///   HeroDataComponent get_heroData()
        /// </summary>
        /// <returns>class HeroDataComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_heroData")]
        ///  extern nint GET_HERO_DATA ();


        /// <summary>
        ///   InputDirectionComponent get_inputDirection()
        /// </summary>
        /// <returns>class InputDirectionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputDirection")]
        ///  extern nint GET_INPUT_DIRECTION ();


        /// <summary>
        ///   InputServiceComponent get_inputService()
        /// </summary>
        /// <returns>class InputServiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputService")]
        ///  extern nint GET_INPUT_SERVICE ();


        /// <summary>
        ///   IsBlowedUpComponent get_isBlowedUp()
        /// </summary>
        /// <returns>class IsBlowedUpComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isBlowedUp")]
        ///  extern nint GET_IS_BLOWED_UP ();


        /// <summary>
        ///   System.Boolean get_isDestroyed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDestroyed")]
        ///  extern System.Boolean GET_IS_DESTROYED ();


        /// <summary>
        ///   System.Boolean get_isEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEnabled")]
        ///  extern System.Boolean GET_IS_ENABLED ();


        /// <summary>
        ///   System.Boolean get_isMainPlayer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isMainPlayer")]
        ///  extern System.Boolean GET_IS_MAIN_PLAYER ();


        /// <summary>
        ///   System.Boolean get_isMaxBomb()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isMaxBomb")]
        ///  extern System.Boolean GET_IS_MAX_BOMB ();


        /// <summary>
        ///   System.Boolean get_isMaxBombPower()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isMaxBombPower")]
        ///  extern System.Boolean GET_IS_MAX_BOMB_POWER ();


        /// <summary>
        ///   System.Boolean get_isMaxShooes()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isMaxShooes")]
        ///  extern System.Boolean GET_IS_MAX_SHOOES ();


        /// <summary>
        ///   IsPetrifiedComponent get_isPetrified()
        /// </summary>
        /// <returns>class IsPetrifiedComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPetrified")]
        ///  extern nint GET_IS_PETRIFIED ();


        /// <summary>
        ///   IsPetrifiedListenerComponent get_isPetrifiedListener()
        /// </summary>
        /// <returns>class IsPetrifiedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPetrifiedListener")]
        ///  extern nint GET_IS_PETRIFIED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_isPhasing()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPhasing")]
        ///  extern System.Boolean GET_IS_PHASING ();


        /// <summary>
        ///   IsTransparentComponent get_isTransparent()
        /// </summary>
        /// <returns>class IsTransparentComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isTransparent")]
        ///  extern nint GET_IS_TRANSPARENT ();


        /// <summary>
        ///   ItemBirdComponent get_itemBird()
        /// </summary>
        /// <returns>class ItemBirdComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_itemBird")]
        ///  extern nint GET_ITEM_BIRD ();


        /// <summary>
        ///   ItemsComponent get_items()
        /// </summary>
        /// <returns>class ItemsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_items")]
        ///  extern nint GET_ITEMS ();


        /// <summary>
        ///   ItemStateComponent get_itemState()
        /// </summary>
        /// <returns>class ItemStateComponent</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_itemState")]
        extern ItemStateComponent.Ptr_ItemStateComponent GET_ITEM_STATE();


        /// <summary>
        ///   ItemStateListenerComponent get_itemStateListener()
        /// </summary>
        /// <returns>class ItemStateListenerComponent</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_itemStateListener")]
        extern ItemStateListenerComponent.Ptr_ItemStateListenerComponent GET_ITEM_STATE_LISTENER();


        /// <summary>
        ///   ItemTypeComponent get_itemType()
        /// </summary>
        /// <returns>class ItemTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_itemType")]
        ///  extern nint GET_ITEM_TYPE ();


        /// <summary>
        ///   KillerUidComponent get_killerUid()
        /// </summary>
        /// <returns>class KillerUidComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_killerUid")]
        ///  extern nint GET_KILLER_UID ();


        /// <summary>
        ///   LastApproachTimeComponent get_lastApproachTime()
        /// </summary>
        /// <returns>class LastApproachTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastApproachTime")]
        ///  extern nint GET_LAST_APPROACH_TIME ();


        /// <summary>
        ///   LastGridIDComponent get_lastGridID()
        /// </summary>
        /// <returns>class LastGridIDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastGridID")]
        ///  extern nint GET_LAST_GRID_ID ();


        /// <summary>
        ///   LastKillTeamComponent get_lastKillTeam()
        /// </summary>
        /// <returns>class LastKillTeamComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastKillTeam")]
        ///  extern nint GET_LAST_KILL_TEAM ();


        /// <summary>
        ///   LastPickPointComponent get_lastPickPoint()
        /// </summary>
        /// <returns>class LastPickPointComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastPickPoint")]
        ///  extern nint GET_LAST_PICK_POINT ();


        /// <summary>
        ///   LocalBombsComponent get_localBombs()
        /// </summary>
        /// <returns>class LocalBombsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localBombs")]
        ///  extern nint GET_LOCAL_BOMBS ();


        /// <summary>
        ///   LocalPlayersComponent get_localPlayers()
        /// </summary>
        /// <returns>class LocalPlayersComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localPlayers")]
        ///  extern nint GET_LOCAL_PLAYERS ();


        /// <summary>
        ///   LogicDTComponent get_logicDT()
        /// </summary>
        /// <returns>class LogicDTComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_logicDT")]
        ///  extern nint GET_LOGIC_DT ();


        /// <summary>
        ///   MainPlayerInfosComponent get_mainPlayerInfos()
        /// </summary>
        /// <returns>class MainPlayerInfosComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mainPlayerInfos")]
        ///  extern nint GET_MAIN_PLAYER_INFOS ();


        /// <summary>
        ///   MapBoundsComponent get_mapBounds()
        /// </summary>
        /// <returns>class MapBoundsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapBounds")]
        ///  extern nint GET_MAP_BOUNDS ();


        /// <summary>
        ///   MapConfigComponent get_mapConfig()
        /// </summary>
        /// <returns>class MapConfigComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapConfig")]
        ///  extern nint GET_MAP_CONFIG ();


        /// <summary>
        ///   MapElemsComponent get_mapElems()
        /// </summary>
        /// <returns>class MapElemsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapElems")]
        ///  extern nint GET_MAP_ELEMS ();


        /// <summary>
        ///   MapElemStateComponent get_mapElemState()
        /// </summary>
        /// <returns>class MapElemStateComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapElemState")]
        ///  extern nint GET_MAP_ELEM_STATE ();


        /// <summary>
        ///   MapElemStateListenerComponent get_mapElemStateListener()
        /// </summary>
        /// <returns>class MapElemStateListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapElemStateListener")]
        ///  extern nint GET_MAP_ELEM_STATE_LISTENER ();


        /// <summary>
        ///   MapElemTypeComponent get_mapElemType()
        /// </summary>
        /// <returns>class MapElemTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapElemType")]
        ///  extern nint GET_MAP_ELEM_TYPE ();


        /// <summary>
        ///   MapGridsComponent get_mapGrids()
        /// </summary>
        /// <returns>class MapGridsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapGrids")]
        ///  extern nint GET_MAP_GRIDS ();


        /// <summary>
        ///   MapTypeComponent get_mapType()
        /// </summary>
        /// <returns>class MapTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapType")]
        ///  extern nint GET_MAP_TYPE ();


        /// <summary>
        ///   MovableComponent get_movable()
        /// </summary>
        /// <returns>class MovableComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_movable")]
        ///  extern nint GET_MOVABLE ();


        /// <summary>
        ///   MoveDirectionComponent get_moveDirection()
        /// </summary>
        /// <returns>class MoveDirectionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_moveDirection")]
        ///  extern nint GET_MOVE_DIRECTION ();


        /// <summary>
        ///   MoveDirectionListenerComponent get_moveDirectionListener()
        /// </summary>
        /// <returns>class MoveDirectionListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_moveDirectionListener")]
        ///  extern nint GET_MOVE_DIRECTION_LISTENER ();


        /// <summary>
        ///   MoveSpeedComponent get_moveSpeed()
        /// </summary>
        /// <returns>class MoveSpeedComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_moveSpeed")]
        ///  extern nint GET_MOVE_SPEED ();


        /// <summary>
        ///   MoveSpeedListenerComponent get_moveSpeedListener()
        /// </summary>
        /// <returns>class MoveSpeedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_moveSpeedListener")]
        ///  extern nint GET_MOVE_SPEED_LISTENER ();


        /// <summary>
        ///   NetHeroIndexComponent get_netHeroIndex()
        /// </summary>
        /// <returns>class NetHeroIndexComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_netHeroIndex")]
        ///  extern nint GET_NET_HERO_INDEX ();


        /// <summary>
        ///   NetStateComponent get_netState()
        /// </summary>
        /// <returns>class NetStateComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_netState")]
        ///  extern nint GET_NET_STATE ();


        /// <summary>
        ///   NetStateListenerComponent get_netStateListener()
        /// </summary>
        /// <returns>class NetStateListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_netStateListener")]
        ///  extern nint GET_NET_STATE_LISTENER ();


        /// <summary>
        ///   OwnerGridIDComponent get_ownerGridID()
        /// </summary>
        /// <returns>class OwnerGridIDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ownerGridID")]
        ///  extern nint GET_OWNER_GRID_ID ();


        /// <summary>
        ///   OwnerUIDComponent get_ownerUID()
        /// </summary>
        /// <returns>class OwnerUIDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ownerUID")]
        ///  extern nint GET_OWNER_UID ();


        /// <summary>
        ///   ParentGridsComponent get_parentGrids()
        /// </summary>
        /// <returns>class ParentGridsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_parentGrids")]
        ///  extern nint GET_PARENT_GRIDS ();


        /// <summary>
        ///   PhasingPeriodComponent get_phasingPeriod()
        /// </summary>
        /// <returns>class PhasingPeriodComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_phasingPeriod")]
        ///  extern nint GET_PHASING_PERIOD ();


        /// <summary>
        ///   PickTypeComponent get_pickType()
        /// </summary>
        /// <returns>class PickTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_pickType")]
        ///  extern nint GET_PICK_TYPE ();


        /// <summary>
        ///   PickTypeListenerComponent get_pickTypeListener()
        /// </summary>
        /// <returns>class PickTypeListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_pickTypeListener")]
        ///  extern nint GET_PICK_TYPE_LISTENER ();


        /// <summary>
        ///   PositionComponent get_position()
        /// </summary>
        /// <returns>class PositionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_position")]
        ///  extern nint GET_POSITION ();


        /// <summary>
        ///   PositionListenerComponent get_positionListener()
        /// </summary>
        /// <returns>class PositionListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_positionListener")]
        ///  extern nint GET_POSITION_LISTENER ();


        /// <summary>
        ///   PowerHitGridsComponent get_powerHitGrids()
        /// </summary>
        /// <returns>class PowerHitGridsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_powerHitGrids")]
        ///  extern nint GET_POWER_HIT_GRIDS ();


        /// <summary>
        ///   PushTimeComponent get_pushTime()
        /// </summary>
        /// <returns>class PushTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_pushTime")]
        ///  extern nint GET_PUSH_TIME ();


        /// <summary>
        ///   RandomComponent get_random()
        /// </summary>
        /// <returns>class RandomComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_random")]
        ///  extern nint GET_RANDOM ();


        /// <summary>
        ///   RelifeCountComponent get_relifeCount()
        /// </summary>
        /// <returns>class RelifeCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_relifeCount")]
        ///  extern nint GET_RELIFE_COUNT ();


        /// <summary>
        ///   RelifeInfoComponent get_relifeInfo()
        /// </summary>
        /// <returns>class RelifeInfoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_relifeInfo")]
        ///  extern nint GET_RELIFE_INFO ();


        /// <summary>
        ///   RelifeWaitTimeComponent get_relifeWaitTime()
        /// </summary>
        /// <returns>class RelifeWaitTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_relifeWaitTime")]
        ///  extern nint GET_RELIFE_WAIT_TIME ();


        /// <summary>
        ///   System.Int32 get_retainCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_retainCount")]
        ///  extern System.Int32 GET_RETAIN_COUNT ();


        /// <summary>
        ///   RoleStateComponent get_roleState()
        /// </summary>
        /// <returns>class RoleStateComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_roleState")]
        ///  extern nint GET_ROLE_STATE ();


        /// <summary>
        ///   RoleStateListenerComponent get_roleStateListener()
        /// </summary>
        /// <returns>class RoleStateListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_roleStateListener")]
        ///  extern nint GET_ROLE_STATE_LISTENER ();


        /// <summary>
        ///   RootParentComponent get_rootParent()
        /// </summary>
        /// <returns>class RootParentComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rootParent")]
        ///  extern nint GET_ROOT_PARENT ();


        /// <summary>
        ///   SonGridsComponent get_sonGrids()
        /// </summary>
        /// <returns>class SonGridsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sonGrids")]
        ///  extern nint GET_SON_GRIDS ();


        /// <summary>
        ///   StatisDataComponent get_statisData()
        /// </summary>
        /// <returns>class StatisDataComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_statisData")]
        ///  extern nint GET_STATIS_DATA ();


        /// <summary>
        ///   StatisDataListenerComponent get_statisDataListener()
        /// </summary>
        /// <returns>class StatisDataListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_statisDataListener")]
        ///  extern nint GET_STATIS_DATA_LISTENER ();


        /// <summary>
        ///   StoneCountComponent get_stoneCount()
        /// </summary>
        /// <returns>class StoneCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_stoneCount")]
        ///  extern nint GET_STONE_COUNT ();


        /// <summary>
        ///   StoneCountListenerComponent get_stoneCountListener()
        /// </summary>
        /// <returns>class StoneCountListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_stoneCountListener")]
        ///  extern nint GET_STONE_COUNT_LISTENER ();


        /// <summary>
        ///   TeamComponent get_team()
        /// </summary>
        /// <returns>class TeamComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_team")]
        ///  extern nint GET_TEAM ();


        /// <summary>
        ///   TimerBombComponent get_timerBomb()
        /// </summary>
        /// <returns>class TimerBombComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_timerBomb")]
        ///  extern nint GET_TIMER_BOMB ();


        /// <summary>
        ///   TimerBombListenerComponent get_timerBombListener()
        /// </summary>
        /// <returns>class TimerBombListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_timerBombListener")]
        ///  extern nint GET_TIMER_BOMB_LISTENER ();


        /// <summary>
        ///   TimerServiceComponent get_timerService()
        /// </summary>
        /// <returns>class TimerServiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_timerService")]
        ///  extern nint GET_TIMER_SERVICE ();


        /// <summary>
        ///   System.Int32 get_totalComponents()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_totalComponents")]
        ///  extern System.Int32 GET_TOTAL_COMPONENTS ();


        /// <summary>
        ///   TransparentBombEndTimeComponent get_transparentBombEndTime()
        /// </summary>
        /// <returns>class TransparentBombEndTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_transparentBombEndTime")]
        ///  extern nint GET_TRANSPARENT_BOMB_END_TIME ();


        /// <summary>
        ///   TrappedCountComponent get_trappedCount()
        /// </summary>
        /// <returns>class TrappedCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_trappedCount")]
        ///  extern nint GET_TRAPPED_COUNT ();


        /// <summary>
        ///   TrappedEndTimeComponent get_trappedEndTime()
        /// </summary>
        /// <returns>class TrappedEndTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_trappedEndTime")]
        ///  extern nint GET_TRAPPED_END_TIME ();


        /// <summary>
        ///   TreasureDataComponent get_treasureData()
        /// </summary>
        /// <returns>class TreasureDataComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_treasureData")]
        ///  extern nint GET_TREASURE_DATA ();


        /// <summary>
        ///   TreasureDataListenerComponent get_treasureDataListener()
        /// </summary>
        /// <returns>class TreasureDataListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_treasureDataListener")]
        ///  extern nint GET_TREASURE_DATA_LISTENER ();


        /// <summary>
        ///   TreasureGemLeaderComponent get_treasureGemLeader()
        /// </summary>
        /// <returns>class TreasureGemLeaderComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_treasureGemLeader")]
        ///  extern nint GET_TREASURE_GEM_LEADER ();


        /// <summary>
        ///   TreasureGemLeaderListenerComponent get_treasureGemLeaderListener()
        /// </summary>
        /// <returns>class TreasureGemLeaderListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_treasureGemLeaderListener")]
        ///  extern nint GET_TREASURE_GEM_LEADER_LISTENER ();


        /// <summary>
        ///   TryBombComponent get_tryBomb()
        /// </summary>
        /// <returns>class TryBombComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tryBomb")]
        ///  extern nint GET_TRY_BOMB ();


        /// <summary>
        ///   TwoTeamMatchComponent get_twoTeamMatch()
        /// </summary>
        /// <returns>class TwoTeamMatchComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_twoTeamMatch")]
        ///  extern nint GET_TWO_TEAM_MATCH ();


        /// <summary>
        ///   UIDComponent get_uID()
        /// </summary>
        /// <returns>class UIDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uID")]
        ///  extern nint GET_U_ID ();


        /// <summary>
        ///   UnexplodeBombComponent get_unexplodeBomb()
        /// </summary>
        /// <returns>class UnexplodeBombComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unexplodeBomb")]
        ///  extern nint GET_UNEXPLODE_BOMB ();


        /// <summary>
        ///   UnitTypeComponent get_unitType()
        /// </summary>
        /// <returns>class UnitTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unitType")]
        ///  extern nint GET_UNIT_TYPE ();


        /// <summary>
        ///   UseBagNumComponent get_useBagNum()
        /// </summary>
        /// <returns>class UseBagNumComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_useBagNum")]
        ///  extern nint GET_USE_BAG_NUM ();


        /// <summary>
        ///   UsedItemIDComponent get_usedItemID()
        /// </summary>
        /// <returns>class UsedItemIDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_usedItemID")]
        ///  extern nint GET_USED_ITEM_ID ();


        /// <summary>
        ///   ViewComponent get_view()
        /// </summary>
        /// <returns>class ViewComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_view")]
        ///  extern nint GET_VIEW ();


        /// <summary>
        ///   ViewFieldComponent get_viewField()
        /// </summary>
        /// <returns>class ViewFieldComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_viewField")]
        ///  extern nint GET_VIEW_FIELD ();


        /// <summary>
        ///   WinnerTeamComponent get_winnerTeam()
        /// </summary>
        /// <returns>class WinnerTeamComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_winnerTeam")]
        ///  extern nint GET_WINNER_TEAM ();


        /// <summary>
        ///   Entitas.IComponent GetComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>interface Entitas.IComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent")]
        ///  extern nint GET_COMPONENT (System.Int32 index);


        /// <summary>
        ///   System.Int32[] GetComponentIndices()
        /// </summary>
        /// <returns>class System.Int32[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentIndices")]
        ///  extern nint GET_COMPONENT_INDICES ();


        /// <summary>
        ///   System.Collections.Generic.Stack<Entitas.IComponent> GetComponentPool(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.Stack<Entitas.IComponent></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentPool")]
        ///  extern nint GET_COMPONENT_POOL (System.Int32 index);


        /// <summary>
        ///   Entitas.IComponent[] GetComponents()
        /// </summary>
        /// <returns>class Entitas.IComponent[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents")]
        ///  extern nint GET_COMPONENTS ();


        /// <summary>
        ///   System.Boolean HasAnyComponent(System.Int32[] indices)
        /// </summary>
        /// <param name="indices">class System.Int32[]</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasAnyComponent")]
        ///  extern System.Boolean HAS_ANY_COMPONENT (nint indices);


        /// <summary>
        ///   System.Boolean HasComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasComponent")]
        ///  extern System.Boolean HAS_COMPONENT (System.Int32 index);


        /// <summary>
        ///   System.Boolean HasComponents(System.Int32[] indices)
        /// </summary>
        /// <param name="indices">class System.Int32[]</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasComponents")]
        ///  extern System.Boolean HAS_COMPONENTS (nint indices);




        /// public static partial class Search_GameEntity
        /// {
        /// 
        ///     
        /// 
        /// }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."GameEntity"]
    /// </summary>
    public partial class GameEntity
    {



        /// <summary>
        ///   System.Void Initialize(System.Int32 creationIndex, System.Int32 totalComponents, System.Collections.Generic.Stack<Entitas.IComponent>[] componentPools, Entitas.ContextInfo contextInfo, Entitas.IAERC aerc)
        /// </summary>
        /// <param name="creationIndex">struct System.Int32</param>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="componentPools">class System.Collections.Generic.Stack<Entitas.IComponent>[]</param>
        /// <param name="contextInfo">class Entitas.ContextInfo</param>
        /// <param name="aerc">interface Entitas.IAERC</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Initialize")]
        ///  extern void INITIALIZE (System.Int32 creationIndex, System.Int32 totalComponents, nint componentPools, nint contextInfo, nint aerc);


        /// <summary>
        ///   System.Void InternalDestroy()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDestroy")]
        ///  extern void INTERNAL_DESTROY ();


        /// <summary>
        ///   System.Void Reactivate(System.Int32 creationIndex)
        /// </summary>
        /// <param name="creationIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Reactivate")]
        ///  extern void REACTIVATE (System.Int32 creationIndex);


        /// <summary>
        ///   System.Void Release(System.Object owner)
        /// </summary>
        /// <param name="owner">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Release")]
        ///  extern void RELEASE (nint owner);


        /// <summary>
        ///   System.Void remove_OnComponentAdded(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentAdded")]
        ///  extern void REMOVE_ON_COMPONENT_ADDED (nint value);


        /// <summary>
        ///   System.Void remove_OnComponentRemoved(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentRemoved")]
        ///  extern void REMOVE_ON_COMPONENT_REMOVED (nint value);


        /// <summary>
        ///   System.Void remove_OnComponentReplaced(Entitas.EntityComponentReplaced value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentReplaced</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentReplaced")]
        ///  extern void REMOVE_ON_COMPONENT_REPLACED (nint value);


        /// <summary>
        ///   System.Void remove_OnDestroyEntity(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnDestroyEntity")]
        ///  extern void REMOVE_ON_DESTROY_ENTITY (nint value);


        /// <summary>
        ///   System.Void remove_OnEntityReleased(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityReleased")]
        ///  extern void REMOVE_ON_ENTITY_RELEASED (nint value);


        /// <summary>
        ///   System.Void RemoveActivatingTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveActivatingTime")]
        ///  extern void REMOVE_ACTIVATING_TIME ();


        /// <summary>
        ///   System.Void RemoveActiveGridID()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveActiveGridID")]
        ///  extern void REMOVE_ACTIVE_GRID_ID ();


        /// <summary>
        ///   System.Void RemoveAllComponents()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllComponents")]
        ///  extern void REMOVE_ALL_COMPONENTS ();


        /// <summary>
        ///   System.Void RemoveAllOnEntityReleasedHandlers()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllOnEntityReleasedHandlers")]
        ///  extern void REMOVE_ALL_ON_ENTITY_RELEASED_HANDLERS ();


        /// <summary>
        ///   System.Void RemoveAsset()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAsset")]
        ///  extern void REMOVE_ASSET ();


        /// <summary>
        ///   System.Void RemoveAudioService()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAudioService")]
        ///  extern void REMOVE_AUDIO_SERVICE ();


        /// <summary>
        ///   System.Void RemoveBag()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBag")]
        ///  extern void REMOVE_BAG ();


        /// <summary>
        ///   System.Void RemoveBagIndex()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBagIndex")]
        ///  extern void REMOVE_BAG_INDEX ();


        /// <summary>
        ///   System.Void RemoveBagItemCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBagItemCount")]
        ///  extern void REMOVE_BAG_ITEM_COUNT ();


        /// <summary>
        ///   System.Void RemoveBattleMode()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBattleMode")]
        ///  extern void REMOVE_BATTLE_MODE ();


        /// <summary>
        ///   System.Void RemoveBlowUpFlames()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBlowUpFlames")]
        ///  extern void REMOVE_BLOW_UP_FLAMES ();


        /// <summary>
        ///   System.Void RemoveBombConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombConfig")]
        ///  extern void REMOVE_BOMB_CONFIG ();


        /// <summary>
        ///   System.Void RemoveBombCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombCount")]
        ///  extern void REMOVE_BOMB_COUNT ();


        /// <summary>
        ///   System.Void RemoveBombPower()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombPower")]
        ///  extern void REMOVE_BOMB_POWER ();


        /// <summary>
        ///   System.Void RemoveBombs()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombs")]
        ///  extern void REMOVE_BOMBS ();


        /// <summary>
        ///   System.Void RemoveBombState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombState")]
        ///  extern void REMOVE_BOMB_STATE ();


        /// <summary>
        ///   System.Void RemoveBombType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombType")]
        ///  extern void REMOVE_BOMB_TYPE ();


        /// <summary>
        ///   System.Void RemoveBuffInvincible()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuffInvincible")]
        ///  extern void REMOVE_BUFF_INVINCIBLE ();


        /// <summary>
        ///   System.Void RemoveBuffSlow()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuffSlow")]
        ///  extern void REMOVE_BUFF_SLOW ();


        /// <summary>
        ///   System.Void RemoveBuffXJP()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuffXJP")]
        ///  extern void REMOVE_BUFF_XJP ();


        /// <summary>
        ///   System.Void RemoveBuildings()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuildings")]
        ///  extern void REMOVE_BUILDINGS ();


        /// <summary>
        ///   System.Void RemoveBunCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBunCount")]
        ///  extern void REMOVE_BUN_COUNT ();


        /// <summary>
        ///   System.Void RemoveBunOrStoneCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBunOrStoneCount")]
        ///  extern void REMOVE_BUN_OR_STONE_COUNT ();


        /// <summary>
        ///   System.Void RemoveCanPushBomb()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCanPushBomb")]
        ///  extern void REMOVE_CAN_PUSH_BOMB ();


        /// <summary>
        ///   System.Void RemoveCatchCatCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCatchCatCount")]
        ///  extern void REMOVE_CATCH_CAT_COUNT ();


        /// <summary>
        ///   System.Void RemoveComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveComponent")]
        ///  extern void REMOVE_COMPONENT (System.Int32 index);


        /// <summary>
        ///   System.Void RemoveComposeGrids()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveComposeGrids")]
        ///  extern void REMOVE_COMPOSE_GRIDS ();


        /// <summary>
        ///   System.Void RemoveComposeWallType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveComposeWallType")]
        ///  extern void REMOVE_COMPOSE_WALL_TYPE ();


        /// <summary>
        ///   System.Void RemoveConfigService()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveConfigService")]
        ///  extern void REMOVE_CONFIG_SERVICE ();


        /// <summary>
        ///   System.Void RemoveDebugMessageCompoenet()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDebugMessageCompoenet")]
        ///  extern void REMOVE_DEBUG_MESSAGE_COMPOENET ();


        /// <summary>
        ///   System.Void RemoveDoorDirType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDoorDirType")]
        ///  extern void REMOVE_DOOR_DIR_TYPE ();


        /// <summary>
        ///   System.Void RemoveEmoTyp()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEmoTyp")]
        ///  extern void REMOVE_EMO_TYP ();


        /// <summary>
        ///   System.Void RemoveEnablePassWall()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEnablePassWall")]
        ///  extern void REMOVE_ENABLE_PASS_WALL ();


        /// <summary>
        ///   System.Void RemoveEntityEndLocalTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEntityEndLocalTime")]
        ///  extern void REMOVE_ENTITY_END_LOCAL_TIME ();


        /// <summary>
        ///   System.Void RemoveEntityEndTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEntityEndTime")]
        ///  extern void REMOVE_ENTITY_END_TIME ();


        /// <summary>
        ///   System.Void RemoveEntityExpectEndTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEntityExpectEndTime")]
        ///  extern void REMOVE_ENTITY_EXPECT_END_TIME ();


        /// <summary>
        ///   System.Void RemoveEntityFactoryService()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEntityFactoryService")]
        ///  extern void REMOVE_ENTITY_FACTORY_SERVICE ();


        /// <summary>
        ///   System.Void RemoveEntityStartLocalTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEntityStartLocalTime")]
        ///  extern void REMOVE_ENTITY_START_LOCAL_TIME ();


        /// <summary>
        ///   System.Void RemoveEntityStartTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEntityStartTime")]
        ///  extern void REMOVE_ENTITY_START_TIME ();


        /// <summary>
        ///   System.Void RemoveExpectPosition()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveExpectPosition")]
        ///  extern void REMOVE_EXPECT_POSITION ();


        /// <summary>
        ///   System.Void RemoveFirstEnterGrid()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFirstEnterGrid")]
        ///  extern void REMOVE_FIRST_ENTER_GRID ();


        /// <summary>
        ///   System.Void RemoveFirstKillToWinTeam()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFirstKillToWinTeam")]
        ///  extern void REMOVE_FIRST_KILL_TO_WIN_TEAM ();


        /// <summary>
        ///   System.Void RemoveFlameHitCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFlameHitCount")]
        ///  extern void REMOVE_FLAME_HIT_COUNT ();


        /// <summary>
        ///   System.Void RemoveFlames()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFlames")]
        ///  extern void REMOVE_FLAMES ();


        /// <summary>
        ///   System.Void RemoveFlyingDirection()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFlyingDirection")]
        ///  extern void REMOVE_FLYING_DIRECTION ();


        /// <summary>
        ///   System.Void RemoveFlyStep()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFlyStep")]
        ///  extern void REMOVE_FLY_STEP ();


        /// <summary>
        ///   System.Void RemoveFlyTarget()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFlyTarget")]
        ///  extern void REMOVE_FLY_TARGET ();


        /// <summary>
        ///   System.Void RemoveGameFrame()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameFrame")]
        ///  extern void REMOVE_GAME_FRAME ();


        /// <summary>
        ///   System.Void RemoveGameProgress()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameProgress")]
        ///  extern void REMOVE_GAME_PROGRESS ();


        /// <summary>
        ///   System.Void RemoveGameResult()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameResult")]
        ///  extern void REMOVE_GAME_RESULT ();


        /// <summary>
        ///   System.Void RemoveGameTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameTime")]
        ///  extern void REMOVE_GAME_TIME ();


        /// <summary>
        ///   System.Void RemoveGameTotalSec()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameTotalSec")]
        ///  extern void REMOVE_GAME_TOTAL_SEC ();


        /// <summary>
        ///   System.Void RemoveGemMaxScore()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGemMaxScore")]
        ///  extern void REMOVE_GEM_MAX_SCORE ();


        /// <summary>
        ///   System.Void RemoveGM()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGM")]
        ///  extern void REMOVE_GM ();


        /// <summary>
        ///   System.Void RemoveGridBounds()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGridBounds")]
        ///  extern void REMOVE_GRID_BOUNDS ();


        /// <summary>
        ///   System.Void RemoveGridID()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGridID")]
        ///  extern void REMOVE_GRID_ID ();


        /// <summary>
        ///   System.Void RemoveHeroArr()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHeroArr")]
        ///  extern void REMOVE_HERO_ARR ();


        /// <summary>
        ///   System.Void RemoveHeroConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHeroConfig")]
        ///  extern void REMOVE_HERO_CONFIG ();


        /// <summary>
        ///   System.Void RemoveHeroData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHeroData")]
        ///  extern void REMOVE_HERO_DATA ();


        /// <summary>
        ///   System.Void RemoveInputDirection()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInputDirection")]
        ///  extern void REMOVE_INPUT_DIRECTION ();


        /// <summary>
        ///   System.Void RemoveInputService()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInputService")]
        ///  extern void REMOVE_INPUT_SERVICE ();


        /// <summary>
        ///   System.Void RemoveIsBlowedUp()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveIsBlowedUp")]
        ///  extern void REMOVE_IS_BLOWED_UP ();


        /// <summary>
        ///   System.Void RemoveIsPetrified()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveIsPetrified")]
        ///  extern void REMOVE_IS_PETRIFIED ();


        /// <summary>
        ///   System.Void RemoveIsTransparent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveIsTransparent")]
        ///  extern void REMOVE_IS_TRANSPARENT ();


        /// <summary>
        ///   System.Void RemoveItemBird()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItemBird")]
        ///  extern void REMOVE_ITEM_BIRD ();


        /// <summary>
        ///   System.Void RemoveItems()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItems")]
        ///  extern void REMOVE_ITEMS ();


        /// <summary>
        ///   System.Void RemoveItemState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItemState")]
        ///  extern void REMOVE_ITEM_STATE ();


        /// <summary>
        ///   System.Void RemoveItemType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItemType")]
        ///  extern void REMOVE_ITEM_TYPE ();


        /// <summary>
        ///   System.Void RemoveKillerUid()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveKillerUid")]
        ///  extern void REMOVE_KILLER_UID ();


        /// <summary>
        ///   System.Void RemoveLastApproachTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLastApproachTime")]
        ///  extern void REMOVE_LAST_APPROACH_TIME ();


        /// <summary>
        ///   System.Void RemoveLastGridID()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLastGridID")]
        ///  extern void REMOVE_LAST_GRID_ID ();


        /// <summary>
        ///   System.Void RemoveLastKillTeam()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLastKillTeam")]
        ///  extern void REMOVE_LAST_KILL_TEAM ();


        /// <summary>
        ///   System.Void RemoveLastPickPoint()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLastPickPoint")]
        ///  extern void REMOVE_LAST_PICK_POINT ();


        /// <summary>
        ///   System.Void RemoveLocalBombs()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLocalBombs")]
        ///  extern void REMOVE_LOCAL_BOMBS ();


        /// <summary>
        ///   System.Void RemoveLocalPlayers()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLocalPlayers")]
        ///  extern void REMOVE_LOCAL_PLAYERS ();


        /// <summary>
        ///   System.Void RemoveLogicDT()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLogicDT")]
        ///  extern void REMOVE_LOGIC_DT ();


        /// <summary>
        ///   System.Void RemoveMainPlayerInfos()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMainPlayerInfos")]
        ///  extern void REMOVE_MAIN_PLAYER_INFOS ();


        /// <summary>
        ///   System.Void RemoveMapBounds()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapBounds")]
        ///  extern void REMOVE_MAP_BOUNDS ();


        /// <summary>
        ///   System.Void RemoveMapConfig()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapConfig")]
        ///  extern void REMOVE_MAP_CONFIG ();


        /// <summary>
        ///   System.Void RemoveMapElems()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapElems")]
        ///  extern void REMOVE_MAP_ELEMS ();


        /// <summary>
        ///   System.Void RemoveMapElemState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapElemState")]
        ///  extern void REMOVE_MAP_ELEM_STATE ();


        /// <summary>
        ///   System.Void RemoveMapElemType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapElemType")]
        ///  extern void REMOVE_MAP_ELEM_TYPE ();


        /// <summary>
        ///   System.Void RemoveMapGrids()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapGrids")]
        ///  extern void REMOVE_MAP_GRIDS ();


        /// <summary>
        ///   System.Void RemoveMapType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapType")]
        ///  extern void REMOVE_MAP_TYPE ();


        /// <summary>
        ///   System.Void RemoveMovable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMovable")]
        ///  extern void REMOVE_MOVABLE ();


        /// <summary>
        ///   System.Void RemoveMoveDirection()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMoveDirection")]
        ///  extern void REMOVE_MOVE_DIRECTION ();


        /// <summary>
        ///   System.Void RemoveMoveSpeed()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMoveSpeed")]
        ///  extern void REMOVE_MOVE_SPEED ();


        /// <summary>
        ///   System.Void RemoveNetHeroIndex()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveNetHeroIndex")]
        ///  extern void REMOVE_NET_HERO_INDEX ();


        /// <summary>
        ///   System.Void RemoveNetState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveNetState")]
        ///  extern void REMOVE_NET_STATE ();


        /// <summary>
        ///   System.Void RemoveOwnerGridID()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOwnerGridID")]
        ///  extern void REMOVE_OWNER_GRID_ID ();


        /// <summary>
        ///   System.Void RemoveOwnerUID()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOwnerUID")]
        ///  extern void REMOVE_OWNER_UID ();


        /// <summary>
        ///   System.Void RemoveParentGrids()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveParentGrids")]
        ///  extern void REMOVE_PARENT_GRIDS ();


        /// <summary>
        ///   System.Void RemovePhasingPeriod()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePhasingPeriod")]
        ///  extern void REMOVE_PHASING_PERIOD ();


        /// <summary>
        ///   System.Void RemovePickType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePickType")]
        ///  extern void REMOVE_PICK_TYPE ();


        /// <summary>
        ///   System.Void RemovePosition()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePosition")]
        ///  extern void REMOVE_POSITION ();


        /// <summary>
        ///   System.Void RemovePowerHitGrids()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePowerHitGrids")]
        ///  extern void REMOVE_POWER_HIT_GRIDS ();


        /// <summary>
        ///   System.Void RemovePushTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePushTime")]
        ///  extern void REMOVE_PUSH_TIME ();


        /// <summary>
        ///   System.Void RemoveRandom()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRandom")]
        ///  extern void REMOVE_RANDOM ();


        /// <summary>
        ///   System.Void RemoveRelifeCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRelifeCount")]
        ///  extern void REMOVE_RELIFE_COUNT ();


        /// <summary>
        ///   System.Void RemoveRelifeInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRelifeInfo")]
        ///  extern void REMOVE_RELIFE_INFO ();


        /// <summary>
        ///   System.Void RemoveRelifeWaitTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRelifeWaitTime")]
        ///  extern void REMOVE_RELIFE_WAIT_TIME ();


        /// <summary>
        ///   System.Void RemoveRoleState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRoleState")]
        ///  extern void REMOVE_ROLE_STATE ();


        /// <summary>
        ///   System.Void RemoveRootParent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRootParent")]
        ///  extern void REMOVE_ROOT_PARENT ();


        /// <summary>
        ///   System.Void RemoveSonGrids()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSonGrids")]
        ///  extern void REMOVE_SON_GRIDS ();


        /// <summary>
        ///   System.Void RemoveStatisData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveStatisData")]
        ///  extern void REMOVE_STATIS_DATA ();


        /// <summary>
        ///   System.Void RemoveStoneCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveStoneCount")]
        ///  extern void REMOVE_STONE_COUNT ();


        /// <summary>
        ///   System.Void RemoveTeam()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTeam")]
        ///  extern void REMOVE_TEAM ();


        /// <summary>
        ///   System.Void RemoveTimerBomb()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTimerBomb")]
        ///  extern void REMOVE_TIMER_BOMB ();


        /// <summary>
        ///   System.Void RemoveTimerService()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTimerService")]
        ///  extern void REMOVE_TIMER_SERVICE ();


        /// <summary>
        ///   System.Void RemoveTransparentBombEndTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTransparentBombEndTime")]
        ///  extern void REMOVE_TRANSPARENT_BOMB_END_TIME ();


        /// <summary>
        ///   System.Void RemoveTrappedCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTrappedCount")]
        ///  extern void REMOVE_TRAPPED_COUNT ();


        /// <summary>
        ///   System.Void RemoveTrappedEndTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTrappedEndTime")]
        ///  extern void REMOVE_TRAPPED_END_TIME ();


        /// <summary>
        ///   System.Void RemoveTreasureData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTreasureData")]
        ///  extern void REMOVE_TREASURE_DATA ();


        /// <summary>
        ///   System.Void RemoveTreasureGemLeader()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTreasureGemLeader")]
        ///  extern void REMOVE_TREASURE_GEM_LEADER ();


        /// <summary>
        ///   System.Void RemoveTryBomb()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTryBomb")]
        ///  extern void REMOVE_TRY_BOMB ();


        /// <summary>
        ///   System.Void RemoveTwoTeamMatch()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTwoTeamMatch")]
        ///  extern void REMOVE_TWO_TEAM_MATCH ();


        /// <summary>
        ///   System.Void RemoveUID()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUID")]
        ///  extern void REMOVE_UID ();


        /// <summary>
        ///   System.Void RemoveUnexplodeBomb()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnexplodeBomb")]
        ///  extern void REMOVE_UNEXPLODE_BOMB ();


        /// <summary>
        ///   System.Void RemoveUnitType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnitType")]
        ///  extern void REMOVE_UNIT_TYPE ();


        /// <summary>
        ///   System.Void RemoveUseBagNum()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUseBagNum")]
        ///  extern void REMOVE_USE_BAG_NUM ();


        /// <summary>
        ///   System.Void RemoveUsedItemID()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUsedItemID")]
        ///  extern void REMOVE_USED_ITEM_ID ();


        /// <summary>
        ///   System.Void RemoveView()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveView")]
        ///  extern void REMOVE_VIEW ();


        /// <summary>
        ///   System.Void RemoveViewField()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveViewField")]
        ///  extern void REMOVE_VIEW_FIELD ();


        /// <summary>
        ///   System.Void RemoveWinnerTeam()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWinnerTeam")]
        ///  extern void REMOVE_WINNER_TEAM ();


        /// <summary>
        ///   System.Void ReplaceActivatingTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceActivatingTime")]
        ///  extern void REPLACE_ACTIVATING_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void ReplaceActiveGridID(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceActiveGridID")]
        ///  extern void REPLACE_ACTIVE_GRID_ID (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void ReplaceAnyAssetListener(System.Collections.Generic.List<IAnyAssetListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyAssetListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnyAssetListener")]
        ///  extern void REPLACE_ANY_ASSET_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAnyFlamesListener(System.Collections.Generic.List<IAnyFlamesListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyFlamesListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnyFlamesListener")]
        ///  extern void REPLACE_ANY_FLAMES_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAnyGameProgressListener(System.Collections.Generic.List<IAnyGameProgressListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyGameProgressListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnyGameProgressListener")]
        ///  extern void REPLACE_ANY_GAME_PROGRESS_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAnyGMListener(System.Collections.Generic.List<IAnyGMListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyGMListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnyGMListener")]
        ///  extern void REPLACE_ANY_GM_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAnyViewFieldListener(System.Collections.Generic.List<IAnyViewFieldListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyViewFieldListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnyViewFieldListener")]
        ///  extern void REPLACE_ANY_VIEW_FIELD_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAnyViewListener(System.Collections.Generic.List<IAnyViewListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IAnyViewListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAnyViewListener")]
        ///  extern void REPLACE_ANY_VIEW_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAsset(System.Int32 newAssetID)
        /// </summary>
        /// <param name="newAssetID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAsset")]
        ///  extern void REPLACE_ASSET (System.Int32 newAssetID);


        /// <summary>
        ///   System.Void ReplaceAudioService(IAudioService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IAudioService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAudioService")]
        ///  extern void REPLACE_AUDIO_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void ReplaceBag(System.Collections.Generic.List<GameEntity> newLst)
        /// </summary>
        /// <param name="newLst">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBag")]
        ///  extern void REPLACE_BAG (nint newLst);


        /// <summary>
        ///   System.Void ReplaceBagIndex(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBagIndex")]
        ///  extern void REPLACE_BAG_INDEX (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceBagItemCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBagItemCount")]
        ///  extern void REPLACE_BAG_ITEM_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceBagListener(System.Collections.Generic.List<IBagListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBagListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBagListener")]
        ///  extern void REPLACE_BAG_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceBattleMode(PBProto.BattleMode newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.BattleMode</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBattleMode")]
        ///  extern void REPLACE_BATTLE_MODE (PBProto.BattleMode newValue);


        /// <summary>
        ///   System.Void ReplaceBlowUpFlames(GameEntity[,] newArr, System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newArr">class GameEntity[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBlowUpFlames")]
        ///  extern void REPLACE_BLOW_UP_FLAMES (nint newArr, nint newList);


        /// <summary>
        ///   System.Void ReplaceBombConfig(BombConfig newValue)
        /// </summary>
        /// <param name="newValue">class BombConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBombConfig")]
        ///  extern void REPLACE_BOMB_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void ReplaceBombCount(System.Int32 newValue, System.Int32 newItemCount)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <param name="newItemCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBombCount")]
        ///  extern void REPLACE_BOMB_COUNT (System.Int32 newValue, System.Int32 newItemCount);


        /// <summary>
        ///   System.Void ReplaceBombCountListener(System.Collections.Generic.List<IBombCountListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBombCountListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBombCountListener")]
        ///  extern void REPLACE_BOMB_COUNT_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceBombPower(System.Int32 newValue, System.Int32 newItemCount)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <param name="newItemCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBombPower")]
        ///  extern void REPLACE_BOMB_POWER (System.Int32 newValue, System.Int32 newItemCount);


        /// <summary>
        ///   System.Void ReplaceBombPowerListener(System.Collections.Generic.List<IBombPowerListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBombPowerListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBombPowerListener")]
        ///  extern void REPLACE_BOMB_POWER_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceBombs(System.Collections.Generic.List<GameEntity>[,] newArr, System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newArr">class System.Collections.Generic.List<GameEntity>[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBombs")]
        ///  extern void REPLACE_BOMBS (nint newArr, nint newList);


        /// <summary>
        ///   System.Void ReplaceBombState(BombState newValue)
        /// </summary>
        /// <param name="newValue">enum BombState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBombState")]
        ///  extern void REPLACE_BOMB_STATE (BombState newValue);


        /// <summary>
        ///   System.Void ReplaceBombStateListener(System.Collections.Generic.List<IBombStateListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBombStateListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBombStateListener")]
        ///  extern void REPLACE_BOMB_STATE_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceBombType(BombType newValue)
        /// </summary>
        /// <param name="newValue">enum BombType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBombType")]
        ///  extern void REPLACE_BOMB_TYPE (BombType newValue);


        /// <summary>
        ///   System.Void ReplaceBuffInvincible(SimpleFixMath.Fix newDuration)
        /// </summary>
        /// <param name="newDuration">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBuffInvincible")]
        ///  extern void REPLACE_BUFF_INVINCIBLE (SimpleFixMath.Fix newDuration);


        /// <summary>
        ///   System.Void ReplaceBuffInvincibleListener(System.Collections.Generic.List<IBuffInvincibleListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBuffInvincibleListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBuffInvincibleListener")]
        ///  extern void REPLACE_BUFF_INVINCIBLE_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceBuffInvincibleRemovedListener(System.Collections.Generic.List<IBuffInvincibleRemovedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBuffInvincibleRemovedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBuffInvincibleRemovedListener")]
        ///  extern void REPLACE_BUFF_INVINCIBLE_REMOVED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceBuffSlow(SimpleFixMath.Fix newDuration)
        /// </summary>
        /// <param name="newDuration">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBuffSlow")]
        ///  extern void REPLACE_BUFF_SLOW (SimpleFixMath.Fix newDuration);


        /// <summary>
        ///   System.Void ReplaceBuffXJP(SimpleFixMath.Fix newDuration)
        /// </summary>
        /// <param name="newDuration">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBuffXJP")]
        ///  extern void REPLACE_BUFF_XJP (SimpleFixMath.Fix newDuration);


        /// <summary>
        ///   System.Void ReplaceBuildings(GameEntity[,] newBunsArr, System.Collections.Generic.List<GameEntity> newBunsLst, GameEntity[,] newSculptureArr, System.Collections.Generic.List<GameEntity> newSculptureLst)
        /// </summary>
        /// <param name="newBunsArr">class GameEntity[,]</param>
        /// <param name="newBunsLst">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newSculptureArr">class GameEntity[,]</param>
        /// <param name="newSculptureLst">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBuildings")]
        ///  extern void REPLACE_BUILDINGS (nint newBunsArr, nint newBunsLst, nint newSculptureArr, nint newSculptureLst);


        /// <summary>
        ///   System.Void ReplaceBunCount(System.Int32 newOwnerTeam, System.Int32 newEnemyTeam)
        /// </summary>
        /// <param name="newOwnerTeam">struct System.Int32</param>
        /// <param name="newEnemyTeam">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBunCount")]
        ///  extern void REPLACE_BUN_COUNT (System.Int32 newOwnerTeam, System.Int32 newEnemyTeam);


        /// <summary>
        ///   System.Void ReplaceBunCountListener(System.Collections.Generic.List<IBunCountListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IBunCountListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBunCountListener")]
        ///  extern void REPLACE_BUN_COUNT_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceBunOrStoneCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBunOrStoneCount")]
        ///  extern void REPLACE_BUN_OR_STONE_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceCanPushBomb(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCanPushBomb")]
        ///  extern void REPLACE_CAN_PUSH_BOMB (System.Boolean newValue);


        /// <summary>
        ///   System.Void ReplaceCatchCatCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCatchCatCount")]
        ///  extern void REPLACE_CATCH_CAT_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void replaceComponent(System.Int32 index, Entitas.IComponent replacement)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="replacement">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("replaceComponent")]
        ///  extern void REPLACE_COMPONENT (System.Int32 index, nint replacement);


        /// <summary>
        ///   System.Void ReplaceComponent(System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceComponent")]
        ///  extern void REPLACE_COMPONENT (System.Int32 index, nint component);


        /// <summary>
        ///   System.Void ReplaceComposeGrids(System.Collections.Generic.List<SimpleFixMath.FixVector2> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<SimpleFixMath.FixVector2></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceComposeGrids")]
        ///  extern void REPLACE_COMPOSE_GRIDS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceComposeWallType(ComposeWallType newValue)
        /// </summary>
        /// <param name="newValue">enum ComposeWallType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceComposeWallType")]
        ///  extern void REPLACE_COMPOSE_WALL_TYPE (ComposeWallType newValue);


        /// <summary>
        ///   System.Void ReplaceConfigService(IConfigService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IConfigService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceConfigService")]
        ///  extern void REPLACE_CONFIG_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void ReplaceDebugMessageCompoenet(System.String newMessage)
        /// </summary>
        /// <param name="newMessage">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDebugMessageCompoenet")]
        ///  extern void REPLACE_DEBUG_MESSAGE_COMPOENET (nint newMessage);


        /// <summary>
        ///   System.Void ReplaceDestroyedListener(System.Collections.Generic.List<IDestroyedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IDestroyedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDestroyedListener")]
        ///  extern void REPLACE_DESTROYED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceDoorDirType(DoorDirType newValue)
        /// </summary>
        /// <param name="newValue">enum DoorDirType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDoorDirType")]
        ///  extern void REPLACE_DOOR_DIR_TYPE (DoorDirType newValue);


        /// <summary>
        ///   System.Void ReplaceEmoTyp(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEmoTyp")]
        ///  extern void REPLACE_EMO_TYP (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceEmoTypListener(System.Collections.Generic.List<IEmoTypListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IEmoTypListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEmoTypListener")]
        ///  extern void REPLACE_EMO_TYP_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceEnablePassWall(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEnablePassWall")]
        ///  extern void REPLACE_ENABLE_PASS_WALL (System.Boolean newValue);


        /// <summary>
        ///   System.Void ReplaceEntityEndLocalTime(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEntityEndLocalTime")]
        ///  extern void REPLACE_ENTITY_END_LOCAL_TIME (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceEntityEndTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEntityEndTime")]
        ///  extern void REPLACE_ENTITY_END_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void ReplaceEntityExpectEndTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEntityExpectEndTime")]
        ///  extern void REPLACE_ENTITY_EXPECT_END_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void ReplaceEntityFactoryService(EntityFactoryService newInstance)
        /// </summary>
        /// <param name="newInstance">class EntityFactoryService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEntityFactoryService")]
        ///  extern void REPLACE_ENTITY_FACTORY_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void ReplaceEntityStartLocalTime(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEntityStartLocalTime")]
        ///  extern void REPLACE_ENTITY_START_LOCAL_TIME (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceEntityStartTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEntityStartTime")]
        ///  extern void REPLACE_ENTITY_START_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void ReplaceExpectPosition(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceExpectPosition")]
        ///  extern void REPLACE_EXPECT_POSITION (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void ReplaceFirstEnterGrid(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFirstEnterGrid")]
        ///  extern void REPLACE_FIRST_ENTER_GRID (System.Boolean newValue);


        /// <summary>
        ///   System.Void ReplaceFirstKillToWinTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFirstKillToWinTeam")]
        ///  extern void REPLACE_FIRST_KILL_TO_WIN_TEAM (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.Void ReplaceFlameHitCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFlameHitCount")]
        ///  extern void REPLACE_FLAME_HIT_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceFlames(GameEntity[,] newArr, System.Collections.Generic.List<GameEntity> newList, System.Collections.Generic.List<GameEntity> newLatest_list)
        /// </summary>
        /// <param name="newArr">class GameEntity[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newLatest_list">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFlames")]
        ///  extern void REPLACE_FLAMES (nint newArr, nint newList, nint newLatest_list);


        /// <summary>
        ///   System.Void ReplaceFlyingDirection(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFlyingDirection")]
        ///  extern void REPLACE_FLYING_DIRECTION (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void ReplaceFlyStep(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFlyStep")]
        ///  extern void REPLACE_FLY_STEP (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceFlyTarget(SimpleFixMath.FixVector2 newPos, SimpleFixMath.FixVector2 newGridID)
        /// </summary>
        /// <param name="newPos">struct SimpleFixMath.FixVector2</param>
        /// <param name="newGridID">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFlyTarget")]
        ///  extern void REPLACE_FLY_TARGET (SimpleFixMath.FixVector2 newPos, SimpleFixMath.FixVector2 newGridID);


        /// <summary>
        ///   System.Void ReplaceGameFrame(System.UInt32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.UInt32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameFrame")]
        ///  extern void REPLACE_GAME_FRAME (System.UInt32 newValue);


        /// <summary>
        ///   System.Void ReplaceGameProgress(GameProgressState newValue)
        /// </summary>
        /// <param name="newValue">enum GameProgressState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameProgress")]
        ///  extern void REPLACE_GAME_PROGRESS (GameProgressState newValue);


        /// <summary>
        ///   System.Void ReplaceGameResult(GameReuslt newValue, System.Collections.Generic.List<System.UInt32> newWinnerList)
        /// </summary>
        /// <param name="newValue">enum GameReuslt</param>
        /// <param name="newWinnerList">class System.Collections.Generic.List<System.UInt32></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameResult")]
        ///  extern void REPLACE_GAME_RESULT (GameReuslt newValue, nint newWinnerList);


        /// <summary>
        ///   System.Void ReplaceGameTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameTime")]
        ///  extern void REPLACE_GAME_TIME (SimpleFixMath.Fix newValue);



        /// <summary>
        ///   System.Void RemoveAnyAssetListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyAssetListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_ASSET_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveAnyAssetListener(IAnyAssetListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IAnyAssetListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyAssetListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_ASSET_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveAnyFlamesListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyFlamesListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_FLAMES_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveAnyFlamesListener(IAnyFlamesListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IAnyFlamesListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyFlamesListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_FLAMES_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveAnyGameProgressListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyGameProgressListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_GAME_PROGRESS_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveAnyGameProgressListener(IAnyGameProgressListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IAnyGameProgressListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyGameProgressListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_GAME_PROGRESS_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveAnyGMListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyGMListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_GM_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveAnyGMListener(IAnyGMListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IAnyGMListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyGMListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_GM_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveAnyViewFieldListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyViewFieldListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_VIEW_FIELD_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveAnyViewFieldListener(IAnyViewFieldListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IAnyViewFieldListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyViewFieldListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_VIEW_FIELD_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveAnyViewListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyViewListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_VIEW_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveAnyViewListener(IAnyViewListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IAnyViewListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAnyViewListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ANY_VIEW_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveBagListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBagListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BAG_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveBagListener(IBagListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IBagListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBagListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BAG_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveBombCountListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BOMB_COUNT_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveBombCountListener(IBombCountListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IBombCountListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BOMB_COUNT_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveBombPowerListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombPowerListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BOMB_POWER_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveBombPowerListener(IBombPowerListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IBombPowerListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombPowerListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BOMB_POWER_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveBombStateListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BOMB_STATE_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveBombStateListener(IBombStateListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IBombStateListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BOMB_STATE_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveBuffInvincibleListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuffInvincibleListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BUFF_INVINCIBLE_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveBuffInvincibleListener(IBuffInvincibleListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IBuffInvincibleListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuffInvincibleListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BUFF_INVINCIBLE_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveBuffInvincibleRemovedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuffInvincibleRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BUFF_INVINCIBLE_REMOVED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveBuffInvincibleRemovedListener(IBuffInvincibleRemovedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IBuffInvincibleRemovedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuffInvincibleRemovedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BUFF_INVINCIBLE_REMOVED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveBunCountListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBunCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BUN_COUNT_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveBunCountListener(IBunCountListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IBunCountListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBunCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_BUN_COUNT_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveDestroyedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDestroyedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_DESTROYED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveDestroyedListener(IDestroyedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IDestroyedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDestroyedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_DESTROYED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveEmoTypListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEmoTypListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_EMO_TYP_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveEmoTypListener(IEmoTypListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IEmoTypListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEmoTypListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_EMO_TYP_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveIsPetrifiedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveIsPetrifiedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_IS_PETRIFIED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveIsPetrifiedListener(IIsPetrifiedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IIsPetrifiedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveIsPetrifiedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_IS_PETRIFIED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveItemStateListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItemStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ITEM_STATE_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveItemStateListener(IItemStateListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IItemStateListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItemStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ITEM_STATE_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveMapElemStateListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapElemStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_MAP_ELEM_STATE_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveMapElemStateListener(IMapElemStateListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IMapElemStateListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapElemStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_MAP_ELEM_STATE_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveMoveDirectionListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMoveDirectionListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_MOVE_DIRECTION_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveMoveDirectionListener(IMoveDirectionListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IMoveDirectionListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMoveDirectionListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_MOVE_DIRECTION_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveMoveSpeedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMoveSpeedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_MOVE_SPEED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveMoveSpeedListener(IMoveSpeedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IMoveSpeedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMoveSpeedListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_MOVE_SPEED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveNetStateListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveNetStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_NET_STATE_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveNetStateListener(INetStateListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface INetStateListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveNetStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_NET_STATE_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemovePickTypeListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePickTypeListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_PICK_TYPE_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemovePickTypeListener(IPickTypeListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IPickTypeListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePickTypeListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_PICK_TYPE_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemovePositionListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePositionListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_POSITION_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemovePositionListener(IPositionListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IPositionListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePositionListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_POSITION_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveRoleStateListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRoleStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ROLE_STATE_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveRoleStateListener(IRoleStateListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IRoleStateListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRoleStateListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_ROLE_STATE_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveStatisDataListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveStatisDataListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_STATIS_DATA_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveStatisDataListener(IStatisDataListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IStatisDataListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveStatisDataListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_STATIS_DATA_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveStoneCountListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveStoneCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_STONE_COUNT_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveStoneCountListener(IStoneCountListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IStoneCountListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveStoneCountListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_STONE_COUNT_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveTimerBombListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTimerBombListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_TIMER_BOMB_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveTimerBombListener(ITimerBombListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface ITimerBombListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTimerBombListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_TIMER_BOMB_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveTreasureDataListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTreasureDataListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_TREASURE_DATA_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveTreasureDataListener(ITreasureDataListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface ITreasureDataListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTreasureDataListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_TREASURE_DATA_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveTreasureGemLeaderListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTreasureGemLeaderListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_TREASURE_GEM_LEADER_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveTreasureGemLeaderListener(ITreasureGemLeaderListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface ITreasureGemLeaderListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTreasureGemLeaderListener", Search = typeof(Search_GameEntity))]
        ///  extern void REMOVE_TREASURE_GEM_LEADER_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// public static partial class Search_GameEntity
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void RemoveAnyAssetListener()
        /// </summary>
        /// public static bool REMOVE_ANY_ASSET_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyAssetListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyAssetListener(IAnyAssetListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_ANY_ASSET_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyAssetListener", "IAnyAssetListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyFlamesListener()
        /// </summary>
        /// public static bool REMOVE_ANY_FLAMES_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyFlamesListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyFlamesListener(IAnyFlamesListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_ANY_FLAMES_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyFlamesListener", "IAnyFlamesListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyGameProgressListener()
        /// </summary>
        /// public static bool REMOVE_ANY_GAME_PROGRESS_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyGameProgressListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyGameProgressListener(IAnyGameProgressListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_ANY_GAME_PROGRESS_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyGameProgressListener", "IAnyGameProgressListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyGMListener()
        /// </summary>
        /// public static bool REMOVE_ANY_GM_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyGMListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyGMListener(IAnyGMListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_ANY_GM_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyGMListener", "IAnyGMListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyViewFieldListener()
        /// </summary>
        /// public static bool REMOVE_ANY_VIEW_FIELD_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyViewFieldListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyViewFieldListener(IAnyViewFieldListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_ANY_VIEW_FIELD_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyViewFieldListener", "IAnyViewFieldListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyViewListener()
        /// </summary>
        /// public static bool REMOVE_ANY_VIEW_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyViewListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveAnyViewListener(IAnyViewListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_ANY_VIEW_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveAnyViewListener", "IAnyViewListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBagListener()
        /// </summary>
        /// public static bool REMOVE_BAG_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBagListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBagListener(IBagListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_BAG_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBagListener", "IBagListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBombCountListener()
        /// </summary>
        /// public static bool REMOVE_BOMB_COUNT_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBombCountListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBombCountListener(IBombCountListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_BOMB_COUNT_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBombCountListener", "IBombCountListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBombPowerListener()
        /// </summary>
        /// public static bool REMOVE_BOMB_POWER_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBombPowerListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBombPowerListener(IBombPowerListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_BOMB_POWER_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBombPowerListener", "IBombPowerListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBombStateListener()
        /// </summary>
        /// public static bool REMOVE_BOMB_STATE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBombStateListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBombStateListener(IBombStateListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_BOMB_STATE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBombStateListener", "IBombStateListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBuffInvincibleListener()
        /// </summary>
        /// public static bool REMOVE_BUFF_INVINCIBLE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBuffInvincibleListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBuffInvincibleListener(IBuffInvincibleListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_BUFF_INVINCIBLE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBuffInvincibleListener", "IBuffInvincibleListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBuffInvincibleRemovedListener()
        /// </summary>
        /// public static bool REMOVE_BUFF_INVINCIBLE_REMOVED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBuffInvincibleRemovedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBuffInvincibleRemovedListener(IBuffInvincibleRemovedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_BUFF_INVINCIBLE_REMOVED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBuffInvincibleRemovedListener", "IBuffInvincibleRemovedListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBunCountListener()
        /// </summary>
        /// public static bool REMOVE_BUN_COUNT_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBunCountListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveBunCountListener(IBunCountListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_BUN_COUNT_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveBunCountListener", "IBunCountListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveDestroyedListener()
        /// </summary>
        /// public static bool REMOVE_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveDestroyedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveDestroyedListener(IDestroyedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveDestroyedListener", "IDestroyedListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveEmoTypListener()
        /// </summary>
        /// public static bool REMOVE_EMO_TYP_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveEmoTypListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveEmoTypListener(IEmoTypListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_EMO_TYP_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveEmoTypListener", "IEmoTypListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveIsPetrifiedListener()
        /// </summary>
        /// public static bool REMOVE_IS_PETRIFIED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveIsPetrifiedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveIsPetrifiedListener(IIsPetrifiedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_IS_PETRIFIED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveIsPetrifiedListener", "IIsPetrifiedListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveItemStateListener()
        /// </summary>
        /// public static bool REMOVE_ITEM_STATE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveItemStateListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveItemStateListener(IItemStateListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_ITEM_STATE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveItemStateListener", "IItemStateListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveMapElemStateListener()
        /// </summary>
        /// public static bool REMOVE_MAP_ELEM_STATE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveMapElemStateListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveMapElemStateListener(IMapElemStateListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_MAP_ELEM_STATE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveMapElemStateListener", "IMapElemStateListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveMoveDirectionListener()
        /// </summary>
        /// public static bool REMOVE_MOVE_DIRECTION_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveMoveDirectionListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveMoveDirectionListener(IMoveDirectionListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_MOVE_DIRECTION_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveMoveDirectionListener", "IMoveDirectionListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveMoveSpeedListener()
        /// </summary>
        /// public static bool REMOVE_MOVE_SPEED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveMoveSpeedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveMoveSpeedListener(IMoveSpeedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_MOVE_SPEED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveMoveSpeedListener", "IMoveSpeedListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveNetStateListener()
        /// </summary>
        /// public static bool REMOVE_NET_STATE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveNetStateListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveNetStateListener(INetStateListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_NET_STATE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveNetStateListener", "INetStateListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePickTypeListener()
        /// </summary>
        /// public static bool REMOVE_PICK_TYPE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePickTypeListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePickTypeListener(IPickTypeListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_PICK_TYPE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePickTypeListener", "IPickTypeListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePositionListener()
        /// </summary>
        /// public static bool REMOVE_POSITION_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePositionListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePositionListener(IPositionListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_POSITION_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePositionListener", "IPositionListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveRoleStateListener()
        /// </summary>
        /// public static bool REMOVE_ROLE_STATE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveRoleStateListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveRoleStateListener(IRoleStateListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_ROLE_STATE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveRoleStateListener", "IRoleStateListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveStatisDataListener()
        /// </summary>
        /// public static bool REMOVE_STATIS_DATA_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveStatisDataListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveStatisDataListener(IStatisDataListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_STATIS_DATA_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveStatisDataListener", "IStatisDataListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveStoneCountListener()
        /// </summary>
        /// public static bool REMOVE_STONE_COUNT_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveStoneCountListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveStoneCountListener(IStoneCountListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_STONE_COUNT_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveStoneCountListener", "IStoneCountListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveTimerBombListener()
        /// </summary>
        /// public static bool REMOVE_TIMER_BOMB_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveTimerBombListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveTimerBombListener(ITimerBombListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_TIMER_BOMB_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveTimerBombListener", "ITimerBombListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveTreasureDataListener()
        /// </summary>
        /// public static bool REMOVE_TREASURE_DATA_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveTreasureDataListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveTreasureDataListener(ITreasureDataListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_TREASURE_DATA_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveTreasureDataListener", "ITreasureDataListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveTreasureGemLeaderListener()
        /// </summary>
        /// public static bool REMOVE_TREASURE_GEM_LEADER_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveTreasureGemLeaderListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveTreasureGemLeaderListener(ITreasureGemLeaderListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_TREASURE_GEM_LEADER_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveTreasureGemLeaderListener", "ITreasureGemLeaderListener", "System.Boolean");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."GameEntity"]
    /// </summary>
    public partial class GameEntity
    {



        /// <summary>
        ///   System.Void ReplaceGameTotalSec(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameTotalSec")]
        ///  extern void REPLACE_GAME_TOTAL_SEC (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceGemMaxScore(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGemMaxScore")]
        ///  extern void REPLACE_GEM_MAX_SCORE (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceGM(GMParam newValue)
        /// </summary>
        /// <param name="newValue">class GMParam</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGM")]
        ///  extern void REPLACE_GM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceGridBounds(Bounds2D newValue)
        /// </summary>
        /// <param name="newValue">class Bounds2D</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGridBounds")]
        ///  extern void REPLACE_GRID_BOUNDS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceGridID(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGridID")]
        ///  extern void REPLACE_GRID_ID (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void ReplaceHeroArr(GameEntity[] newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHeroArr")]
        ///  extern void REPLACE_HERO_ARR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceHeroConfig(RoleConfig newValue)
        /// </summary>
        /// <param name="newValue">class RoleConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHeroConfig")]
        ///  extern void REPLACE_HERO_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void ReplaceHeroData(PBProto.BattleHeroData newValue)
        /// </summary>
        /// <param name="newValue">class PBProto.BattleHeroData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHeroData")]
        ///  extern void REPLACE_HERO_DATA (nint newValue);


        /// <summary>
        ///   System.Void ReplaceInputDirection(PBProto.MoveDirectionType newValue, PBProto.MoveDirectionType newLast)
        /// </summary>
        /// <param name="newValue">enum PBProto.MoveDirectionType</param>
        /// <param name="newLast">enum PBProto.MoveDirectionType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInputDirection")]
        ///  extern void REPLACE_INPUT_DIRECTION (PBProto.MoveDirectionType newValue, PBProto.MoveDirectionType newLast);


        /// <summary>
        ///   System.Void ReplaceInputService(IInputService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IInputService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInputService")]
        ///  extern void REPLACE_INPUT_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void ReplaceIsBlowedUp(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceIsBlowedUp")]
        ///  extern void REPLACE_IS_BLOWED_UP (System.Boolean newValue);


        /// <summary>
        ///   System.Void ReplaceIsPetrified(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceIsPetrified")]
        ///  extern void REPLACE_IS_PETRIFIED (System.Boolean newValue);


        /// <summary>
        ///   System.Void ReplaceIsPetrifiedListener(System.Collections.Generic.List<IIsPetrifiedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IIsPetrifiedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceIsPetrifiedListener")]
        ///  extern void REPLACE_IS_PETRIFIED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceIsTransparent(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceIsTransparent")]
        ///  extern void REPLACE_IS_TRANSPARENT (System.Boolean newValue);


        /// <summary>
        ///   System.Void ReplaceItemBird(System.Collections.Generic.Queue<GameEntity> newQueue, SimpleFixMath.Fix newTimer, ItemBirdState newState)
        /// </summary>
        /// <param name="newQueue">class System.Collections.Generic.Queue<GameEntity></param>
        /// <param name="newTimer">struct SimpleFixMath.Fix</param>
        /// <param name="newState">enum ItemBirdState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceItemBird")]
        ///  extern void REPLACE_ITEM_BIRD (nint newQueue, SimpleFixMath.Fix newTimer, ItemBirdState newState);


        /// <summary>
        ///   System.Void ReplaceItems(System.Collections.Generic.Queue<GameEntity>[,] newQueue, System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newQueue">class System.Collections.Generic.Queue<GameEntity>[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceItems")]
        ///  extern void REPLACE_ITEMS (nint newQueue, nint newList);


        /// <summary>
        ///   System.Void ReplaceItemState(ItemState newValue)
        /// </summary>
        /// <param name="newValue">enum ItemState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceItemState")]
        ///  extern void REPLACE_ITEM_STATE (ItemState newValue);


        /// <summary>
        ///   System.Void ReplaceItemStateListener(System.Collections.Generic.List<IItemStateListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IItemStateListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceItemStateListener")]
        ///  extern void REPLACE_ITEM_STATE_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceItemType(ItemType newValue)
        /// </summary>
        /// <param name="newValue">enum ItemType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceItemType")]
        ///  extern void REPLACE_ITEM_TYPE (ItemType newValue);


        /// <summary>
        ///   System.Void ReplaceKillerUid(System.UInt64 newValue)
        /// </summary>
        /// <param name="newValue">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceKillerUid")]
        ///  extern void REPLACE_KILLER_UID (System.UInt64 newValue);


        /// <summary>
        ///   System.Void ReplaceLastApproachTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLastApproachTime")]
        ///  extern void REPLACE_LAST_APPROACH_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void ReplaceLastGridID(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLastGridID")]
        ///  extern void REPLACE_LAST_GRID_ID (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void ReplaceLastKillTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLastKillTeam")]
        ///  extern void REPLACE_LAST_KILL_TEAM (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.Void ReplaceLastPickPoint(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLastPickPoint")]
        ///  extern void REPLACE_LAST_PICK_POINT (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.Void ReplaceLocalBombs(System.Collections.Generic.List<GameEntity>[,] newArr)
        /// </summary>
        /// <param name="newArr">class System.Collections.Generic.List<GameEntity>[,]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLocalBombs")]
        ///  extern void REPLACE_LOCAL_BOMBS (nint newArr);


        /// <summary>
        ///   System.Void ReplaceLocalPlayers(System.Collections.Generic.List<GameEntity> newLst)
        /// </summary>
        /// <param name="newLst">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLocalPlayers")]
        ///  extern void REPLACE_LOCAL_PLAYERS (nint newLst);


        /// <summary>
        ///   System.Void ReplaceLogicDT(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLogicDT")]
        ///  extern void REPLACE_LOGIC_DT (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void ReplaceMainPlayerInfos(GameEntity newLogicEntity, PBProto.MoveDirectionType newMoveDir, PBProto.MoveDirectionType newFaceDir, SafeVector2 newPos, UnityEngine.Vector2 newLastPos)
        /// </summary>
        /// <param name="newLogicEntity">class GameEntity</param>
        /// <param name="newMoveDir">enum PBProto.MoveDirectionType</param>
        /// <param name="newFaceDir">enum PBProto.MoveDirectionType</param>
        /// <param name="newPos">class SafeVector2</param>
        /// <param name="newLastPos">struct UnityEngine.Vector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMainPlayerInfos")]
        ///  extern void REPLACE_MAIN_PLAYER_INFOS (nint newLogicEntity, PBProto.MoveDirectionType newMoveDir, PBProto.MoveDirectionType newFaceDir, nint newPos, UnityEngine.Vector2 newLastPos);


        /// <summary>
        ///   System.Void ReplaceMapBounds(SimpleFixMath.FixVector2 newMax, SimpleFixMath.FixVector2 newMin)
        /// </summary>
        /// <param name="newMax">struct SimpleFixMath.FixVector2</param>
        /// <param name="newMin">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapBounds")]
        ///  extern void REPLACE_MAP_BOUNDS (SimpleFixMath.FixVector2 newMax, SimpleFixMath.FixVector2 newMin);


        /// <summary>
        ///   System.Void ReplaceMapConfig(MapConfig newValue)
        /// </summary>
        /// <param name="newValue">class MapConfig</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapConfig")]
        ///  extern void REPLACE_MAP_CONFIG (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMapElems(GameEntity[,] newWallArr, GameEntity[,] newDoorArr, System.Collections.Generic.List<GameEntity> newComposeWallList, GameEntity[,] newBrickArr, System.Collections.Generic.List<GameEntity> newBrickList, GameEntity[,] newMoveBrickArr, System.Collections.Generic.List<GameEntity> newMoveBrickList, GameEntity[,] newGrassArr, System.Collections.Generic.List<GameEntity> newGrassList)
        /// </summary>
        /// <param name="newWallArr">class GameEntity[,]</param>
        /// <param name="newDoorArr">class GameEntity[,]</param>
        /// <param name="newComposeWallList">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newBrickArr">class GameEntity[,]</param>
        /// <param name="newBrickList">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newMoveBrickArr">class GameEntity[,]</param>
        /// <param name="newMoveBrickList">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newGrassArr">class GameEntity[,]</param>
        /// <param name="newGrassList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapElems")]
        ///  extern void REPLACE_MAP_ELEMS (nint newWallArr, nint newDoorArr, nint newComposeWallList, nint newBrickArr, nint newBrickList, nint newMoveBrickArr, nint newMoveBrickList, nint newGrassArr, nint newGrassList);


        /// <summary>
        ///   System.Void ReplaceMapElemState(MapElemState newValue)
        /// </summary>
        /// <param name="newValue">enum MapElemState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapElemState")]
        ///  extern void REPLACE_MAP_ELEM_STATE (MapElemState newValue);


        /// <summary>
        ///   System.Void ReplaceMapElemStateListener(System.Collections.Generic.List<IMapElemStateListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IMapElemStateListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapElemStateListener")]
        ///  extern void REPLACE_MAP_ELEM_STATE_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMapElemType(MapElemType newValue)
        /// </summary>
        /// <param name="newValue">enum MapElemType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapElemType")]
        ///  extern void REPLACE_MAP_ELEM_TYPE (MapElemType newValue);


        /// <summary>
        ///   System.Void ReplaceMapGrids(GameEntity[,] newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity[,]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapGrids")]
        ///  extern void REPLACE_MAP_GRIDS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMapType(PBProto.MapType newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.MapType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapType")]
        ///  extern void REPLACE_MAP_TYPE (PBProto.MapType newValue);


        /// <summary>
        ///   System.Void ReplaceMovable(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMovable")]
        ///  extern void REPLACE_MOVABLE (System.Boolean newValue);


        /// <summary>
        ///   System.Void ReplaceMoveDirection(PBProto.MoveDirectionType newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.MoveDirectionType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMoveDirection")]
        ///  extern void REPLACE_MOVE_DIRECTION (PBProto.MoveDirectionType newValue);


        /// <summary>
        ///   System.Void ReplaceMoveDirectionListener(System.Collections.Generic.List<IMoveDirectionListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IMoveDirectionListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMoveDirectionListener")]
        ///  extern void REPLACE_MOVE_DIRECTION_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMoveSpeed(System.Int32 newIndex, SimpleFixMath.Fix newValue, System.Int32 newItemCount)
        /// </summary>
        /// <param name="newIndex">struct System.Int32</param>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <param name="newItemCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMoveSpeed")]
        ///  extern void REPLACE_MOVE_SPEED (System.Int32 newIndex, SimpleFixMath.Fix newValue, System.Int32 newItemCount);


        /// <summary>
        ///   System.Void ReplaceMoveSpeedListener(System.Collections.Generic.List<IMoveSpeedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IMoveSpeedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMoveSpeedListener")]
        ///  extern void REPLACE_MOVE_SPEED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceNetHeroIndex(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceNetHeroIndex")]
        ///  extern void REPLACE_NET_HERO_INDEX (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceNetState(NetState newValue)
        /// </summary>
        /// <param name="newValue">enum NetState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceNetState")]
        ///  extern void REPLACE_NET_STATE (NetState newValue);


        /// <summary>
        ///   System.Void ReplaceNetStateListener(System.Collections.Generic.List<INetStateListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<INetStateListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceNetStateListener")]
        ///  extern void REPLACE_NET_STATE_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceOwnerGridID(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOwnerGridID")]
        ///  extern void REPLACE_OWNER_GRID_ID (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void ReplaceOwnerUID(System.UInt64 newValue)
        /// </summary>
        /// <param name="newValue">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOwnerUID")]
        ///  extern void REPLACE_OWNER_UID (System.UInt64 newValue);


        /// <summary>
        ///   System.Void ReplaceParentGrids(System.Collections.Generic.List<SimpleFixMath.FixVector2> newList)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<SimpleFixMath.FixVector2></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceParentGrids")]
        ///  extern void REPLACE_PARENT_GRIDS (nint newList);


        /// <summary>
        ///   System.Void ReplacePhasingPeriod(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePhasingPeriod")]
        ///  extern void REPLACE_PHASING_PERIOD (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void ReplacePickType(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePickType")]
        ///  extern void REPLACE_PICK_TYPE (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.Void ReplacePickTypeListener(System.Collections.Generic.List<IPickTypeListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPickTypeListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePickTypeListener")]
        ///  extern void REPLACE_PICK_TYPE_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplacePosition(SimpleFixMath.FixVector2 newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePosition")]
        ///  extern void REPLACE_POSITION (SimpleFixMath.FixVector2 newValue);


        /// <summary>
        ///   System.Void ReplacePositionListener(System.Collections.Generic.List<IPositionListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPositionListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePositionListener")]
        ///  extern void REPLACE_POSITION_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplacePowerHitGrids(System.Collections.Generic.Dictionary<PBProto.MoveDirectionType,System.Collections.Generic.List<SimpleFixMath.FixVector2>> newDict)
        /// </summary>
        /// <param name="newDict">class System.Collections.Generic.Dictionary<PBProto.MoveDirectionType,System.Collections.Generic.List<SimpleFixMath.FixVector2>></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePowerHitGrids")]
        ///  extern void REPLACE_POWER_HIT_GRIDS (nint newDict);


        /// <summary>
        ///   System.Void ReplacePushTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePushTime")]
        ///  extern void REPLACE_PUSH_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void ReplaceRandom(System.Random newValue)
        /// </summary>
        /// <param name="newValue">class System.Random</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRandom")]
        ///  extern void REPLACE_RANDOM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceRelifeCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRelifeCount")]
        ///  extern void REPLACE_RELIFE_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceRelifeInfo(SimpleFixMath.Fix newTime, SimpleFixMath.FixVector2 newGridID)
        /// </summary>
        /// <param name="newTime">struct SimpleFixMath.Fix</param>
        /// <param name="newGridID">struct SimpleFixMath.FixVector2</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRelifeInfo")]
        ///  extern void REPLACE_RELIFE_INFO (SimpleFixMath.Fix newTime, SimpleFixMath.FixVector2 newGridID);


        /// <summary>
        ///   System.Void ReplaceRelifeWaitTime(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRelifeWaitTime")]
        ///  extern void REPLACE_RELIFE_WAIT_TIME (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceRoleState(RoleState newValue)
        /// </summary>
        /// <param name="newValue">enum RoleState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRoleState")]
        ///  extern void REPLACE_ROLE_STATE (RoleState newValue);


        /// <summary>
        ///   System.Void ReplaceRoleStateListener(System.Collections.Generic.List<IRoleStateListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IRoleStateListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRoleStateListener")]
        ///  extern void REPLACE_ROLE_STATE_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceRootParent(System.Int32 newIndex)
        /// </summary>
        /// <param name="newIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRootParent")]
        ///  extern void REPLACE_ROOT_PARENT (System.Int32 newIndex);


        /// <summary>
        ///   System.Void ReplaceSonGrids(System.Collections.Generic.List<SimpleFixMath.FixVector2> newList)
        /// </summary>
        /// <param name="newList">class System.Collections.Generic.List<SimpleFixMath.FixVector2></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSonGrids")]
        ///  extern void REPLACE_SON_GRIDS (nint newList);


        /// <summary>
        ///   System.Void ReplaceStatisData(System.Int32 newKillCount, System.Int32 newRescueCount, System.Int32 newDeadCount, System.Int32 newCombKillTimes, System.Int32 newMoveGridCount)
        /// </summary>
        /// <param name="newKillCount">struct System.Int32</param>
        /// <param name="newRescueCount">struct System.Int32</param>
        /// <param name="newDeadCount">struct System.Int32</param>
        /// <param name="newCombKillTimes">struct System.Int32</param>
        /// <param name="newMoveGridCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceStatisData")]
        ///  extern void REPLACE_STATIS_DATA (System.Int32 newKillCount, System.Int32 newRescueCount, System.Int32 newDeadCount, System.Int32 newCombKillTimes, System.Int32 newMoveGridCount);


        /// <summary>
        ///   System.Void ReplaceStatisDataListener(System.Collections.Generic.List<IStatisDataListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IStatisDataListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceStatisDataListener")]
        ///  extern void REPLACE_STATIS_DATA_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceStoneCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceStoneCount")]
        ///  extern void REPLACE_STONE_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceStoneCountListener(System.Collections.Generic.List<IStoneCountListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IStoneCountListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceStoneCountListener")]
        ///  extern void REPLACE_STONE_COUNT_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTeam")]
        ///  extern void REPLACE_TEAM (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.Void ReplaceTimerBomb(System.Int32 newCountDown)
        /// </summary>
        /// <param name="newCountDown">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTimerBomb")]
        ///  extern void REPLACE_TIMER_BOMB (System.Int32 newCountDown);


        /// <summary>
        ///   System.Void ReplaceTimerBombListener(System.Collections.Generic.List<ITimerBombListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<ITimerBombListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTimerBombListener")]
        ///  extern void REPLACE_TIMER_BOMB_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTimerService(ITimer newInstance)
        /// </summary>
        /// <param name="newInstance">interface ITimer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTimerService")]
        ///  extern void REPLACE_TIMER_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void ReplaceTransparentBombEndTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTransparentBombEndTime")]
        ///  extern void REPLACE_TRANSPARENT_BOMB_END_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void ReplaceTrappedCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTrappedCount")]
        ///  extern void REPLACE_TRAPPED_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceTrappedEndTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTrappedEndTime")]
        ///  extern void REPLACE_TRAPPED_END_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   System.Void ReplaceTreasureData(System.Int32 newRedGemCount, System.Int32 newYellowGemCount, System.Int32 newGreenGemCount, ItemType newLastPickItem)
        /// </summary>
        /// <param name="newRedGemCount">struct System.Int32</param>
        /// <param name="newYellowGemCount">struct System.Int32</param>
        /// <param name="newGreenGemCount">struct System.Int32</param>
        /// <param name="newLastPickItem">enum ItemType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTreasureData")]
        ///  extern void REPLACE_TREASURE_DATA (System.Int32 newRedGemCount, System.Int32 newYellowGemCount, System.Int32 newGreenGemCount, ItemType newLastPickItem);


        /// <summary>
        ///   System.Void ReplaceTreasureDataListener(System.Collections.Generic.List<ITreasureDataListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<ITreasureDataListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTreasureDataListener")]
        ///  extern void REPLACE_TREASURE_DATA_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTreasureGemLeader(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTreasureGemLeader")]
        ///  extern void REPLACE_TREASURE_GEM_LEADER (System.Boolean newValue);


        /// <summary>
        ///   System.Void ReplaceTreasureGemLeaderListener(System.Collections.Generic.List<ITreasureGemLeaderListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<ITreasureGemLeaderListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTreasureGemLeaderListener")]
        ///  extern void REPLACE_TREASURE_GEM_LEADER_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTryBomb(TryBombStatus newStatus)
        /// </summary>
        /// <param name="newStatus">enum TryBombStatus</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTryBomb")]
        ///  extern void REPLACE_TRY_BOMB (TryBombStatus newStatus);


        /// <summary>
        ///   System.Void ReplaceTwoTeamMatch(PBProto.TeamEnum newTeam1, PBProto.TeamEnum newTeam2)
        /// </summary>
        /// <param name="newTeam1">enum PBProto.TeamEnum</param>
        /// <param name="newTeam2">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTwoTeamMatch")]
        ///  extern void REPLACE_TWO_TEAM_MATCH (PBProto.TeamEnum newTeam1, PBProto.TeamEnum newTeam2);


        /// <summary>
        ///   System.Void ReplaceUID(System.UInt64 newValue)
        /// </summary>
        /// <param name="newValue">struct System.UInt64</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUID")]
        ///  extern void REPLACE_UID (System.UInt64 newValue);


        /// <summary>
        ///   System.Void ReplaceUnexplodeBomb(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnexplodeBomb")]
        ///  extern void REPLACE_UNEXPLODE_BOMB (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceUnitType(UnitType newValue)
        /// </summary>
        /// <param name="newValue">enum UnitType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnitType")]
        ///  extern void REPLACE_UNIT_TYPE (UnitType newValue);


        /// <summary>
        ///   System.Void ReplaceUseBagNum(PBProto.UseBagNum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.UseBagNum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUseBagNum")]
        ///  extern void REPLACE_USE_BAG_NUM (PBProto.UseBagNum newValue);


        /// <summary>
        ///   System.Void ReplaceUsedItemID(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUsedItemID")]
        ///  extern void REPLACE_USED_ITEM_ID (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceView(IView newInstance)
        /// </summary>
        /// <param name="newInstance">interface IView</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceView")]
        ///  extern void REPLACE_VIEW (nint newInstance);


        /// <summary>
        ///   System.Void ReplaceViewField(System.Int32[,] newArr)
        /// </summary>
        /// <param name="newArr">class System.Int32[,]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceViewField")]
        ///  extern void REPLACE_VIEW_FIELD (nint newArr);


        /// <summary>
        ///   System.Void ReplaceWinnerTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWinnerTeam")]
        ///  extern void REPLACE_WINNER_TEAM (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.Void Retain(System.Object owner)
        /// </summary>
        /// <param name="owner">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Retain")]
        ///  extern void RETAIN (nint owner);


        /// <summary>
        ///   System.Void set_isDestroyed(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDestroyed")]
        ///  extern void SET_IS_DESTROYED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isMainPlayer(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isMainPlayer")]
        ///  extern void SET_IS_MAIN_PLAYER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isMaxBomb(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isMaxBomb")]
        ///  extern void SET_IS_MAX_BOMB (System.Boolean value);


        /// <summary>
        ///   System.Void set_isMaxBombPower(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isMaxBombPower")]
        ///  extern void SET_IS_MAX_BOMB_POWER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isMaxShooes(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isMaxShooes")]
        ///  extern void SET_IS_MAX_SHOOES (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPhasing(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPhasing")]
        ///  extern void SET_IS_PHASING (System.Boolean value);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();




        /// public static partial class Search_GameEntity
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}