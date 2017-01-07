using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class City : MonoBehaviour {
    public int cityGold = 1;
    public int cityScience = 1;
    public int cityProduction = 0;
    public int cityProductionPT = 5;

    // City Menu
    bool over = false, notHovering = false, cityClicked = false;

    public Animator _cityClicked;
    public Image cityMenu;
    public Transform _canvas;
    float hoverTime, tranistionTime, clickTransitionSpeed = 450;

    void Start()
    {
        _canvas = GameObject.FindGameObjectWithTag("Canvas").transform;
        _cityClicked = GetComponent<Animator>();
        cityMenu = Instantiate(cityMenu);
        cityMenu.transform.SetParent(_canvas.transform);
        cityMenu.transform.position = new Vector3(1184, 0, 0);
    }

    void Update()
    {
        CityMenu();
        _cityClicked.SetBool("cityClicked", cityClicked);
        Debug.Log(cityMenu.GetComponent<RectTransform>().anchoredPosition3D.x);


    }


    void OnMouseDown()
    {
        tranistionTime = Time.time;
        if (!cityClicked)
        {
            cityClicked = true;
        }
        else
        {
            cityClicked = false;
        }
    }

    void CityMenu()
    {
        var cityPos = cityMenu.GetComponent<RectTransform>().anchoredPosition3D;
        if (cityClicked)
        {
            cityMenu.GetComponent<RectTransform>().anchoredPosition3D = Vector3.MoveTowards(cityPos, new Vector3(740, 0, 0), clickTransitionSpeed);
        }

        if (!cityClicked)
        {
            cityMenu.GetComponent<RectTransform>().anchoredPosition3D = Vector3.MoveTowards(cityPos, new Vector3(1184, 0, 0), clickTransitionSpeed);
        }
    }

    public void Market()
    {
        // cityGold = (cityGold + 1) * 2;
        PlayerStats.goldPerTurn += cityGold;
    }
}
