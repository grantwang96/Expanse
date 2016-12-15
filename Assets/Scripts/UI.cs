using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    bool over = false, notHovering = false, cityClicked = false;

    public GameObject regionDropDown, cityMenu;
    float hoverTime, tranistionTime;
    public float hoverSpeed = 7f, clickTransitionSpeed = 10f;

	void Start () {
        
    }
	
	void Update () {

        CityMenu();

    }

    void OnMouseDown()
    {
        tranistionTime = Time.time;
        if (!cityClicked)
        {
            cityClicked = true;
        } else
        {
            cityClicked = false;
        }
    }

    void CityMenu()
    {
        var cityPos = cityMenu.GetComponent<RectTransform>().anchoredPosition3D;
        if (cityClicked)
        {
            cityMenu.GetComponent<RectTransform>().anchoredPosition3D = Vector3.Lerp(cityPos, new Vector3(740, 0, 1), hoverSpeed * (Time.time - tranistionTime));
        }

        if (!cityClicked)
        {
            cityMenu.GetComponent<RectTransform>().anchoredPosition3D = Vector3.Lerp(cityPos, new Vector3(1184, 0, 1), 2 * (Time.time - (tranistionTime+5)));
        }
    }
}
