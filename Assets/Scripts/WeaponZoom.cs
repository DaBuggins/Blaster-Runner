using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedOutView = 60f;
    [SerializeField]  float zoomedInView = 20f;
    [SerializeField]  float zoomedOutSens = 2f;
    [SerializeField]  float zoomedInSens = .5f;






    bool zoomedInToggle = false;


    void OnDisable() 
    {
        ZoomOut();   
    }




    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.fieldOfView = zoomedOutView;
        fpsController.mouseLook.XSensitivity = zoomedOutSens;
        fpsController.mouseLook.YSensitivity = zoomedOutSens;
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedInView;
        fpsController.mouseLook.XSensitivity = zoomedInSens;
        fpsController.mouseLook.YSensitivity = zoomedInSens;
    }




}
