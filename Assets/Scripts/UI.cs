using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    bool over = false, notHovering = false, cityClicked = false;

    public Animator _cityClicked;
    public GameObject cityMenu;
    float hoverTime, tranistionTime;
    float clickTransitionSpeed = 40;

	void Start () {
        _cityClicked = GetComponent<Animator>();
    }
	
	void Update () {

        CityMenu();
        _cityClicked.SetBool("cityClicked", cityClicked);
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
