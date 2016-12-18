using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hoverMenu : MonoBehaviour {

    bool over = false;

    public GameObject regionDropDown;
    float hoverTime, tranistionTime;
    float hoverSpeed = 20f;

    float parentX;

    void Update()
    {

        parentX = GetComponentInParent<RectTransform>().localPosition.x;
        
        if (over)
        {
            regionDropDown.GetComponent<RectTransform>().localPosition = Vector3.MoveTowards(regionDropDown.GetComponent<RectTransform>().localPosition, new Vector3(parentX, 331, 1), hoverSpeed);
        } 

        if (!over)
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
    }
}
