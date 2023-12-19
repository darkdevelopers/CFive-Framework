using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using static CitizenFX.Core.UI.Screen;

namespace CFive_Framework.Client.Controller
{
    public class GpsController : BaseScript
    {
        #region [Print X Y Z Coords]

        public static async void GetCoords()
        {
            ShowNotification($"[Coords] X: {Game.PlayerPed.Position.X} Y: {Game.PlayerPed.Position.Y} Z: {Game.PlayerPed.Position.Z}");
        }

        #endregion
    }
}