using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class HexMesh : MonoBehaviour {
    Mesh hexMesh;

    List<Vector3> vertices;
    List<int> triangles;

    void Awake()
    {
        GetComponent<MeshFilter>().mesh = hexMesh = new Mesh();
    }
}
