using System.Xml.Schema;
using UnityEngine;
using UnityEngine.InputSystem;

public class Scr_Mover : MonoBehaviour
{
    public float speed = 0.02f;
    public Camera gameCamera;
    public float xMax;
    public float xMin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       



    }

    // Update is called once per frame
    void Update()



    {
        Vector3 moverXPos = transform.position;
        moverXPos.x = moverXPos.x + speed;
        transform.position = moverXPos;

       Vector3 screenTransformPos = gameCamera.WorldToScreenPoint(transform.position);
       xMax = Screen.width;
       xMin = 0;


        if (screenTransformPos.x > xMax)
        {
            speed = -speed;
        }
        else if (screenTransformPos.x < xMin)
        {
            speed = -speed;
        }

        //test
        //I didnt really get this correctly the first time around, trying to set stuff directly to screenwidth instead of using the camera to swap between world and screen units. Once the class walkthrough was done though i got it working just fine.
    }
}
