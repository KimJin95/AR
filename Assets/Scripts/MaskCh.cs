using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class MaskCh : MonoBehaviour
{
    private ARFaceManager aRFaceManager;
    public Material[] maskMat;
    private GameObject ChangeMaskObj;


    void Start()
    {
        aRFaceManager = GetComponent<ARFaceManager>();
    }


    void Update()
    {

    }

    public void ChangeMaskBtn(string maskName)
    {
        if (maskName == "A_Mat")
        {
            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                   .GetComponent<MeshRenderer>().material = maskMat[0];

            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                .transform.localScale = new Vector3(0.25f, 0.27f, 1);
        }

        if (maskName == "B_Mat")
        {
            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                   .GetComponent<MeshRenderer>().material = maskMat[1];

            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
             .transform.localScale = new Vector3(0.25f, 0.27f, 1);
        }

        if (maskName == "C_Mat")
        {
            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                   .GetComponent<MeshRenderer>().material = maskMat[2];

            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
             .transform.localScale = new Vector3(0.25f, 0.27f, 1);
        }

        if (maskName == "D_Mat")
        {
            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                   .GetComponent<MeshRenderer>().material = maskMat[3];

            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
             .transform.localScale = new Vector3(0.25f, 0.27f, 1);
        }

        if (maskName == "E_Mat")
        {
            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                   .GetComponent<MeshRenderer>().material = maskMat[4];

            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
             .transform.localScale = new Vector3(0.25f, 0.27f, 1);
        }

        if (maskName == "F_Mat")
        {
            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                   .GetComponent<MeshRenderer>().material = maskMat[5];

            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
             .transform.localScale = new Vector3(0.25f, 0.27f, 1);
        }

        if (maskName == "G_Mat")
        {
            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                   .GetComponent<MeshRenderer>().material = maskMat[6];

            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
             .transform.localScale = new Vector3(0.25f, 0.27f, 1);
        }

        if (maskName == "H_Mat")
        {
            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                   .GetComponent<MeshRenderer>().material = maskMat[7];

            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
             .transform.localScale = new Vector3(0.25f, 0.27f, 1);
        }

        if (maskName == "I_Mat")
        {
            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                   .GetComponent<MeshRenderer>().material = maskMat[8];

            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
             .transform.localScale = new Vector3(0.25f, 0.27f, 1);
        }

        if (maskName == "J_Mat")
        {
            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                   .GetComponent<MeshRenderer>().material = maskMat[9];

            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
             .transform.localScale = new Vector3(0.25f, 0.27f, 1);
        }

        if (maskName == "K_Mat")
        {
            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
                   .GetComponent<MeshRenderer>().material = maskMat[10];

            aRFaceManager.facePrefab.transform.GetChild(0).gameObject
             .transform.localScale = new Vector3(0.75f, 0.27f, 1);
        }


    }
}
