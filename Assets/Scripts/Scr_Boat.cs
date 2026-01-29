using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Boat : MonoBehaviour
{
    public AnimationCurve curve;
    //Animation curve to control the boat and waves bobbing up and down.

    public float duration;
    public float output;
    Vector3 startingPos;
    //These control the boat's position.

    private float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingPos = transform.position;
        //This stores the original position of the boat on start.
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 floatingPos = transform.position;
        //This stores the boat's position on the previous frame.

        progress += Time.deltaTime / duration;
        output = curve.Evaluate(progress);
        floatingPos.y += output;
        transform.position = Vector3.Lerp(floatingPos, startingPos, progress);
        //This uses the animation curve to move the boat up and down.

        if (progress > 1f)
        {
            progress = 0f;
        }
        //This resets the curve on completion.

    }
}