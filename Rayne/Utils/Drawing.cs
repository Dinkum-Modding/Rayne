using UnityEngine;

namespace Rayne.Utils;

/// <summary>
/// Class containing methods that can draw something on a screen.
/// </summary>
public static class Drawing
{
    private static void DrawLine(Vector2 pointA, Vector2 pointB)
    {
        var lineTex = new Texture2D(1, 1);
        var matrixBackup = GUI.matrix;
        var width = 8.0f;
        GUI.color = Color.green;
        var angle = Mathf.Atan2(pointB.y - pointA.y, pointB.x - pointA.x) * 180f / Mathf.PI;
        var length = (pointA - pointB).magnitude;

        GUIUtility.RotateAroundPivot(angle, pointA);
        GUI.DrawTexture(new Rect(pointA.x, pointA.y, length, width), lineTex);
        GUI.matrix = matrixBackup;
    }

    private static void DrawLine(Vector2 pointA, Vector2 pointB, Color color)
    {
        var lineTex = new Texture2D(1, 1);
        var matrixBackup = GUI.matrix;
        var width = 4.0f;
        GUI.color = color;
        var angle = Mathf.Atan2(pointB.y - pointA.y, pointB.x - pointA.x) * 180f / Mathf.PI;
        var length = (pointA - pointB).magnitude;

        GUIUtility.RotateAroundPivot(angle, pointA);
        GUI.DrawTexture(new Rect(pointA.x, pointA.y, length, width), lineTex);
        GUI.matrix = matrixBackup;
    }

    /// <summary>
    /// Draw a 2D line between 2 points in 3D
    ///</summary>
    /// <param name="pointA">First point</param>
    /// <param name="pointB">Second point</param>
    public static void DrawLine3D(Vector3 pointA, Vector3 pointB)
    {
        var cam = Camera.main;

        var aTransformed = cam.WorldToScreenPoint(pointA);
        var aScreen = new Vector2(aTransformed.x, Screen.height - aTransformed.y);

        var bTransformed = cam.WorldToScreenPoint(pointB);
        Vector2 bScreen = new Vector3(bTransformed.x, Screen.height - bTransformed.y);

        DrawLine(aScreen, bScreen);
    }

    /// <summary>
    /// Draw a 2D line between 2 points in 3D with color
    /// </summary>
    /// <param name="pointA">First point</param>
    /// <param name="pointB">Second point</param>
    /// <param name="color">Line color</param>
    public static void DrawLine3D(Vector3 pointA, Vector3 pointB, Color color)
    {
        var cam = Camera.main;

        var aTransformed = cam.WorldToScreenPoint(pointA);
        var aScreen = new Vector2(aTransformed.x, Screen.height - aTransformed.y);

        var bTransformed = cam.WorldToScreenPoint(pointB);
        Vector2 bScreen = new Vector3(bTransformed.x, Screen.height - bTransformed.y);

        DrawLine(aScreen, bScreen, color);
    }
}