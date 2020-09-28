using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LevelPath : MonoBehaviour
{
    public Chunk[] chunks;

    public int[] curves;

    public Texture2D tileSheet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

static class LevelPathHelper
{
    [MenuItem("GameObject/" + Config.GAMENAME + "/Level Path", false, 0)]
    static void AddLevelPath()
    {
        Util.CreateGameObject("Level Path", typeof(GridSnap), typeof(LevelPath));
    }
}