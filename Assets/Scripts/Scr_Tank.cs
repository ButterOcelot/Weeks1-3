using UnityEngine;


public class Scr_ : MonoBehaviour
{

    public Vector3 tankPosition;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        bool LeftIsPressed = Keyboard.current.leftArrowKey.isPressed;
        bool RightIsPressed = Keyboard.current.rightArrowKey.isPressed;

        if (LeftIsPressed == true)
        {
            tankPosition.x -= speed;
        }

        if (RightIsPressed == true)
        {
            tankPosition.x += speed;
        }

        transform.position = tankPosition;

    }
