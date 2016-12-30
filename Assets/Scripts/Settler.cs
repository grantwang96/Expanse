using UnityEngine;
using System.Collections;

public class Settler : MonoBehaviour {

    public GameObject cityPreFab;
    public GameObject[] Cities;
    int citiesSpawned = 0;

    void Start()
    {
        Cities = new GameObject[12];
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            FoundCity();
            citiesSpawned = 1;
        }

        Debug.Log(citiesSpawned);
    }

    public void FoundCity()
    {
        GameObject city = Instantiate(cityPreFab);
        city.name = "City " + citiesSpawned.ToString();
        Cities[citiesSpawned] = city;

    }
}
