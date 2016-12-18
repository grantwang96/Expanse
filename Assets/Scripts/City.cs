using UnityEngine;
using System.Collections;

public class City : MonoBehaviour {

    public GameObject cityPreFab;

	void Start () {
	
	}
	
	void Update () {
	    if (Input.GetKeyUp(KeyCode.S))
        {
            FoundCity();
        }
	}

    public void FoundCity()
    {
        Debug.Log("Founded");
        Instantiate(cityPreFab);
    }
}
