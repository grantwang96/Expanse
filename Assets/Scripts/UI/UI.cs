using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    bool over = false, notHovering = false, cityClicked = false;

    public Animator _cityClicked;
    GameObject cityMenu;
    float hoverTime, tranistionTime, clickTransitionSpeed = 450;


    // Buildings

	void Start () {
        _cityClicked = GetComponent<Animator>();
        cityMenu = GameObject.FindWithTag("cityMenu");
    }
	
	void Update () {
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
}
