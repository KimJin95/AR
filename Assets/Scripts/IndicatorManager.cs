using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation; //안드로이드 AR기능 지원
using UnityEngine.XR.ARSubsystems; //AR Raycast 사용가능

//AR카메라 바닥 인식시
//카메라 -> AR Raycast 를 쏜다
//레이를 맞은 바닥이라면
//지정했던 표적 오브젝트를 띄운다

public class IndicatorManager : MonoBehaviour
{

    public GameObject indicator;
    private ARRaycastManager arRaycastManager;

    public GameObject car;
    private GameObject placeCar;

    void Start()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
        indicator.SetActive(false);
    }

    private void TouchCreateCar()
    {
        if (indicator.activeInHierarchy && Input.touchCount > 0)
        {
            Touch firstTouch = Input.GetTouch(0);
            if (firstTouch.phase == TouchPhase.Began)
            {
                if (placeCar == null)
                {
                    placeCar = Instantiate(car, indicator.transform.position, indicator.transform.rotation);
                }
                else
                {
                    placeCar.transform.position = indicator.transform.position;
                }
            }

        }
    }
    private void FloorIndicator()
    {
        Vector2 screenSize = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f); // <- 정중앙

        List<ARRaycastHit> ARhits = new List<ARRaycastHit>();

        if (arRaycastManager.Raycast(screenSize, ARhits, TrackableType.Planes))
        {
            indicator.SetActive(true);

            indicator.transform.position = ARhits[0].pose.position;

            indicator.transform.rotation = ARhits[0].pose.rotation;

            indicator.transform.position += indicator.transform.up * 0.1f; //indicator 1/10 만큼 올리기
        }
        else
        {
            indicator.SetActive(false);
        }
    }

    void Update()
    {
        FloorIndicator();
        TouchCreateCar();
    }
}
