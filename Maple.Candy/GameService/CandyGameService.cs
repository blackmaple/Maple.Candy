using Maple.GameContext;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography.X509Certificates;
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
            try
            {
                var switchObject = this.ListGameSwitch.Where(p => p.ObjectId == EnumGameSwitchType.ShowHideItem.ToString()).FirstOrDefault();
                if (switchObject is not null)
                {
                    await ShowHideItemAsync(true).ConfigureAwait(false);
                    switchObject.SwitchValue = true;
                }
            }
            catch (GameException ex)
            {
                await this.MonoTaskAsync(static (p, msg) => p.ShowMessage(msg), ex.Message).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                this.Logger.LogError("{ex}", ex);
            }

        }

        protected sealed override async ValueTask F3_KeyDown()
        {
            try
            {
                var switchObject = this.ListGameSwitch.Where(p => p.ObjectId == EnumGameSwitchType.ShowHideItem.ToString()).FirstOrDefault();
                if (switchObject is not null)
                {
                    await ShowHideItemAsync(false).ConfigureAwait(false);
                    switchObject.SwitchValue = false;
                }
            }
            catch (GameException ex)
            {
                await this.MonoTaskAsync(static (p, msg) => p.ShowMessage(msg), ex.Message).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                this.Logger.LogError("{ex}", ex);
            }
        }

        protected sealed override async ValueTask F4_KeyDown()
        {
            try
            {
                var switchObject = this.ListGameSwitch.Where(p => p.ObjectId == EnumGameSwitchType.FreeEmoji.ToString()).FirstOrDefault();
                if (switchObject is not null)
                {

                    await FreeEmojiAsync(switchObject.UIntContent).ConfigureAwait(false);

                }
            }
            catch (GameException ex)
            {
                await this.MonoTaskAsync(static (p, msg) => p.ShowMessage(msg), ex.Message).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                this.Logger.LogError("{ex}", ex);
            }

        }
        protected sealed override async ValueTask F11_KeyDown()
        {
            try
            {
                await RandomMACAsync().ConfigureAwait(false);
            }
            catch (GameException ex)
            {
                await this.MonoTaskAsync(static (p, msg) => p.ShowMessage(msg), ex.Message).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                this.Logger.LogError("{ex}", ex);
            }

        }



        protected sealed override ValueTask Q_KeyDown() => TryRandomFreeEmojiAsync();

        //protected sealed override ValueTask Up_KeyDown()=> TryRandomFreeEmojiAsync();

        //protected sealed override ValueTask Down_KeyDown() => TryRandomFreeEmojiAsync();
        //protected sealed override ValueTask Left_KeyDown() => TryRandomFreeEmojiAsync();
        //protected sealed override ValueTask Right_KeyDown() => TryRandomFreeEmojiAsync();

        private async Task RandomMACAsync()
        {
            var mac = await this.MonoTaskAsync(p => p.RandomMAC()).ConfigureAwait(false);
            await this.MonoTaskAsync(static (p, mac) => p.ShowMessage($"MAC=>{mac}"), mac).ConfigureAwait(false);

        }

        private async Task ShowHideItemAsync(bool on)
        {
            var gameContext = await this.MonoTaskAsync(p => p.GetGameContext()).ConfigureAwait(false);
            if (gameContext && gameContext.GET_GAME_PROGRESS().VALUE == GameProgressState.InGame)
            {
                await this.UnityTaskAsync(static (p, args) => p.ShowHideItem(args.gameContext, args.on), (gameContext, on)).ConfigureAwait(false);
                if (on)
                {
                    //await this.MonoTaskAsync(static p => p.ShowMessage("透视开启!")).ConfigureAwait(false);
                }
                else
                {
                    await this.MonoTaskAsync(static p => p.ShowMessage("透视关闭!")).ConfigureAwait(false);
                }
            }
            else
            {
                await this.MonoTaskAsync(static p => p.ShowMessage("游戏未开始!")).ConfigureAwait(false);
            }
        }

        private async Task FreeEmojiAsync(uint id)
        {
            var gameContext = await this.MonoTaskAsync(p => p.GetGameContext()).ConfigureAwait(false);
            if (gameContext && gameContext.GET_GAME_PROGRESS().VALUE == GameProgressState.InGame)
            {
                await this.UnityTaskAsync(static (p, id) => p.SendEmoType(id), id).ConfigureAwait(false);
            }
            else
            {
                await this.MonoTaskAsync(static p => p.ShowMessage("游戏未开始!")).ConfigureAwait(false);
            }
        }

        private async ValueTask TryRandomFreeEmojiAsync()
        {
            try
            {
                var freeEmoji = this.ListGameSwitch.Where(p => p.ObjectId == EnumGameSwitchType.FreeEmoji.ToString()).FirstOrDefault();
                if (freeEmoji is null)
                {
                    return;
                }
                if (freeEmoji.SelectedContents is null)
                {
                    return;
                }
                if (freeEmoji.SelectedContents.Count == 0)
                {
                    return;
                }
                var index = Random.Shared.Next(0, freeEmoji.SelectedContents.Count);
                var data = freeEmoji.SelectedContents[index];
                await FreeEmojiAsync(data.UIntValue).ConfigureAwait(false);
            }
            catch (GameException ex)
            {
                await this.MonoTaskAsync(static (p, msg) => p.ShowMessage(msg), ex.Message).ConfigureAwait(false);

            }
            catch (Exception ex)
            {
                this.Logger.LogError("{ex}", ex);
            }

        }


        public sealed override async ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO gameSwitchModify)
        {
            var switchObject = this.ListGameSwitch.Where(p => p.ObjectId == gameSwitchModify.SwitchObjectId).FirstOrDefault();
            if (switchObject is null)
            {
                return GameException.Throw<GameSwitchDisplayDTO>($"NOT FOUND {gameSwitchModify.SwitchObjectId} (0)");
            }
            if (Enum.TryParse<EnumGameSwitchType>(gameSwitchModify.SwitchObjectId, out var result) == false)
            {
                return GameException.Throw<GameSwitchDisplayDTO>($"NOT FOUND {gameSwitchModify.SwitchObjectId} (1)");
            }
            if (result == EnumGameSwitchType.RandomMAC)
            {
                await RandomMACAsync().ConfigureAwait(false);
            }
            else if (result == EnumGameSwitchType.ShowHideItem)
            {
                await ShowHideItemAsync(gameSwitchModify.SwitchValue).ConfigureAwait(false);

            }
            else if (result == EnumGameSwitchType.FreeEmoji)
            {
                await FreeEmojiAsync(gameSwitchModify.UIntValue).ConfigureAwait(false);
            }
            switchObject.ContentValue = gameSwitchModify.ContentValue;
            return switchObject;
        }

        enum EnumGameSwitchType
        {
            RandomMAC,
            ShowHideItem,
            FreeEmoji,

        }
        protected sealed override GameSwitchDisplayDTO[] InitListGameSwitch()
        {
            var gamePath = AppContext.BaseDirectory;
            var gameResPath = Path.Combine(gamePath, "果糖0.4盛夏之约_Data\\StreamingAssets");
            var directoryInfo = new DirectoryInfo(gameResPath);
            if (false == directoryInfo.Exists)
            {
                return [];
            }
            var files = directoryInfo.GetFiles("icon_220*");
            var datas = files.Select((p, i) => new GameValueInfoDTO() { ObjectId = p.Name, DisplayName = $"Emoji_{i:D4}", DisplayValue = p.Name.AsSpan()[5..].ToString(), }).ToList();
            if (datas.Count == 0)
            {
                return [];
            }
            return [
                new GameSwitchDisplayDTO(){ObjectId=nameof(EnumGameSwitchType.RandomMAC),DisplayName="随机MAC(F11)",DisplayDesc ="登录前使用",ButtonType=true,SwitchValue =false } ,
                new GameSwitchDisplayDTO(){ObjectId=nameof(EnumGameSwitchType.ShowHideItem),DisplayName="透视道具(F2)",DisplayDesc ="游戏内使用" ,SwitchValue =false } ,
                new GameSwitchDisplayDTO(){ObjectId=nameof(EnumGameSwitchType.FreeEmoji),DisplayName="免费表情(F3)",DisplayDesc ="游戏内使用" ,ContentValue=datas[0].DisplayValue ,SelectedContents =datas} ,

               ];
        }
    }



}
