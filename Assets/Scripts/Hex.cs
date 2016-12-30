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

    private void CreateLandMesh()
    {
        float sin60 = Mathf.Sin((60 * Mathf.PI) / 180);
        float cos60 = Mathf.Cos((60 * Mathf.PI) / 180);

        // --- Why * .55f? ---

        float innerHexSideLength = sideLength * 0.55f;

        // vertices
        Vector3[] newVerts = new Vector3[25];
        
        //INNER HEX
        newVerts[0] = new Vector3(0, 0, 0);                                                                        //CENTER 		(0)
        newVerts[1] = new Vector3(cos60 * innerHexSideLength, 0, sin60 * innerHexSideLength);                     //NORTHEAST 		(1)		
        newVerts[2] = new Vector3(innerHexSideLength, 0, 0);                                                     //EAST				(2)
        newVerts[3] = new Vector3(cos60 * innerHexSideLength, 0, -sin60 * innerHexSideLength);                  //SOUTHEAST			(3)
        newVerts[4] = new Vector3(-cos60 * innerHexSideLength, 0, -sin60 * innerHexSideLength);                //SOUTHWEST			(4)
        newVerts[5] = new Vector3(-innerHexSideLength, 0, 0);                                                 //WEST				(5)
        newVerts[6] = new Vector3(-cos60 * innerHexSideLength, 0, sin60 * innerHexSideLength);				 //NORTHWEST			(6)

        		//NORTHEAST CORNER 		newVerts[7] = new Vector3(cos60 * sideLength,0, sin60 * sideLength);								//NE CNR AXIS		(7) 		newVerts[8] = new Vector3(newVerts[1].x,0,newVerts[7].z);											//NE CNR LEFT		(8) 		 		float cnrAngle = Mathf.Atan((newVerts[7].x - newVerts[1].x) / (newVerts[7].z - newVerts[1].z));		//CALCULATING..... 		float cnrLength = newVerts[8].z - newVerts[1].z;													//CNRCOS.......... 		float cnrCos = Mathf.Cos(cnrAngle) * cnrLength;														//AND.............			 		float cnrSin = Mathf.Sin(cnrAngle) * cnrLength;														//CNRSIN.......... 		 		newVerts[9] = new Vector3(newVerts[1].x + cnrCos,0,newVerts[1].z + cnrSin);							//NE CNR RIGHT		(9) 		 		//EAST CORNER 		newVerts[10] = new Vector3(sideLength,0,0);															//EAST AXIS 		(10) 		newVerts[11] = new Vector3(newVerts[2].x + cnrCos,0,newVerts[2].z + cnrSin);						//EAST CNR LEFT		(11) 		newVerts[12] = new Vector3(newVerts[2].x + cnrCos,0,newVerts[2].z - cnrSin);						//EAST CNR RIGHT	(12) 		 		//SOUTHEAST CORNER 		newVerts[13] = new Vector3(cos60 * sideLength, 0, -sin60 * sideLength);								//SE CNR AXIS		(13) 		newVerts[14] = new Vector3(newVerts[3].x + cnrCos,0,newVerts[3].z - cnrSin);						//SE CNR LEFT		(14) 		newVerts[15] = new Vector3(newVerts[3].x,0,newVerts[13].z);											//SE CNR RIGHT		(15) 		 		//SOUTHWEST CORNER 		newVerts[16] = new Vector3(-cos60 * sideLength,0,-sin60 * sideLength);								//SW CNR AXIS		(16) 		newVerts[17] = new Vector3(newVerts[4].x,0,newVerts[16].z);											//SW CNR LEFT		(17) 		newVerts[18] = new Vector3(newVerts[4].x - cnrCos,0,newVerts[4].z - cnrSin);						//SW CNR RIGHT		(18) 		 		//WEST CORNER 		newVerts[19] = new Vector3(-sideLength,0,0);														//WEST CNR AXIS		(19) 		newVerts[20] = new Vector3(newVerts[5].x - cnrCos,0,newVerts[5].z - cnrSin);						//WEST CNR LEFT		(20) 		newVerts[21] = new Vector3(newVerts[5].x - cnrCos,0,newVerts[5].z + cnrSin);						//WEST CNR RIGHT	(21) 		 		//NORTHWEST CORNER 		newVerts[22] = new Vector3(-cos60 * sideLength,0,sin60 * sideLength);								//NW CNR AXIS		(22) 		newVerts[23] = new Vector3(newVerts[6].x - cnrCos,0,newVerts[6].z + cnrSin);						//NW CNR LEFT		(23) 		newVerts[24] = new Vector3(newVerts[6].x,0,newVerts[22].z);											//NW CNR RIGHT		(24) 		 		landMesh.vertices = newVerts; 		 		landMesh.triangles = new int[]{ 			 			//INNER HEX 			0,1,2,			//NORTHEAST			 			0,2,3,			//SOUTHEAST 			0,3,4,			//SOUTH 			0,4,5,			//SOUTHWEST 			0,5,6,			//NORTHWEST 			0,6,1,			//NORTH 			 			//NE CORNER 			1,8,7, 			//LEFT 			1,7,9,			//RIGHT 			 			//EAST CORNER 			2,11,10,		//LEFT 			2,10,12,		//RIGHT 			 			//NORTHEAST SIDE 			1,9,11, 			1,11,2, 			 			//SE CORNER 			3,14,13,		//LEFT 			3,13,15,		//RIGHT 			 			//SOUTHEAST SIDE 			2,12,14, 			2,14,3, 			 			//SW CORNER 			4,17,16,		//LEFT 			4,16,18,		//RIGHT 			 			//SOUTH SIDE 			3,15,17, 			3,17,4, 			 			//WEST CORNER 			5,20,19,		//LEFT 			5,19,21,		//RIGHT 			 			//SOUTHWEST SIDE 			4,18,20, 			4,20,5, 			 			//NORTHWEST CORNER 			6,23,22, 			6,22,24, 			 			//NORTHWEST SIDE 			5,21,23, 			5,23,6, 			 			//NORTH SIDE 			6,24,8, 			6,8,1 		} ; 		 		Vector2[] newUVs = new Vector2[25]; 		 		//CENTER 		newUVs[0] = new Vector2(0.5f,0.5f); 		 		//INNER HEX 		newUVs[1] = new Vector2(0.71f,0.85f); 		newUVs[2] = new Vector2(0.91f,0.5f); 		newUVs[3] = new Vector2(0.71f,0.15f); 		newUVs[4] = new Vector2(0.29f,0.15f); 		newUVs[5] = new Vector2(0.12f,0.5f); 		newUVs[6] = new Vector2(0.29f,0.85f); 		 		//OUTER HEX - RIGHT SIDE 		newUVs[7] = new Vector2(0.78f,1); 		newUVs[8] = new Vector2(0.71f,1); 		newUVs[9] = new Vector2(0.82f,0.92f); 		newUVs[10] = new Vector2(1,0.5f); 		newUVs[11] = new Vector2(1f,0.56f); 		newUVs[12] = new Vector2(1f,0.44f); 		newUVs[13] = new Vector2(0.78f,0); 		newUVs[14] = new Vector2(0.82f,0.08f); 		newUVs[15] = new Vector2(0.71f,0); 		 		//OUTER HEX - LEFT SIDE 		newUVs[16] = new Vector2(0.22f,0); 		newUVs[17] = new Vector2(0.29f,0); 		newUVs[18] = new Vector2(0.18f,0.08f); 		newUVs[19] = new Vector2(0.0f,0.5f); 		newUVs[20] = new Vector2(0.0f,0.44f); 		newUVs[21] = new Vector2(0.0f,0.56f); 		newUVs[22] = new Vector2(0.22f,1); 		newUVs[23] = new Vector2(0.18f,0.92f); 		newUVs[24] = new Vector2(0.29f,1f); 		 		landMesh.uv = newUVs; 		 		landMesh.normals = new Vector3[]{ 			 			//INNER HEX 			Vector3.up, Vector3.up, Vector3.up, Vector3.up, Vector3.up, Vector3.up, 			Vector3.up, Vector3.up, Vector3.up, Vector3.up, Vector3.up, Vector3.up, 			Vector3.up, Vector3.up, Vector3.up, Vector3.up, Vector3.up, Vector3.up, 			Vector3.up, Vector3.up, Vector3.up, Vector3.up, Vector3.up, Vector3.up, Vector3.up 		} ;
    }
}
