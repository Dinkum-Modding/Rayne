using BepInEx;
using Rayne.Utils;
using UnityEngine;

namespace RayneExample;

[BepInAutoPlugin]
public partial class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        // Plugin startup logic
        Logger.LogInfo($"Plugin {Name} is loaded!");
    }

    private void Start()
    {
        Logger.LogInfo(State.IsInMainMenu());
    }

    private void OnGUI()
    {
        if (State.IsInMainMenu()) return;
        var a = NetworkMapSharer.share.localChar.transform.position;
        var b = new Vector3(100f, 4f, 0f);
        Drawing.DrawLine3D(a, b, Color.cyan);
    }
}