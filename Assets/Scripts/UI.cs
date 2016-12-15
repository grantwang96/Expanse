using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    bool over = false, notHovering = false, cityClicked = false;

    public GameObject regionDropDown, cityMenu;
    float hoverTime, tranistionTime;
    float clickTransitionSpeed = 30;

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
            cityMenu.GetComponent<RectTransform>().anchoredPosition3D = Vector3.MoveTowards(cityPos, new Vector3(740, 0, 1), clickTransitionSpeed);
        }

        if (!cityClicked)
        {
            cityMenu.GetComponent<RectTransform>().anchoredPosition3D = Vector3.MoveTowards(cityPos, new Vector3(1184, 0, 1), clickTransitionSpeed);
        }
    }
}
