using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Maple.Candy
{


    internal static class CandyGameContextExtensions
    {
        public static void ShowMessage(this CandyGameContext @this, string? msg)
        {
            var gameRoot = @this.GameRoot.INSTANCE;
            if (gameRoot)
            {
                var txt = msg ?? string.Empty;
                var pString = @this.T(txt);
                gameRoot.SHOW_TIPS_QUICK(pString);
            }
        }


        public static GameContext.Ptr_GameContext GetGameContext(this CandyGameContext @this)
        {
            var battleSystem = @this.BattleSystem.INSTANCE;
            if (battleSystem)
            {
                var fightMgr = battleSystem.FIGHT_MGR;
                if (fightMgr)
                {
                    return fightMgr.GAME_CONTEXT;
                }
            }
            return default;
        }

        public static void ShowHideItem(this CandyGameContext @this, GameContext.Ptr_GameContext gameContext)
        {
            var viewMgr = @this.ViewManager.INSTANCE;
            if (viewMgr)
            {
                var itemEntities = gameContext.GET_ITEMS().LIST;
                foreach (var itemEntity in itemEntities)
                {
                    var itemStatusListeners = itemEntity.GET_ITEM_STATE_LISTENER().VALUE;
                    foreach (var itemStatusListener in itemStatusListeners)
                    {
                        itemStatusListener.ON_ITEM_STATE(itemEntity, ItemState.Flying);
                    }
                }
            }

        }
    }


}
