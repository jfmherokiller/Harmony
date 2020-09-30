using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 position;
    public float groundSpeed;
    public float slopeFactor;
    public float groundAngle;

    public float wallCollisionHeightOffset;
    public float bodyWidthRadius;
    public float bodyHeightRadius;

    public const float SUBPIXEL = 1 / 256.0f;
    public const float ACCELERATION = SUBPIXEL * 12;
    public const float DECELERATION = SUBPIXEL * 128;
    public const float TOPSPEEDX = 6;
    public const float FRICTION = ACCELERATION;
    public const float SLOPENORMAL = SUBPIXEL * 32;
    public const float SLOPEROLLUP = SUBPIXEL * 20;
    public const float SLOPEROLLDOWN = SUBPIXEL * 80;
    public const float WALLTOLERANCE = 2.5f;
    public const float AIRACCELERATION = SUBPIXEL * 24;
    public const float JUMPFORCE = 6.5f;
    public const float GRAVITY = SUBPIXEL * 56;

    void Start()
    {

    }

    void Update()
    {

    }
}
