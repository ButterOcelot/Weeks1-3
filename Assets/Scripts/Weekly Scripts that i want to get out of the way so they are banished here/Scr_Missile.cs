using UnityEngine;

public class Scr_Missile : MonoBehaviour
{

    public Vector3 startValue;
    public Vector3 endValue;
    public float progress = 0;
    public Vector3 output;


    public float duration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime / duration;
        output = Vector3.Lerp(startValue, endValue, progress);
        transform.position = output;
    }
}
