using UnityEngine;
using UnityEditor;
using System;

public static class Util
{
    public static void CreateGameObject(string name, params Type[] componentTypes)
    {
        var gameObject = new GameObject(name);
        foreach (var componentType in componentTypes)
        {
            gameObject.AddComponent(componentType);
        }
        if (Selection.activeGameObject)
        {
            gameObject.transform.SetParent(Selection.activeTransform);
        }
    }
}