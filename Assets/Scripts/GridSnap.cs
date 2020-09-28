using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class GridSnap : MonoBehaviour
{
    [Range(1, 128)]
    public int snapSize = 32;

    void Start()
    {

    }

    void Update()
    {
        SceneView.lastActiveSceneView.showGrid = true;
        snapSize = Mathf.ClosestPowerOfTwo(snapSize);
        var t = Reflection.editorAssembly.GetType("UnityEditor.GridSettings");
        var f = t.GetProperty("size");
        f.SetMethod.Invoke(f, new object[] { new Vector3(snapSize, snapSize, snapSize) });
        foreach (var childTransform in transform.GetComponentsInChildren<Transform>())
        {
            var childPos = childTransform.position;
            childTransform.position = new Vector3(childPos.x - (childPos.x % snapSize),
                                                  childPos.y - (childPos.y % snapSize),
                                                  childPos.z - (childPos.z % snapSize));
        }
    }
}
