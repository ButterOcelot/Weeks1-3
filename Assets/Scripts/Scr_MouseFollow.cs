using UnityEngine;
using UnityEngine.InputSystem;

public class Scr_MouseFollow : MonoBehaviour
{

    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePos = Mouse.current.position.ReadValue();

        Vector3 worldMousePos = gameCamera.ScreenToWorldPoint(currentMousePos);
        worldMousePos.z = 0;
        transform.position = worldMousePos;
    }
}
