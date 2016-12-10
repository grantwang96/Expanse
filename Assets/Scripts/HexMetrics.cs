using UnityEngine;
using System.Collections;

public static class HexMetrics {

    // Radius
    // public const float outerRadius = 10f;
    // public const float innerRadius = outerRadius * 0.866025404f;
    public const float innerRadius = 1;

    //positions vertices of the hexagon to make a normal hexagon
    public static Vector3[] vertices =
    {
        /*0*/new Vector3((innerRadius* Mathf.Cos((float)(2*Mathf.PI*(3+0.5)/6))), 0, (innerRadius* Mathf.Sin((float)(2*Mathf.PI*(3+0.5)/6)))),
        /*1*/new Vector3((innerRadius* Mathf.Cos((float)(2*Mathf.PI*(2+0.5)/6))), 0, (innerRadius* Mathf.Sin((float)(2*Mathf.PI*(2+0.5)/6)))),
        /*2*/new Vector3((innerRadius* Mathf.Cos((float)(2*Mathf.PI*(1+0.5)/6))), 0, (innerRadius* Mathf.Sin((float)(2*Mathf.PI*(1+0.5)/6)))),
        /*3*/new Vector3((innerRadius* Mathf.Cos((float)(2*Mathf.PI*(0+0.5)/6))), 0, (innerRadius* Mathf.Sin((float)(2*Mathf.PI*(0+0.5)/6)))),
       /*4*/new Vector3((innerRadius* Mathf.Cos((float)(2*Mathf.PI*(5+0.5)/6))), 0, (innerRadius* Mathf.Sin((float)(2*Mathf.PI*(5+0.5)/6)))),
       /*5*/new Vector3((innerRadius* Mathf.Cos((float)(2*Mathf.PI*(4+0.5)/6))), 0, (innerRadius* Mathf.Sin((float)(2*Mathf.PI*(4+0.5)/6))))
    };

    //triangles connecting the verts
    public static int[] triangles =
    {
        1,5,0,
        1,4,5,
        1,2,4,
        2,3,4
    };

    public static Vector2[] uv =
    {
         new Vector2(0,0.25f),
         new Vector2(0,0.75f),
         new Vector2(0.5f,1),
         new Vector2(1,0.75f),
         new Vector2(1,0.25f),
         new Vector2(0.5f,0),
    };
}
