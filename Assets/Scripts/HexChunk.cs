using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class HexChunk : MonoBehaviour {

    HexInfo hexInfo = new HexInfo();

    void Start () {
        Mesh mesh = new Mesh();

        mesh = hexInfo.HexData;

        MeshFilter meshFilter = GetComponent<MeshFilter>();

        meshFilter.mesh = mesh;	
	}
}
