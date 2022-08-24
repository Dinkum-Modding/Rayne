using BepInEx;

namespace Rayne;

[BepInProcess("Dinkum.exe")]
[BepInAutoPlugin]
public partial class RaynePlugin : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo($"{Name} loaded!");
    }
}