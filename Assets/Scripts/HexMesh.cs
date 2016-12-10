using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class HexMesh : MonoBehaviour {

    void Awake()
    {
        // Mesh
        Mesh hexMesh = new Mesh();
        hexMesh.name = "Hex Mesh";
        MeshFilter meshFilter = GetComponent<MeshFilter>();

        hexMesh.vertices = HexMetrics.vertices;
        hexMesh.triangles = HexMetrics.triangles;
        hexMesh.uv = HexMetrics.uv;

        hexMesh.RecalculateNormals();

        meshFilter.mesh = hexMesh;
    }
}
