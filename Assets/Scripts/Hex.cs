using UnityEngine;
using System.Collections;

public class Hex {
    public GameObject instance;

    // Coords
    public Vector3 location = new Vector3(0, 0, 0);
    public Vector3 coordinates;

    // Not sure what this is--- private HexCoordinate hexCoord;

    public static float sideLength = 1;

    // Mesh
    public Mesh landMesh = new Mesh();
    public Mesh lakeMesh = new Mesh();

    // Misc
    public string type;

    //
    // CONSTRUCTOR
    //
    public Hex(Vector3 loc, Vector3 coords, string hexType, HexCoordinate hexCoordinate)
    {
        coordinates = coords;

        hexCoord = hexCoordinate;

        type = hexType;

        location = loc;

        CreateLandMesh();
    }
}
