using UnityEngine;
using System.Collections;

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
        GameObject city = Instantiate(cityPreFab);
        PlayerStats.goldPerTurn+= City.cityGold;

    }
}
