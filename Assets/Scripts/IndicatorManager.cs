using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation; //�ȵ���̵� AR��� ����
using UnityEngine.XR.ARSubsystems; //AR Raycast ��밡��

//ARī�޶� �ٴ� �νĽ�
//ī�޶� -> AR Raycast �� ���
//���̸� ���� �ٴ��̶��
//�����ߴ� ǥ�� ������Ʈ�� ����

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
        Vector2 screenSize = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f); // <- ���߾�

        List<ARRaycastHit> ARhits = new List<ARRaycastHit>();

        if (arRaycastManager.Raycast(screenSize, ARhits, TrackableType.Planes))
        {
            indicator.SetActive(true);

            indicator.transform.position = ARhits[0].pose.position;

            indicator.transform.rotation = ARhits[0].pose.rotation;

            indicator.transform.position += indicator.transform.up * 0.1f; //indicator 1/10 ��ŭ �ø���
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
