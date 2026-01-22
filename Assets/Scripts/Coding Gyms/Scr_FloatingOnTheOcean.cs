using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float timer = 0;
    public float speed;
    public AnimationCurve curve;
    float output;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += speed * Time.deltaTime;

        output = curve.Evaluate(timer);

        Vector2 yPos = transform.position;
        yPos.y = output;
        transform.position = yPos;

        if(timer > 1f)
        {
            timer = 0f;
        }
    }
}
