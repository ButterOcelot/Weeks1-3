using UnityEngine;

public class Scr_Teleporter : MonoBehaviour
{
    public float duration;
    public float teleportDelay;
    float savedTeleDelay;
    public Camera gameCamera;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        savedTeleDelay = teleportDelay;
    }

    // Update is called once per frame
    void Update()
    {
        teleportDelay -= duration * Time.deltaTime;

        if (teleportDelay < 1f)
        {
            Vector2 teleportPos = Random.insideUnitCircle * gameCamera.ScreenToWorldPoint(transform.position);
            transform.position = teleportPos;
            teleportDelay = savedTeleDelay;
        }
        


    }
}
