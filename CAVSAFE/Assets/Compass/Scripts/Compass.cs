using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{

    /*
    public GameObject cam;
    void Start()
    {

        cam = Camera.main.gameObject;
        Input.location.Start();
        Input.compass.enabled = true;
    }

    void Update()
    {

        Quaternion cameraRotation = Quaternion.Euler(0, cam.transform.rotation.eulerAngles.y,0);
        Quaternion compass = Quaternion.Euler( 0,-Input.compass.trueHeading, 0);

        Quaternion north = Quaternion.Euler(0, cameraRotation.eulerAngles.y + compass.eulerAngles.y, 0);
        transform.rotation = north;
    }
    */


   public GameObject cam;
   

    void Start()
    {

        cam = Camera.main.gameObject;
        Input.location.Start();
        Input.compass.enabled = true;
    }

    void Update()
    {
        Quaternion cameraRotation = Quaternion.Euler(0, cam.transform.rotation.eulerAngles.y, 0);
        Quaternion compass = Quaternion.Euler(0, -Input.compass.trueHeading, 0);
        Quaternion north = Quaternion.Euler(0, cameraRotation.eulerAngles.z+ compass.eulerAngles.y, 0);
        transform.rotation = north;
    }
   
}
