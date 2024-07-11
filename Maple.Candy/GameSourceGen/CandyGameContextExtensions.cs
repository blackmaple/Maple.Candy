using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Text;
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
                if (battleSystem.INPUT_CONTROLLER != nint.Zero)
                {
                    var fightMgr = battleSystem.FIGHT_MGR;
                    if (fightMgr)
                    {
                        return fightMgr.GAME_CONTEXT;
                    }
                }


            }
            return default;
        }

        public static void ShowHideItem(this CandyGameContext @this, GameContext.Ptr_GameContext gameContext, bool on)
        {
            var itemEntities = gameContext.GET_ITEMS().LIST;
            foreach (var itemEntity in itemEntities)
            {
                var itemStatusListeners = itemEntity.GET_ITEM_STATE_LISTENER().VALUE;
                foreach (var itemStatusListener in itemStatusListeners)
                {
                    itemStatusListener.ON_ITEM_STATE(itemEntity, on ? ItemState.Flying : itemEntity.GET_ITEM_STATE().VALUE);
                }
            }

        }


        private static PMonoString GetPlayerPrefType(this CandyGameContext @this, EnumPlayerPrefType playerPrefsType, bool local = false)
        {
            StringBuilder sb = new();
            if (local)
            {
                sb.Append(@this.PlayerPrefsEx.KEYCODE.AsReadOnlySpan());
            }
            sb.Append(playerPrefsType.ToString());
            return @this.T(sb.ToString());
        }





        public static void SendEmoType(this CandyGameContext @this,  uint key)
        {
            @this.BattleSystem.INSTANCE.SEND_EMO_TYPE(key, @this.PlayerDataManager.M_INSTANCE.BATTLE_SELF_INDEX);
        }

        //private static int GetPlayerPrefIntValue(this CandyGameContext @this, EnumPlayerPrefType playerPrefsType, bool local = false)
        //{
        //    var name = @this.GetPlayerPrefType(playerPrefsType, local);
        //    return PlayerPrefs.Ptr_PlayerPrefs.GET_INT_00(name, 0);
        //}
        //private static void SetPlayerPrefIntValue(this CandyGameContext @this, EnumPlayerPrefType playerPrefsType, int val, bool local = false)
        //{
        //    var name = @this.GetPlayerPrefType(playerPrefsType, local);
        //    PlayerPrefs.Ptr_PlayerPrefs.SET_INT(name, val);
        //}

        //private static string? GetPlayerPrefString(this CandyGameContext @this, EnumPlayerPrefType playerPrefsType, bool local = false)
        //{
        //    var name = @this.GetPlayerPrefType(playerPrefsType, local);
        //    return PlayerPrefs.Ptr_PlayerPrefs.GET_STRING_00(name, name).ToString();
        //}
        //private static void SetPlayerPrefString(this CandyGameContext @this, EnumPlayerPrefType playerPrefsType, string str, bool local = false)
        //{
        //    var name = @this.GetPlayerPrefType(playerPrefsType, local);
        //    PlayerPrefs.Ptr_PlayerPrefs.SET_STRING(name, @this.T(str));
        //}

        public static int RandomBombId(this CandyGameContext @this)
        {
            var name = @this.GetPlayerPrefType(EnumPlayerPrefType.CurrentBombID, true);
            var bombId = PlayerPrefs.Ptr_PlayerPrefs.GET_INT_00(name, 0);
            @this.Logger.LogInformation("bobmId={id}", bombId);
            ++bombId;
            PlayerPrefs.Ptr_PlayerPrefs.SET_INT(name, bombId);
            return bombId;
        }

        public static string RandomMAC(this CandyGameContext @this)
        {
            var name = @this.GetPlayerPrefType(EnumPlayerPrefType.MACHINE_CODE, false);
            var mac = PlayerPrefs.Ptr_PlayerPrefs.GET_STRING_00(name, name);
            @this.Logger.LogInformation("mac={mac}", mac.ToString());
            var val = Guid.NewGuid().ToString("N");
            var newMAC = @this.T(val);
            PlayerPrefs.Ptr_PlayerPrefs.SET_STRING(name, newMAC);
            return val;
        }
    }

    public enum EnumPlayerPrefType
    {
        CurrentBombID,
        MACHINE_CODE
    }
}
