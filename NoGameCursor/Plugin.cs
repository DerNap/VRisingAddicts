using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Bloodstone.API;
using System.Reflection;

namespace NoGameCursor
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInDependency("gg.deca.Bloodstone")]
    [Reloadable]
    public class Plugin : BasePlugin
    {
        #region Variables

        private Harmony _hooks;

        #endregion

        #region Public Methods

        public override void Load()
        {
            if (!VWorld.IsClient)
            {
                Log.LogMessage($"{MyPluginInfo.PLUGIN_NAME} only needs to be installed on client side.");
                return;
            }

            try
            {
                _hooks = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
                (new Harmony("NoGameCursor")).PatchAll();
                NoGameCursor.Inject(this);
            }
            catch
            {
                Log.LogError($"Plugin {MyPluginInfo.PLUGIN_NAME} Something went wrong when trying to inject plugin...");
            }

            Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_NAME} (v{MyPluginInfo.PLUGIN_VERSION}) is loaded!");
        }

        public sealed override bool Unload()
        {
            if (VWorld.IsClient)
            {
                _hooks?.UnpatchSelf();
            }
            return true;
        }
        #endregion
    }
}