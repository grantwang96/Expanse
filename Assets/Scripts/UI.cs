using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    bool over = false, cityClicked = false;

    public GameObject regionDropDown, cityMenu;
    private Vector3 hoverScale;
    float hoverTime, tranistionTime;
    public float hoverSpeed = 7f, clickTransitionSpeed = 10f;

	void Start () {
        hoverScale = Vector3.Lerp(new Vector3(0, 0, 1), new Vector3(1,1,1), 0.5f);
    }
	
	void Update () {

        // Debug.Log(cityClicked);

        if (over)
        {
            regionDropDown.GetComponent<RectTransform>().localScale = Vector3.Lerp(new Vector3(0, 0, 1), new Vector3(1, 1, 1), hoverSpeed * (Time.time - hoverTime));
        } else
        {
            regionDropDown.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 1);
        }

          CityMenu();
    }

    public void OnMouseOver()
    {
        over = true;
        hoverTime = Time.time;
    }

    public void OnMouseExit()
    {
        over = false;
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
            Debug.Log(cityClicked);
        }
    }
}
