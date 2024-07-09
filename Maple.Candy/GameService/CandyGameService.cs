using Maple.GameContext;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;
using System.Text.Json;


namespace Maple.Candy
{
    internal sealed partial class CandyGameService(
        ILogger<CandyGameService> logger,
        MonoRuntimeContext runtimeContext,
        MonoGameSettings gameSettings)
        : GameService<CandyGameContext>(logger, runtimeContext, gameSettings)
    {

        #region LoadService

        protected sealed override bool EnableService => true;

        protected sealed override CandyGameContext LoadGameContext()
           => CandyGameContext.LoadCandyGameContext(this.RuntimeContext, EnumMonoCollectorTypeVersion.Ver_Common, this.Logger);
        protected sealed override UnityEngineContext LoadUnityEngineContext()
        {
            return default!;
        }
        //protected sealed override GameSwitchDisplayDTO[] InitListGameSwitch()
        //{
        //    return Enumerable.Range(0, 10).Select(p => new GameSwitchDisplayDTO { ObjectId = p.ToString(), DisplayName = $"DisplayName_{p}", DisplayDesc = $"DisplayDesc_{p}", SwitchValue = false }).ToArray();
        //}
        #endregion

        protected sealed override async ValueTask F2_KeyDown()
        {
 
            var gameContext = await this.MonoTaskAsync(p => p.GetGameContext()).ConfigureAwait(false);
            if (gameContext && gameContext.GET_GAME_PROGRESS().VALUE == GameProgressState.InGame)
            {
                await this.UnityTaskAsync(static (p, gameContext) => p.ShowHideItem(gameContext), gameContext).ConfigureAwait(false);
                //await this.MonoTaskAsync(static p => p.ShowMessage("透视开启!")).ConfigureAwait(false);
            }
            else
            {
                await this.MonoTaskAsync(static p => p.ShowMessage("游戏未开始!")).ConfigureAwait(false);
            }

        }

        protected sealed override ValueTask F12_KeyDown()
        {

            
        }

    }



}
