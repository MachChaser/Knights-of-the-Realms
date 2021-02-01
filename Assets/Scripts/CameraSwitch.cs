using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    void Start()
    {
        cam.SetActive(false);
    }


    public GameObject cam;
    void OnMouseDown()
    {
        Debug.Log("OK");
        cam.SetActive(true);
    }

}
