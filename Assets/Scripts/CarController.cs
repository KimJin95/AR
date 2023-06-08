using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//useing touch make object rotate

public class CarController : MonoBehaviour
{
    public Material carChangeMat;
    public GameObject colorPanel;

    void Start()
    {
        colorPanel.SetActive(false);
    }


    void Update()
    {
        CarRotate();
    }

    public void ChangeColor()
    {
        if (colorPanel.activeSelf)
        {
            if (EventSystem.current.currentSelectedGameObject.tag == "Color")
            {
                Color chColor = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
                carChangeMat.color = chColor;
            }
            colorPanel.SetActive(false); 
        }
    }

    private void CarRotate()
    {
        if (Input.touchCount > 0)
        {
            Touch firstTouch = Input.GetTouch(0);

            if (firstTouch.phase == TouchPhase.Moved)
            {
                Ray camRay = new Ray(Camera.main.transform.position, Camera.main.transform.forward * 0.1f);

                RaycastHit hit;

                if (Physics.Raycast(camRay, out hit, Mathf.Infinity, 1 << 8))
                {
                    Vector3 touchPos = firstTouch.deltaPosition;
                    transform.Rotate(transform.up, touchPos.x * -1);
                }
            }
        }
    }
}
