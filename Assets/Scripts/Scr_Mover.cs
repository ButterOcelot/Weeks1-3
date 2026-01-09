using UnityEngine;

public class Scr_Mover : MonoBehaviour
{
    public float speed = 0.02f;
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
        if(transform.position.x < xMin)
        {
            speed = -speed;
        }
        else if(transform.position.x > xMax)
        {
            speed = -speed;
        }
        moverXPos.x = moverXPos.x + speed;
        transform.position = moverXPos;

        //Im not really sure what to put here for the comment, but during the exercise i just made it so if the position of mover was greater than the max or smaller than the min it inverts the speed.
    }
}
