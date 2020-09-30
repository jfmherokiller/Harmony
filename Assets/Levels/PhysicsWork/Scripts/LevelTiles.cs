using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[ExecuteInEditMode]
public class LevelTiles : MonoBehaviour
{
    private CollisionTile[] tiles = new CollisionTile[0];
    private Vector2[] prevPoints, currentPoints;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        prevPoints = currentPoints;
        currentPoints = GetComponent<PolygonCollider2D>().points;

        if (prevPoints.Length != currentPoints.Length)
        {
            UpdateTiles();
        }
        else
        {
            for (int i = 0; i < prevPoints.Length; i++)
            {
                if (prevPoints[i] != currentPoints[i])
                {
                    UpdateTiles();
                    break;
                }
            }
        }
    }

    void UpdateTiles()
    {

    }

    void OnDrawGizmos()
    {
        var prevColor = Gizmos.color;
        Gizmos.color = Color.white;
        foreach (var tile in tiles)
        {
            if (tile != null)
            {
                for
                {
                    Gizmos.DrawCube()
                }
            }
        }
        Gizmos.color = prevColor;
    }
}
