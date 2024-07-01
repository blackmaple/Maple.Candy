
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
    /// class ["Assembly-CSharp.dll".""."GameContext"]
    /// [Entitas.Context<GameEntity>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x020002ACU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [71, 97, 109, 101, 67, 111, 110, 116, 101, 120, 116])]


    // class 0x10 Entitas.ContextEntityChanged OnEntityCreated
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityCreated", "ON_ENTITY_CREATED")]

    // class 0x18 Entitas.ContextEntityChanged OnEntityWillBeDestroyed
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityWillBeDestroyed", "ON_ENTITY_WILL_BE_DESTROYED")]

    // class 0x20 Entitas.ContextEntityChanged OnEntityDestroyed
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityDestroyed", "ON_ENTITY_DESTROYED")]

    // class 0x28 Entitas.ContextGroupChanged OnGroupCreated
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnGroupCreated", "ON_GROUP_CREATED")]

    // struct 0x30 System.Int32 _totalComponents
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_totalComponents", "_TOTAL_COMPONENTS")]

    // class 0x38 System.Collections.Generic.Stack<Entitas.IComponent>[] _componentPools
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentPools", "_COMPONENT_POOLS")]

    // class 0x40 Entitas.ContextInfo _contextInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_contextInfo", "_CONTEXT_INFO")]

    // class 0x48 System.Func<Entitas.IEntity,Entitas.IAERC> _aercFactory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_aercFactory", "_AERC_FACTORY")]

    // class 0x50 System.Func<GameEntity> _entityFactory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityFactory", "_ENTITY_FACTORY")]

    // class 0x58 System.Collections.Generic.HashSet<GameEntity> _entities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entities", "_ENTITIES")]

    // class 0x60 System.Collections.Generic.Stack<GameEntity> _reusableEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_reusableEntities", "_REUSABLE_ENTITIES")]

    // class 0x68 System.Collections.Generic.HashSet<GameEntity> _retainedEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_retainedEntities", "_RETAINED_ENTITIES")]

    // class 0x70 System.Collections.Generic.Dictionary<Entitas.IMatcher<GameEntity>,Entitas.IGroup<GameEntity>> _groups
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groups", "_GROUPS")]

    // class 0x78 System.Collections.Generic.List<Entitas.IGroup<GameEntity>>[] _groupsForIndex
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupsForIndex", "_GROUPS_FOR_INDEX")]

    // class 0x80 DesperateDevs.Utils.ObjectPool<System.Collections.Generic.List<Entitas.GroupChanged<GameEntity>>> _groupChangedListPool
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupChangedListPool", "_GROUP_CHANGED_LIST_POOL")]

    // class 0x88 System.Collections.Generic.Dictionary<System.String,Entitas.IEntityIndex> _entityIndices
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityIndices", "_ENTITY_INDICES")]

    // struct 0x90 System.Int32 _creationIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_creationIndex", "_CREATION_INDEX")]

    // class 0x98 GameEntity[] _entitiesCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entitiesCache", "_ENTITIES_CACHE")]

    // class 0xA0 Entitas.EntityComponentChanged _cachedEntityChanged
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_cachedEntityChanged", "_CACHED_ENTITY_CHANGED")]

    // class 0xA8 Entitas.EntityComponentReplaced _cachedComponentReplaced
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_cachedComponentReplaced", "_CACHED_COMPONENT_REPLACED")]

    // class 0xB0 Entitas.EntityEvent _cachedEntityReleased
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_cachedEntityReleased", "_CACHED_ENTITY_RELEASED")]

    // class 0xB8 Entitas.EntityEvent _cachedDestroyEntity
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_cachedDestroyEntity", "_CACHED_DESTROY_ENTITY")]
    public partial class GameContext
    {
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GameContext";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 67, 111, 110, 116, 101, 120, 116];

        //public const uint Const_TypeToken = 0x020002ACU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameContext(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameContext(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameContext obj) => obj._ptr;
            public static implicit operator bool(Ptr_GameContext obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."GameContext"]
    /// </summary>
    public partial class GameContext
    {



        /// <summary>
        ///   System.Void add_OnEntityCreated(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityCreated")]
        ///  extern void ADD_ON_ENTITY_CREATED (nint value);


        /// <summary>
        ///   System.Void add_OnEntityDestroyed(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityDestroyed")]
        ///  extern void ADD_ON_ENTITY_DESTROYED (nint value);


        /// <summary>
        ///   System.Void add_OnEntityWillBeDestroyed(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityWillBeDestroyed")]
        ///  extern void ADD_ON_ENTITY_WILL_BE_DESTROYED (nint value);


        /// <summary>
        ///   System.Void add_OnGroupCreated(Entitas.ContextGroupChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextGroupChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnGroupCreated")]
        ///  extern void ADD_ON_GROUP_CREATED (nint value);


        /// <summary>
        ///   System.Void AddEntityIndex(Entitas.IEntityIndex entityIndex)
        /// </summary>
        /// <param name="entityIndex">interface Entitas.IEntityIndex</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEntityIndex")]
        ///  extern void ADD_ENTITY_INDEX (nint entityIndex);


        /// <summary>
        ///   System.Void ClearComponentPool(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearComponentPool")]
        ///  extern void CLEAR_COMPONENT_POOL (System.Int32 index);


        /// <summary>
        ///   System.Void ClearComponentPools()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearComponentPools")]
        ///  extern void CLEAR_COMPONENT_POOLS ();


        /// <summary>
        ///   Entitas.ContextInfo createDefaultContextInfo()
        /// </summary>
        /// <returns>class Entitas.ContextInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("createDefaultContextInfo")]
        ///  extern nint CREATE_DEFAULT_CONTEXT_INFO ();


        /// <summary>
        ///   GameEntity CreateEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateEntity")]
        ///  extern nint CREATE_ENTITY ();


        /// <summary>
        ///   System.Void DestroyAllEntities()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyAllEntities")]
        ///  extern void DESTROY_ALL_ENTITIES ();


        /// <summary>
        ///   AudioServiceComponent get_audioService()
        /// </summary>
        /// <returns>class AudioServiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_audioService")]
        ///  extern nint GET_AUDIO_SERVICE ();


        /// <summary>
        ///   GameEntity get_audioServiceEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_audioServiceEntity")]
        ///  extern nint GET_AUDIO_SERVICE_ENTITY ();


        /// <summary>
        ///   BattleModeComponent get_battleMode()
        /// </summary>
        /// <returns>class BattleModeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_battleMode")]
        ///  extern nint GET_BATTLE_MODE ();


        /// <summary>
        ///   GameEntity get_battleModeEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_battleModeEntity")]
        ///  extern nint GET_BATTLE_MODE_ENTITY ();


        /// <summary>
        ///   BlowUpFlamesComponent get_blowUpFlames()
        /// </summary>
        /// <returns>class BlowUpFlamesComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_blowUpFlames")]
        ///  extern nint GET_BLOW_UP_FLAMES ();


        /// <summary>
        ///   GameEntity get_blowUpFlamesEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_blowUpFlamesEntity")]
        ///  extern nint GET_BLOW_UP_FLAMES_ENTITY ();


        /// <summary>
        ///   BombsComponent get_bombs()
        /// </summary>
        /// <returns>class BombsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombs")]
        ///  extern nint GET_BOMBS ();


        /// <summary>
        ///   GameEntity get_bombsEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bombsEntity")]
        ///  extern nint GET_BOMBS_ENTITY ();


        /// <summary>
        ///   BuildingsComponent get_buildings()
        /// </summary>
        /// <returns>class BuildingsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_buildings")]
        ///  extern nint GET_BUILDINGS ();


        /// <summary>
        ///   GameEntity get_buildingsEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_buildingsEntity")]
        ///  extern nint GET_BUILDINGS_ENTITY ();


        /// <summary>
        ///   CatchCatCountComponent get_catchCatCount()
        /// </summary>
        /// <returns>class CatchCatCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_catchCatCount")]
        ///  extern nint GET_CATCH_CAT_COUNT ();


        /// <summary>
        ///   GameEntity get_catchCatCountEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_catchCatCountEntity")]
        ///  extern nint GET_CATCH_CAT_COUNT_ENTITY ();


        /// <summary>
        ///   System.Collections.Generic.Stack<Entitas.IComponent>[] get_componentPools()
        /// </summary>
        /// <returns>class System.Collections.Generic.Stack<Entitas.IComponent>[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_componentPools")]
        ///  extern nint GET_COMPONENT_POOLS ();


        /// <summary>
        ///   ConfigServiceComponent get_configService()
        /// </summary>
        /// <returns>class ConfigServiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_configService")]
        ///  extern nint GET_CONFIG_SERVICE ();


        /// <summary>
        ///   GameEntity get_configServiceEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_configServiceEntity")]
        ///  extern nint GET_CONFIG_SERVICE_ENTITY ();


        /// <summary>
        ///   Entitas.ContextInfo get_contextInfo()
        /// </summary>
        /// <returns>class Entitas.ContextInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_contextInfo")]
        ///  extern nint GET_CONTEXT_INFO ();


        /// <summary>
        ///   System.Int32 get_count()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_count")]
        ///  extern System.Int32 GET_COUNT ();


        /// <summary>
        ///   EnablePassWallComponent get_enablePassWall()
        /// </summary>
        /// <returns>class EnablePassWallComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_enablePassWall")]
        ///  extern nint GET_ENABLE_PASS_WALL ();


        /// <summary>
        ///   GameEntity get_enablePassWallEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_enablePassWallEntity")]
        ///  extern nint GET_ENABLE_PASS_WALL_ENTITY ();


        /// <summary>
        ///   EntityFactoryServiceComponent get_entityFactoryService()
        /// </summary>
        /// <returns>class EntityFactoryServiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_entityFactoryService")]
        ///  extern nint GET_ENTITY_FACTORY_SERVICE ();


        /// <summary>
        ///   GameEntity get_entityFactoryServiceEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_entityFactoryServiceEntity")]
        ///  extern nint GET_ENTITY_FACTORY_SERVICE_ENTITY ();


        /// <summary>
        ///   FirstKillToWinTeamComponent get_firstKillToWinTeam()
        /// </summary>
        /// <returns>class FirstKillToWinTeamComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_firstKillToWinTeam")]
        ///  extern nint GET_FIRST_KILL_TO_WIN_TEAM ();


        /// <summary>
        ///   GameEntity get_firstKillToWinTeamEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_firstKillToWinTeamEntity")]
        ///  extern nint GET_FIRST_KILL_TO_WIN_TEAM_ENTITY ();


        /// <summary>
        ///   FlamesComponent get_flames()
        /// </summary>
        /// <returns>class FlamesComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_flames")]
        ///  extern nint GET_FLAMES ();


        /// <summary>
        ///   GameEntity get_flamesEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_flamesEntity")]
        ///  extern nint GET_FLAMES_ENTITY ();


        /// <summary>
        ///   GameFrameComponent get_gameFrame()
        /// </summary>
        /// <returns>class GameFrameComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameFrame")]
        ///  extern nint GET_GAME_FRAME ();


        /// <summary>
        ///   GameEntity get_gameFrameEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameFrameEntity")]
        ///  extern nint GET_GAME_FRAME_ENTITY ();


        /// <summary>
        ///   GameProgressComponent get_gameProgress()
        /// </summary>
        /// <returns>class GameProgressComponent</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameProgress")]
        extern GameProgressComponent.Ptr_GameProgressComponent GET_GAME_PROGRESS();


        /// <summary>
        ///   GameEntity get_gameProgressEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameProgressEntity")]
        ///  extern nint GET_GAME_PROGRESS_ENTITY ();


        /// <summary>
        ///   GameResultComponent get_gameResult()
        /// </summary>
        /// <returns>class GameResultComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameResult")]
        ///  extern nint GET_GAME_RESULT ();


        /// <summary>
        ///   GameEntity get_gameResultEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameResultEntity")]
        ///  extern nint GET_GAME_RESULT_ENTITY ();


        /// <summary>
        ///   GameTimeComponent get_gameTime()
        /// </summary>
        /// <returns>class GameTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameTime")]
        ///  extern nint GET_GAME_TIME ();


        /// <summary>
        ///   GameEntity get_gameTimeEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameTimeEntity")]
        ///  extern nint GET_GAME_TIME_ENTITY ();


        /// <summary>
        ///   GameTotalSecComponent get_gameTotalSec()
        /// </summary>
        /// <returns>class GameTotalSecComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameTotalSec")]
        ///  extern nint GET_GAME_TOTAL_SEC ();


        /// <summary>
        ///   GameEntity get_gameTotalSecEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameTotalSecEntity")]
        ///  extern nint GET_GAME_TOTAL_SEC_ENTITY ();


        /// <summary>
        ///   GemMaxScoreComponent get_gemMaxScore()
        /// </summary>
        /// <returns>class GemMaxScoreComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gemMaxScore")]
        ///  extern nint GET_GEM_MAX_SCORE ();


        /// <summary>
        ///   GameEntity get_gemMaxScoreEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gemMaxScoreEntity")]
        ///  extern nint GET_GEM_MAX_SCORE_ENTITY ();


        /// <summary>
        ///   System.Boolean get_hasAudioService()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAudioService")]
        ///  extern System.Boolean GET_HAS_AUDIO_SERVICE ();


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
        ///   System.Boolean get_hasBombs()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBombs")]
        ///  extern System.Boolean GET_HAS_BOMBS ();


        /// <summary>
        ///   System.Boolean get_hasBuildings()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBuildings")]
        ///  extern System.Boolean GET_HAS_BUILDINGS ();


        /// <summary>
        ///   System.Boolean get_hasCatchCatCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCatchCatCount")]
        ///  extern System.Boolean GET_HAS_CATCH_CAT_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasConfigService()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasConfigService")]
        ///  extern System.Boolean GET_HAS_CONFIG_SERVICE ();


        /// <summary>
        ///   System.Boolean get_hasEnablePassWall()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEnablePassWall")]
        ///  extern System.Boolean GET_HAS_ENABLE_PASS_WALL ();


        /// <summary>
        ///   System.Boolean get_hasEntityFactoryService()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEntityFactoryService")]
        ///  extern System.Boolean GET_HAS_ENTITY_FACTORY_SERVICE ();


        /// <summary>
        ///   System.Boolean get_hasFirstKillToWinTeam()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFirstKillToWinTeam")]
        ///  extern System.Boolean GET_HAS_FIRST_KILL_TO_WIN_TEAM ();


        /// <summary>
        ///   System.Boolean get_hasFlames()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFlames")]
        ///  extern System.Boolean GET_HAS_FLAMES ();


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
        ///   System.Boolean get_hasHeroArr()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHeroArr")]
        ///  extern System.Boolean GET_HAS_HERO_ARR ();


        /// <summary>
        ///   System.Boolean get_hasInputService()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInputService")]
        ///  extern System.Boolean GET_HAS_INPUT_SERVICE ();


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
        ///   System.Boolean get_hasRandom()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRandom")]
        ///  extern System.Boolean GET_HAS_RANDOM ();


        /// <summary>
        ///   System.Boolean get_hasRelifeWaitTime()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRelifeWaitTime")]
        ///  extern System.Boolean GET_HAS_RELIFE_WAIT_TIME ();


        /// <summary>
        ///   System.Boolean get_hasTimerService()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTimerService")]
        ///  extern System.Boolean GET_HAS_TIMER_SERVICE ();


        /// <summary>
        ///   System.Boolean get_hasTwoTeamMatch()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTwoTeamMatch")]
        ///  extern System.Boolean GET_HAS_TWO_TEAM_MATCH ();


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
        ///   GameEntity get_heroArrEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_heroArrEntity")]
        ///  extern nint GET_HERO_ARR_ENTITY ();


        /// <summary>
        ///   InputServiceComponent get_inputService()
        /// </summary>
        /// <returns>class InputServiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputService")]
        ///  extern nint GET_INPUT_SERVICE ();


        /// <summary>
        ///   GameEntity get_inputServiceEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputServiceEntity")]
        ///  extern nint GET_INPUT_SERVICE_ENTITY ();


        /// <summary>
        ///   ItemBirdComponent get_itemBird()
        /// </summary>
        /// <returns>class ItemBirdComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_itemBird")]
        ///  extern nint GET_ITEM_BIRD ();


        /// <summary>
        ///   GameEntity get_itemBirdEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_itemBirdEntity")]
        ///  extern nint GET_ITEM_BIRD_ENTITY ();


        /// <summary>
        ///   ItemsComponent get_items()
        /// </summary>
        /// <returns>class ItemsComponent</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_items")]
        extern ItemsComponent.Ptr_ItemsComponent GET_ITEMS();


        /// <summary>
        ///   GameEntity get_itemsEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_itemsEntity")]
        ///  extern nint GET_ITEMS_ENTITY ();


        /// <summary>
        ///   LastKillTeamComponent get_lastKillTeam()
        /// </summary>
        /// <returns>class LastKillTeamComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastKillTeam")]
        ///  extern nint GET_LAST_KILL_TEAM ();


        /// <summary>
        ///   GameEntity get_lastKillTeamEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastKillTeamEntity")]
        ///  extern nint GET_LAST_KILL_TEAM_ENTITY ();


        /// <summary>
        ///   LastPickPointComponent get_lastPickPoint()
        /// </summary>
        /// <returns>class LastPickPointComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastPickPoint")]
        ///  extern nint GET_LAST_PICK_POINT ();


        /// <summary>
        ///   GameEntity get_lastPickPointEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastPickPointEntity")]
        ///  extern nint GET_LAST_PICK_POINT_ENTITY ();


        /// <summary>
        ///   LocalBombsComponent get_localBombs()
        /// </summary>
        /// <returns>class LocalBombsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localBombs")]
        ///  extern nint GET_LOCAL_BOMBS ();


        /// <summary>
        ///   GameEntity get_localBombsEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localBombsEntity")]
        ///  extern nint GET_LOCAL_BOMBS_ENTITY ();


        /// <summary>
        ///   LocalPlayersComponent get_localPlayers()
        /// </summary>
        /// <returns>class LocalPlayersComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localPlayers")]
        ///  extern nint GET_LOCAL_PLAYERS ();


        /// <summary>
        ///   GameEntity get_localPlayersEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localPlayersEntity")]
        ///  extern nint GET_LOCAL_PLAYERS_ENTITY ();


        /// <summary>
        ///   LogicDTComponent get_logicDT()
        /// </summary>
        /// <returns>class LogicDTComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_logicDT")]
        ///  extern nint GET_LOGIC_DT ();


        /// <summary>
        ///   GameEntity get_logicDTEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_logicDTEntity")]
        ///  extern nint GET_LOGIC_DT_ENTITY ();


        /// <summary>
        ///   MainPlayerInfosComponent get_mainPlayerInfos()
        /// </summary>
        /// <returns>class MainPlayerInfosComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mainPlayerInfos")]
        ///  extern nint GET_MAIN_PLAYER_INFOS ();


        /// <summary>
        ///   GameEntity get_mainPlayerInfosEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mainPlayerInfosEntity")]
        ///  extern nint GET_MAIN_PLAYER_INFOS_ENTITY ();


        /// <summary>
        ///   MapBoundsComponent get_mapBounds()
        /// </summary>
        /// <returns>class MapBoundsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapBounds")]
        ///  extern nint GET_MAP_BOUNDS ();


        /// <summary>
        ///   GameEntity get_mapBoundsEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapBoundsEntity")]
        ///  extern nint GET_MAP_BOUNDS_ENTITY ();


        /// <summary>
        ///   MapConfigComponent get_mapConfig()
        /// </summary>
        /// <returns>class MapConfigComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapConfig")]
        ///  extern nint GET_MAP_CONFIG ();


        /// <summary>
        ///   GameEntity get_mapConfigEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapConfigEntity")]
        ///  extern nint GET_MAP_CONFIG_ENTITY ();


        /// <summary>
        ///   MapElemsComponent get_mapElems()
        /// </summary>
        /// <returns>class MapElemsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapElems")]
        ///  extern nint GET_MAP_ELEMS ();


        /// <summary>
        ///   GameEntity get_mapElemsEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapElemsEntity")]
        ///  extern nint GET_MAP_ELEMS_ENTITY ();


        /// <summary>
        ///   MapGridsComponent get_mapGrids()
        /// </summary>
        /// <returns>class MapGridsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapGrids")]
        ///  extern nint GET_MAP_GRIDS ();


        /// <summary>
        ///   GameEntity get_mapGridsEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapGridsEntity")]
        ///  extern nint GET_MAP_GRIDS_ENTITY ();


        /// <summary>
        ///   MapTypeComponent get_mapType()
        /// </summary>
        /// <returns>class MapTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapType")]
        ///  extern nint GET_MAP_TYPE ();


        /// <summary>
        ///   GameEntity get_mapTypeEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapTypeEntity")]
        ///  extern nint GET_MAP_TYPE_ENTITY ();


        /// <summary>
        ///   RandomComponent get_random()
        /// </summary>
        /// <returns>class RandomComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_random")]
        ///  extern nint GET_RANDOM ();


        /// <summary>
        ///   GameEntity get_randomEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_randomEntity")]
        ///  extern nint GET_RANDOM_ENTITY ();


        /// <summary>
        ///   RelifeWaitTimeComponent get_relifeWaitTime()
        /// </summary>
        /// <returns>class RelifeWaitTimeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_relifeWaitTime")]
        ///  extern nint GET_RELIFE_WAIT_TIME ();


        /// <summary>
        ///   GameEntity get_relifeWaitTimeEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_relifeWaitTimeEntity")]
        ///  extern nint GET_RELIFE_WAIT_TIME_ENTITY ();


        /// <summary>
        ///   System.Int32 get_retainedEntitiesCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_retainedEntitiesCount")]
        ///  extern System.Int32 GET_RETAINED_ENTITIES_COUNT ();


        /// <summary>
        ///   System.Int32 get_reusableEntitiesCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reusableEntitiesCount")]
        ///  extern System.Int32 GET_REUSABLE_ENTITIES_COUNT ();


        /// <summary>
        ///   TimerServiceComponent get_timerService()
        /// </summary>
        /// <returns>class TimerServiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_timerService")]
        ///  extern nint GET_TIMER_SERVICE ();


        /// <summary>
        ///   GameEntity get_timerServiceEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_timerServiceEntity")]
        ///  extern nint GET_TIMER_SERVICE_ENTITY ();


        /// <summary>
        ///   System.Int32 get_totalComponents()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_totalComponents")]
        ///  extern System.Int32 GET_TOTAL_COMPONENTS ();


        /// <summary>
        ///   TwoTeamMatchComponent get_twoTeamMatch()
        /// </summary>
        /// <returns>class TwoTeamMatchComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_twoTeamMatch")]
        ///  extern nint GET_TWO_TEAM_MATCH ();


        /// <summary>
        ///   GameEntity get_twoTeamMatchEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_twoTeamMatchEntity")]
        ///  extern nint GET_TWO_TEAM_MATCH_ENTITY ();


        /// <summary>
        ///   ViewFieldComponent get_viewField()
        /// </summary>
        /// <returns>class ViewFieldComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_viewField")]
        ///  extern nint GET_VIEW_FIELD ();


        /// <summary>
        ///   GameEntity get_viewFieldEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_viewFieldEntity")]
        ///  extern nint GET_VIEW_FIELD_ENTITY ();


        /// <summary>
        ///   WinnerTeamComponent get_winnerTeam()
        /// </summary>
        /// <returns>class WinnerTeamComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_winnerTeam")]
        ///  extern nint GET_WINNER_TEAM ();


        /// <summary>
        ///   GameEntity get_winnerTeamEntity()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_winnerTeamEntity")]
        ///  extern nint GET_WINNER_TEAM_ENTITY ();


        /// <summary>
        ///   GameEntity[] GetEntities()
        /// </summary>
        /// <returns>class GameEntity[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntities")]
        ///  extern nint GET_ENTITIES ();


        /// <summary>
        ///   Entitas.IEntityIndex GetEntityIndex(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>interface Entitas.IEntityIndex</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityIndex")]
        ///  extern nint GET_ENTITY_INDEX (nint name);


        /// <summary>
        ///   Entitas.IGroup<GameEntity> GetGroup(Entitas.IMatcher<GameEntity> matcher)
        /// </summary>
        /// <param name="matcher">interface Entitas.IMatcher<GameEntity></param>
        /// <returns>interface Entitas.IGroup<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGroup")]
        ///  extern nint GET_GROUP (nint matcher);


        /// <summary>
        ///   System.Boolean HasEntity(GameEntity entity)
        /// </summary>
        /// <param name="entity">class GameEntity</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasEntity")]
        ///  extern System.Boolean HAS_ENTITY (nint entity);


        /// <summary>
        ///   System.Void onDestroyEntity(Entitas.IEntity entity)
        /// </summary>
        /// <param name="entity">interface Entitas.IEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("onDestroyEntity")]
        ///  extern void ON_DESTROY_ENTITY (nint entity);


        /// <summary>
        ///   System.Void onEntityReleased(Entitas.IEntity entity)
        /// </summary>
        /// <param name="entity">interface Entitas.IEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("onEntityReleased")]
        ///  extern void ON_ENTITY_RELEASED (nint entity);


        /// <summary>
        ///   System.Void remove_OnEntityCreated(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityCreated")]
        ///  extern void REMOVE_ON_ENTITY_CREATED (nint value);


        /// <summary>
        ///   System.Void remove_OnEntityDestroyed(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityDestroyed")]
        ///  extern void REMOVE_ON_ENTITY_DESTROYED (nint value);


        /// <summary>
        ///   System.Void remove_OnEntityWillBeDestroyed(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityWillBeDestroyed")]
        ///  extern void REMOVE_ON_ENTITY_WILL_BE_DESTROYED (nint value);


        /// <summary>
        ///   System.Void remove_OnGroupCreated(Entitas.ContextGroupChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextGroupChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnGroupCreated")]
        ///  extern void REMOVE_ON_GROUP_CREATED (nint value);


        /// <summary>
        ///   System.Void RemoveAllEventHandlers()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllEventHandlers")]
        ///  extern void REMOVE_ALL_EVENT_HANDLERS ();


        /// <summary>
        ///   System.Void RemoveAudioService()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAudioService")]
        ///  extern void REMOVE_AUDIO_SERVICE ();


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
        ///   System.Void RemoveBombs()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBombs")]
        ///  extern void REMOVE_BOMBS ();


        /// <summary>
        ///   System.Void RemoveBuildings()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuildings")]
        ///  extern void REMOVE_BUILDINGS ();


        /// <summary>
        ///   System.Void RemoveCatchCatCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCatchCatCount")]
        ///  extern void REMOVE_CATCH_CAT_COUNT ();


        /// <summary>
        ///   System.Void RemoveConfigService()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveConfigService")]
        ///  extern void REMOVE_CONFIG_SERVICE ();


        /// <summary>
        ///   System.Void RemoveEnablePassWall()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEnablePassWall")]
        ///  extern void REMOVE_ENABLE_PASS_WALL ();


        /// <summary>
        ///   System.Void RemoveEntityFactoryService()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEntityFactoryService")]
        ///  extern void REMOVE_ENTITY_FACTORY_SERVICE ();


        /// <summary>
        ///   System.Void RemoveFirstKillToWinTeam()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFirstKillToWinTeam")]
        ///  extern void REMOVE_FIRST_KILL_TO_WIN_TEAM ();


        /// <summary>
        ///   System.Void RemoveFlames()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFlames")]
        ///  extern void REMOVE_FLAMES ();


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
        ///   System.Void RemoveHeroArr()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHeroArr")]
        ///  extern void REMOVE_HERO_ARR ();


        /// <summary>
        ///   System.Void RemoveInputService()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInputService")]
        ///  extern void REMOVE_INPUT_SERVICE ();


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
        ///   System.Void RemoveRandom()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRandom")]
        ///  extern void REMOVE_RANDOM ();


        /// <summary>
        ///   System.Void RemoveRelifeWaitTime()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRelifeWaitTime")]
        ///  extern void REMOVE_RELIFE_WAIT_TIME ();


        /// <summary>
        ///   System.Void RemoveTimerService()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTimerService")]
        ///  extern void REMOVE_TIMER_SERVICE ();


        /// <summary>
        ///   System.Void RemoveTwoTeamMatch()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTwoTeamMatch")]
        ///  extern void REMOVE_TWO_TEAM_MATCH ();


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
        ///   System.Void ReplaceAudioService(IAudioService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IAudioService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAudioService")]
        ///  extern void REPLACE_AUDIO_SERVICE (nint newInstance);


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
        ///   System.Void ReplaceBombs(System.Collections.Generic.List<GameEntity>[,] newArr, System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newArr">class System.Collections.Generic.List<GameEntity>[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceBombs")]
        ///  extern void REPLACE_BOMBS (nint newArr, nint newList);


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
        ///   System.Void ReplaceCatchCatCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCatchCatCount")]
        ///  extern void REPLACE_CATCH_CAT_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceConfigService(IConfigService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IConfigService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceConfigService")]
        ///  extern void REPLACE_CONFIG_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void ReplaceEnablePassWall(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEnablePassWall")]
        ///  extern void REPLACE_ENABLE_PASS_WALL (System.Boolean newValue);


        /// <summary>
        ///   System.Void ReplaceEntityFactoryService(EntityFactoryService newInstance)
        /// </summary>
        /// <param name="newInstance">class EntityFactoryService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEntityFactoryService")]
        ///  extern void REPLACE_ENTITY_FACTORY_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void ReplaceFirstKillToWinTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFirstKillToWinTeam")]
        ///  extern void REPLACE_FIRST_KILL_TO_WIN_TEAM (PBProto.TeamEnum newValue);


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
        ///   System.Void ReplaceHeroArr(GameEntity[] newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHeroArr")]
        ///  extern void REPLACE_HERO_ARR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceInputService(IInputService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IInputService</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInputService")]
        ///  extern void REPLACE_INPUT_SERVICE (nint newInstance);


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
        ///   System.Void ReplaceRandom(System.Random newValue)
        /// </summary>
        /// <param name="newValue">class System.Random</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRandom")]
        ///  extern void REPLACE_RANDOM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceRelifeWaitTime(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRelifeWaitTime")]
        ///  extern void REPLACE_RELIFE_WAIT_TIME (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceTimerService(ITimer newInstance)
        /// </summary>
        /// <param name="newInstance">interface ITimer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTimerService")]
        ///  extern void REPLACE_TIMER_SERVICE (nint newInstance);


        /// <summary>
        ///   System.Void ReplaceTwoTeamMatch(PBProto.TeamEnum newTeam1, PBProto.TeamEnum newTeam2)
        /// </summary>
        /// <param name="newTeam1">enum PBProto.TeamEnum</param>
        /// <param name="newTeam2">enum PBProto.TeamEnum</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTwoTeamMatch")]
        ///  extern void REPLACE_TWO_TEAM_MATCH (PBProto.TeamEnum newTeam1, PBProto.TeamEnum newTeam2);


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
        ///   System.Void Reset()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Reset")]
        ///  extern void RESET ();


        /// <summary>
        ///   System.Void ResetCreationIndex()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetCreationIndex")]
        ///  extern void RESET_CREATION_INDEX ();


        /// <summary>
        ///   GameEntity SetAudioService(IAudioService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IAudioService</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetAudioService")]
        ///  extern nint SET_AUDIO_SERVICE (nint newInstance);


        /// <summary>
        ///   GameEntity SetBattleMode(PBProto.BattleMode newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.BattleMode</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBattleMode")]
        ///  extern nint SET_BATTLE_MODE (PBProto.BattleMode newValue);


        /// <summary>
        ///   GameEntity SetBlowUpFlames(GameEntity[,] newArr, System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newArr">class GameEntity[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBlowUpFlames")]
        ///  extern nint SET_BLOW_UP_FLAMES (nint newArr, nint newList);


        /// <summary>
        ///   GameEntity SetBombs(System.Collections.Generic.List<GameEntity>[,] newArr, System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newArr">class System.Collections.Generic.List<GameEntity>[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBombs")]
        ///  extern nint SET_BOMBS (nint newArr, nint newList);


        /// <summary>
        ///   GameEntity SetBuildings(GameEntity[,] newBunsArr, System.Collections.Generic.List<GameEntity> newBunsLst, GameEntity[,] newSculptureArr, System.Collections.Generic.List<GameEntity> newSculptureLst)
        /// </summary>
        /// <param name="newBunsArr">class GameEntity[,]</param>
        /// <param name="newBunsLst">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newSculptureArr">class GameEntity[,]</param>
        /// <param name="newSculptureLst">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBuildings")]
        ///  extern nint SET_BUILDINGS (nint newBunsArr, nint newBunsLst, nint newSculptureArr, nint newSculptureLst);


        /// <summary>
        ///   GameEntity SetCatchCatCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCatchCatCount")]
        ///  extern nint SET_CATCH_CAT_COUNT (System.Int32 newValue);


        /// <summary>
        ///   GameEntity SetConfigService(IConfigService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IConfigService</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetConfigService")]
        ///  extern nint SET_CONFIG_SERVICE (nint newInstance);


        /// <summary>
        ///   GameEntity SetEnablePassWall(System.Boolean newValue)
        /// </summary>
        /// <param name="newValue">struct System.Boolean</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEnablePassWall")]
        ///  extern nint SET_ENABLE_PASS_WALL (System.Boolean newValue);


        /// <summary>
        ///   GameEntity SetEntityFactoryService(EntityFactoryService newInstance)
        /// </summary>
        /// <param name="newInstance">class EntityFactoryService</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEntityFactoryService")]
        ///  extern nint SET_ENTITY_FACTORY_SERVICE (nint newInstance);


        /// <summary>
        ///   GameEntity SetFirstKillToWinTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFirstKillToWinTeam")]
        ///  extern nint SET_FIRST_KILL_TO_WIN_TEAM (PBProto.TeamEnum newValue);


        /// <summary>
        ///   GameEntity SetFlames(GameEntity[,] newArr, System.Collections.Generic.List<GameEntity> newList, System.Collections.Generic.List<GameEntity> newLatest_list)
        /// </summary>
        /// <param name="newArr">class GameEntity[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <param name="newLatest_list">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFlames")]
        ///  extern nint SET_FLAMES (nint newArr, nint newList, nint newLatest_list);


        /// <summary>
        ///   GameEntity SetGameFrame(System.UInt32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.UInt32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGameFrame")]
        ///  extern nint SET_GAME_FRAME (System.UInt32 newValue);


        /// <summary>
        ///   GameEntity SetGameProgress(GameProgressState newValue)
        /// </summary>
        /// <param name="newValue">enum GameProgressState</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGameProgress")]
        ///  extern nint SET_GAME_PROGRESS (GameProgressState newValue);


        /// <summary>
        ///   GameEntity SetGameResult(GameReuslt newValue, System.Collections.Generic.List<System.UInt32> newWinnerList)
        /// </summary>
        /// <param name="newValue">enum GameReuslt</param>
        /// <param name="newWinnerList">class System.Collections.Generic.List<System.UInt32></param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGameResult")]
        ///  extern nint SET_GAME_RESULT (GameReuslt newValue, nint newWinnerList);


        /// <summary>
        ///   GameEntity SetGameTime(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGameTime")]
        ///  extern nint SET_GAME_TIME (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   GameEntity SetGameTotalSec(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGameTotalSec")]
        ///  extern nint SET_GAME_TOTAL_SEC (System.Int32 newValue);


        /// <summary>
        ///   GameEntity SetGemMaxScore(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGemMaxScore")]
        ///  extern nint SET_GEM_MAX_SCORE (System.Int32 newValue);


        /// <summary>
        ///   GameEntity SetHeroArr(GameEntity[] newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity[]</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetHeroArr")]
        ///  extern nint SET_HERO_ARR (nint newValue);


        /// <summary>
        ///   GameEntity SetInputService(IInputService newInstance)
        /// </summary>
        /// <param name="newInstance">interface IInputService</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInputService")]
        ///  extern nint SET_INPUT_SERVICE (nint newInstance);


        /// <summary>
        ///   GameEntity SetItemBird(System.Collections.Generic.Queue<GameEntity> newQueue, SimpleFixMath.Fix newTimer, ItemBirdState newState)
        /// </summary>
        /// <param name="newQueue">class System.Collections.Generic.Queue<GameEntity></param>
        /// <param name="newTimer">struct SimpleFixMath.Fix</param>
        /// <param name="newState">enum ItemBirdState</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetItemBird")]
        ///  extern nint SET_ITEM_BIRD (nint newQueue, SimpleFixMath.Fix newTimer, ItemBirdState newState);


        /// <summary>
        ///   GameEntity SetItems(System.Collections.Generic.Queue<GameEntity>[,] newQueue, System.Collections.Generic.List<GameEntity> newList)
        /// </summary>
        /// <param name="newQueue">class System.Collections.Generic.Queue<GameEntity>[,]</param>
        /// <param name="newList">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetItems")]
        ///  extern nint SET_ITEMS (nint newQueue, nint newList);


        /// <summary>
        ///   GameEntity SetLastKillTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLastKillTeam")]
        ///  extern nint SET_LAST_KILL_TEAM (PBProto.TeamEnum newValue);


        /// <summary>
        ///   GameEntity SetLastPickPoint(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLastPickPoint")]
        ///  extern nint SET_LAST_PICK_POINT (PBProto.TeamEnum newValue);


        /// <summary>
        ///   GameEntity SetLocalBombs(System.Collections.Generic.List<GameEntity>[,] newArr)
        /// </summary>
        /// <param name="newArr">class System.Collections.Generic.List<GameEntity>[,]</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLocalBombs")]
        ///  extern nint SET_LOCAL_BOMBS (nint newArr);


        /// <summary>
        ///   GameEntity SetLocalPlayers(System.Collections.Generic.List<GameEntity> newLst)
        /// </summary>
        /// <param name="newLst">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLocalPlayers")]
        ///  extern nint SET_LOCAL_PLAYERS (nint newLst);


        /// <summary>
        ///   GameEntity SetLogicDT(SimpleFixMath.Fix newValue)
        /// </summary>
        /// <param name="newValue">struct SimpleFixMath.Fix</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLogicDT")]
        ///  extern nint SET_LOGIC_DT (SimpleFixMath.Fix newValue);


        /// <summary>
        ///   GameEntity SetMainPlayerInfos(GameEntity newLogicEntity, PBProto.MoveDirectionType newMoveDir, PBProto.MoveDirectionType newFaceDir, SafeVector2 newPos, UnityEngine.Vector2 newLastPos)
        /// </summary>
        /// <param name="newLogicEntity">class GameEntity</param>
        /// <param name="newMoveDir">enum PBProto.MoveDirectionType</param>
        /// <param name="newFaceDir">enum PBProto.MoveDirectionType</param>
        /// <param name="newPos">class SafeVector2</param>
        /// <param name="newLastPos">struct UnityEngine.Vector2</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMainPlayerInfos")]
        ///  extern nint SET_MAIN_PLAYER_INFOS (nint newLogicEntity, PBProto.MoveDirectionType newMoveDir, PBProto.MoveDirectionType newFaceDir, nint newPos, UnityEngine.Vector2 newLastPos);


        /// <summary>
        ///   GameEntity SetMapBounds(SimpleFixMath.FixVector2 newMax, SimpleFixMath.FixVector2 newMin)
        /// </summary>
        /// <param name="newMax">struct SimpleFixMath.FixVector2</param>
        /// <param name="newMin">struct SimpleFixMath.FixVector2</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapBounds")]
        ///  extern nint SET_MAP_BOUNDS (SimpleFixMath.FixVector2 newMax, SimpleFixMath.FixVector2 newMin);


        /// <summary>
        ///   GameEntity SetMapConfig(MapConfig newValue)
        /// </summary>
        /// <param name="newValue">class MapConfig</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapConfig")]
        ///  extern nint SET_MAP_CONFIG (nint newValue);


        /// <summary>
        ///   GameEntity SetMapElems(GameEntity[,] newWallArr, GameEntity[,] newDoorArr, System.Collections.Generic.List<GameEntity> newComposeWallList, GameEntity[,] newBrickArr, System.Collections.Generic.List<GameEntity> newBrickList, GameEntity[,] newMoveBrickArr, System.Collections.Generic.List<GameEntity> newMoveBrickList, GameEntity[,] newGrassArr, System.Collections.Generic.List<GameEntity> newGrassList)
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
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapElems")]
        ///  extern nint SET_MAP_ELEMS (nint newWallArr, nint newDoorArr, nint newComposeWallList, nint newBrickArr, nint newBrickList, nint newMoveBrickArr, nint newMoveBrickList, nint newGrassArr, nint newGrassList);


        /// <summary>
        ///   GameEntity SetMapGrids(GameEntity[,] newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity[,]</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapGrids")]
        ///  extern nint SET_MAP_GRIDS (nint newValue);


        /// <summary>
        ///   GameEntity SetMapType(PBProto.MapType newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.MapType</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapType")]
        ///  extern nint SET_MAP_TYPE (PBProto.MapType newValue);


        /// <summary>
        ///   GameEntity SetRandom(System.Random newValue)
        /// </summary>
        /// <param name="newValue">class System.Random</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetRandom")]
        ///  extern nint SET_RANDOM (nint newValue);


        /// <summary>
        ///   GameEntity SetRelifeWaitTime(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetRelifeWaitTime")]
        ///  extern nint SET_RELIFE_WAIT_TIME (System.Int32 newValue);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameContext))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Func<GameEntity> entityFactory)
        /// </summary>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="entityFactory">class System.Func<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameContext))]
        ///  extern void .CTOR_01 (System.Int32 totalComponents, nint entityFactory);


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<GameEntity> entityFactory)
        /// </summary>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="startCreationIndex">struct System.Int32</param>
        /// <param name="contextInfo">class Entitas.ContextInfo</param>
        /// <param name="aercFactory">class System.Func<Entitas.IEntity,Entitas.IAERC></param>
        /// <param name="entityFactory">class System.Func<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameContext))]
        ///  extern void .CTOR_02 (System.Int32 totalComponents, System.Int32 startCreationIndex, nint contextInfo, nint aercFactory, nint entityFactory);


        /// public static partial class Search_GameContext
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
        ///   System.Void .ctor(System.Int32 totalComponents, System.Func<GameEntity> entityFactory)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Func<GameEntity>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<GameEntity> entityFactory)
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "Entitas.ContextInfo", "System.Func<Entitas.IEntity,Entitas.IAERC>", "System.Func<GameEntity>");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["Assembly-CSharp.dll".""."GameContext"]
    /// </summary>
    public partial class GameContext
    {



        /// <summary>
        ///   GameEntity SetTimerService(ITimer newInstance)
        /// </summary>
        /// <param name="newInstance">interface ITimer</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTimerService")]
        ///  extern nint SET_TIMER_SERVICE (nint newInstance);


        /// <summary>
        ///   GameEntity SetTwoTeamMatch(PBProto.TeamEnum newTeam1, PBProto.TeamEnum newTeam2)
        /// </summary>
        /// <param name="newTeam1">enum PBProto.TeamEnum</param>
        /// <param name="newTeam2">enum PBProto.TeamEnum</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTwoTeamMatch")]
        ///  extern nint SET_TWO_TEAM_MATCH (PBProto.TeamEnum newTeam1, PBProto.TeamEnum newTeam2);


        /// <summary>
        ///   GameEntity SetViewField(System.Int32[,] newArr)
        /// </summary>
        /// <param name="newArr">class System.Int32[,]</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetViewField")]
        ///  extern nint SET_VIEW_FIELD (nint newArr);


        /// <summary>
        ///   GameEntity SetWinnerTeam(PBProto.TeamEnum newValue)
        /// </summary>
        /// <param name="newValue">enum PBProto.TeamEnum</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetWinnerTeam")]
        ///  extern nint SET_WINNER_TEAM (PBProto.TeamEnum newValue);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();


        /// <summary>
        ///   System.Void updateGroupsComponentAddedOrRemoved(Entitas.IEntity entity, System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="entity">interface Entitas.IEntity</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("updateGroupsComponentAddedOrRemoved")]
        ///  extern void UPDATE_GROUPS_COMPONENT_ADDED_OR_REMOVED (nint entity, System.Int32 index, nint component);


        /// <summary>
        ///   System.Void updateGroupsComponentReplaced(Entitas.IEntity entity, System.Int32 index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent)
        /// </summary>
        /// <param name="entity">interface Entitas.IEntity</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="previousComponent">interface Entitas.IComponent</param>
        /// <param name="newComponent">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("updateGroupsComponentReplaced")]
        ///  extern void UPDATE_GROUPS_COMPONENT_REPLACED (nint entity, System.Int32 index, nint previousComponent, nint newComponent);




        /// public static partial class Search_GameContext
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}