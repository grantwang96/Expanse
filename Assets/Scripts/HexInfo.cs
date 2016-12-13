using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class HexInfo {

    public Vector3[] vertices = new Vector3[] {
            new Vector3(-1f , 0, -.5f),
            new Vector3(-1f, 0, .5f),
            new Vector3(0f, 0, 1f),
            new Vector3(1f, 0, .5f),
            new Vector3(1f, 0, -.5f),
            new Vector3(0f, 0, -1f)
    };

    public Vector2[] uvs = new Vector2[] {
            new Vector2(0,0.25f),
            new Vector2(0,0.75f),
            new Vector2(0.5f,1),
            new Vector2(1,0.75f),
            new Vector2(1,0.25f),
            new Vector2(0.5f,0),
    };

    public int[] triangles = new int[] {
            1,5,0,
            1,4,5,
            1,2,4,
            2,3,4
    };

    private Mesh hexMesh;
    private MeshFilter _meshFilter;

    void GenerateHex()
    {

        hexMesh.vertices = vertices;
        hexMesh.triangles = triangles;
        hexMesh.uv = uvs;
        hexMesh.RecalculateNormals();
    }

    public Mesh HexData
    {
        get
        {
            return hexMesh;
        }

        set
        {
            hexMesh = value;
        }
    }

    void Awake()
    {
        GenerateHex();
    }
}
