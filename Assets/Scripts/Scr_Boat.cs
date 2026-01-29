using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Boat : MonoBehaviour
{
    public AnimationCurve curve;
    public float duration;
    public float output;
    Vector3 startingPos;

    private float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 floatingPos = transform.position;

        progress += Time.deltaTime / duration;
        output = curve.Evaluate(progress);
        floatingPos.y += output;
        transform.position = Vector3.Lerp(floatingPos, startingPos, progress);

        if (progress > 1f)
        {
            progress = 0f;
        }


    }
}