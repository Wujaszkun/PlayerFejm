namespace Oxide.Plugins
{
    [Info("PlayerFejm", "Wujaszkun", "0.0.1")]
    [Description("Adds fejm points that players can collect")]
    internal class PlayerFejm : RustPlugin
    {

        //Assist in kill
        private object OnPlayerAssist(BasePlayer target, BasePlayer player)
        {
            Puts("OnPlayerAssist works!");
            return null;
        }

        void OnLootPlayer(BasePlayer player, BasePlayer target)
        {
            Puts("OnLootPlayer works!");
        }

        object OnPlayerDeath(BasePlayer player, HitInfo info)
        {
            Puts("OnPlayerDeath works!");
            return null;
        }

    }
}