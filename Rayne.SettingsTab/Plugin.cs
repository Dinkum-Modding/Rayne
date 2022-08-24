using BepInEx;
using HarmonyLib;

namespace Rayne.SettingsTab;

[BepInAutoPlugin]
public partial class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        // Plugin startup logic
        Logger.LogInfo($"Plugin {Name} is loaded!");
    }
}
