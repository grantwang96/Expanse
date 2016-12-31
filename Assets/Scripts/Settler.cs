using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Settler : MonoBehaviour {

    public GameObject cityPreFab;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            FoundCity();
        }
        
    }

    public void FoundCity()
    {
        var citiesSpawned = CitiesManager.citiesSpawned;

        GameObject city = Instantiate(cityPreFab);
        string Name = "City: " + citiesSpawned.ToString();
        city.name = Name;

        citiesSpawned++;
        PlayerStats.goldPerTurn += city.GetComponent<City>().cityGold;
    }
}
