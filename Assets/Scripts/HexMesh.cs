using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class HexMesh : MonoBehaviour {

    List<Vector3> vertices;
    List<int> triangles;

    void Awake()
    {
        // Mesh
        Mesh hexMesh = new Mesh();
        hexMesh.name = "Hex Mesh";
        MeshFilter meshFilter = GetComponent<MeshFilter>();

        hexMesh.vertices = HexMetrics.corners;
        hexMesh.triangles = HexMetrics.triangles;

        meshFilter.mesh = hexMesh;
    }
}
