using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelPath))]
public class LevelPathEditor : Editor
{
    void OnSceneGUI()
    {
        var levelPath = target as LevelPath;

        if (levelPath == null)
        {
            return;
        }

        if (SceneView.currentDrawingSceneView.in2DMode)
        {

        }
        else
        {

        }
    }
}
