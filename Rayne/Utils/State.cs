namespace Rayne.Utils;

/// <summary>
/// Class containing methods related to game state
/// </summary>
public static class State
{
    /// <summary>
    /// Check if player is in the main menu
    /// </summary>
    public static bool IsInMainMenu() => NetworkMapSharer.share.localChar is null;
}