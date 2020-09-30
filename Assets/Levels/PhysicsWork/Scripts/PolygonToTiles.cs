using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class CollisionTile
{
    public Vector2 position;
    public const int TILESIZE = 32;
    public bool yflip;

    public byte[] heightmap = new byte[TILESIZE];
}

public static class PolygonToTiles
{
    public static CollisionTile[] GetTiles(this PolygonCollider2D collider)
    {
        var startingPoint = collider.bounds.min;
        for (int y = 0; y < collider.bounds.max.y; y += CollisionTile.TILESIZE)
        {
            for (int x = 0; x < collider.bounds.max.x; x += CollisionTile.TILESIZE)
            {

            }
        }

        var topLeftTilePoint = new Vector2(point.x - point.x % CollisionTile.TILESIZE, point.y - point.y % CollisionTile.TILESIZE);
        var topRightTilePoint = topLeftTilePoint + new Vector2(CollisionTile.TILESIZE, 0);
        var bottomLeftTilePoint = topLeftTilePoint + new Vector2(0, CollisionTile.TILESIZE);
        var bottomRightTilePoint = topRightTilePoint + new Vector2(0, CollisionTile.TILESIZE);

        var topLeftInPolygon = collider.OverlapPoint(topLeftTilePoint);
        var topRightInPolygon = collider.OverlapPoint(topRightTilePoint);
        var bottomLeftInPolygon = collider.OverlapPoint(bottomLeftTilePoint);
        var bottomRightInPolygon = collider.OverlapPoint(bottomRightTilePoint);

        var heightmap = new byte[CollisionTile.TILESIZE];
        var yflip = false;

        if (topLeftInPolygon || topRightInPolygon || bottomLeftInPolygon || bottomRightInPolygon)
        {
            if (topLeftInPolygon && topRightInPolygon && bottomLeftInPolygon && bottomRightInPolygon)
            {
                for (int i = 0; i < heightmap.Length; i++)
                {
                    heightmap[i] = CollisionTile.TILESIZE;
                }
            }

            if (topLeftInPolygon && topRightInPolygon && !(bottomLeftInPolygon && bottomRightInPolygon))
            {
                yflip = true;
            }
        }

        return new CollisionTile()
        {
            heightmap = heightmap,
            yflip = yflip
        };
    }
}