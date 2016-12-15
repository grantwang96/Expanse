using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hoverMenu : MonoBehaviour {

    bool over = false, notHovering = false;

    public GameObject regionDropDown;
    float hoverTime, tranistionTime;
    public float hoverSpeed = 10, clickTransitionSpeed = 10f;

    float parentX;

    void Update()
    {

        parentX = GetComponentInParent<RectTransform>().localPosition.x;
        
        if (over)
        {
            regionDropDown.GetComponent<RectTransform>().localPosition = Vector3.MoveTowards(regionDropDown.GetComponent<RectTransform>().localPosition, new Vector3(parentX, 331, 1), hoverSpeed);
        } 

        if (notHovering)
        {
            regionDropDown.GetComponent<RectTransform>().localPosition = Vector3.MoveTowards(regionDropDown.GetComponent<RectTransform>().localPosition, new Vector3(parentX, 536, 1), hoverSpeed);
        }
    }
    
    public void OnMouseOver()
    {
        parentX = GetComponentInParent<RectTransform>().localPosition.x;
        over = true;
        Debug.Log(over);
    }

    public void OnMouseExit()
    {
        parentX = GetComponentInParent<RectTransform>().localPosition.x;
        Debug.Log(over);
        over = false;
        notHovering = true;
    }
}
