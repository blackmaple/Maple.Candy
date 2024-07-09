using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System.Diagnostics.CodeAnalysis;

namespace Maple.Candy
{
    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]

    [MonoCollectorType(typeof(BattleSystem))]
    [MonoCollectorType(typeof(FightManager))]
    [MonoCollectorType(typeof(GameContext))]
    [MonoCollectorType(typeof(GameProgressComponent))]

    [MonoCollectorType(typeof(GameEntity))]

    [MonoCollectorType(typeof(GameRoot))]

    [MonoCollectorType(typeof(ViewManager))]
    [MonoCollectorType(typeof(ItemsComponent))]
    [MonoCollectorType(typeof(ItemStateListenerComponent))]
    [MonoCollectorType(typeof(ItemView))]



    [MonoCollectorType(typeof(PlayerPrefsEx))]
    [MonoCollectorType(typeof(PlayerPrefs))]

    
    internal partial class CandyGameContext
    {
    }
}
