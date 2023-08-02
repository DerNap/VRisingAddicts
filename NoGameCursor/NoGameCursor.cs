using BepInEx.Unity.IL2CPP;
using BepInEx.Logging;
using UnityEngine;

namespace NoGameCursor
{
    public class NoGameCursor : MonoBehaviour
    {
        private Plugin Loader;

        public static void Inject(Plugin _Plugin)
        {
            try
            {
                NoGameCursor noGameCursor = _Plugin.AddComponent<NoGameCursor>();
                noGameCursor.Loader = _Plugin;
                UnityEngine.Object.DontDestroyOnLoad(noGameCursor.gameObject);
                noGameCursor.hideFlags = HideFlags.HideAndDontSave;
                noGameCursor.gameObject.SetActive(true);
            }
            catch
            {
                _Plugin.Log.LogError($"Plugin {MyPluginInfo.PLUGIN_NAME} Something went wrong when patching CursorLock plugin...");
            }
        }

        public void Update()
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            // Cursor.SetCursor(null, 0);
        }
    }
}

