using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class MaskColor : MonoBehaviour
{
    public Material maskMat;
    public GameObject colorPanel;

    public void ColorChange()
    {
        if (EventSystem.current.currentSelectedGameObject.tag == "ColorBtn")
        {
            Color imageColor = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
            maskMat.color = imageColor; 
        }
        colorPanel.SetActive(false);
    }
}
