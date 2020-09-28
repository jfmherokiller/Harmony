using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Chunk : MonoBehaviour
{
    public const int NUM_TILES = 16;
    public Tile[] frontBackTiles = new Tile[NUM_TILES];
    public Tile[] topTiles = new Tile[NUM_TILES];
    public Tile[] bottomTiles = new Tile[NUM_TILES];
    public Tile[] sideTiles = new Tile[NUM_TILES];


    void Start()
    {

    }

    void Update()
    {

    }
}

public static class ChunkHelper
{
    [MenuItem("Assets/Create/" + Config.GAMENAME + "/Chunk")]
    public static void AddChunk()
    {

    }
}
