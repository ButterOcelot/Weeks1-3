using UnityEngine;
using UnityEngine.InputSystem;

public class Scr_Looker : MonoBehaviour
{

    public float rotationSpeed;
    public float zMax;
    public float zMin;

    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 currentRotation = transform.eulerAngles;
        //currentRotation.z += rotationSpeed * Time.deltaTime;
        //transform.eulerAngles = currentRotation;

        //if (transform.eulerAngles.z > zMax)
        //{
        //    rotationSpeed = -rotationSpeed;
        //}
        //else if (transform.eulerAngles.z < zMin)
        //{
        //    rotationSpeed = -rotationSpeed;
        //}

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        transform.up = worldMousePosition;

            Debug.Log("FUCK");
    }
}
