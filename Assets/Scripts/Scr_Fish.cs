using UnityEngine;

public class Scr_Fish : MonoBehaviour
{
    //These control a timer.
    public float timerMax;
    public float timer;
    
    //These reset the timer and alow the fish to flip back and forth.
    bool flipFlop;
    bool flipHorizontally;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fishPos = transform.position;
        Vector3 fishRot = transform.eulerAngles;
        //Creates vectors to store position and rotation. 

        timer += 1 * Time.deltaTime;
        //Timer that counts up evey second.

        if (timer > timerMax)
        {
            timer = 0;
            if (flipFlop == true)
            {
                flipFlop = false;
            }
            else if (flipFlop == false)
            {
                flipFlop = true;
            }
        }
        //When the timer hits it's max, toggle flip-flop on or off.

        if (flipFlop == true)
        {
            fishPos.x += 1 * Time.deltaTime;
            if (flipHorizontally == true)
            {
                fishRot.y += 180;
                flipHorizontally = false;
            }
            //If flip-flop is true, move the fish to the right and flip it to face the right.
        }
        else if(flipFlop == false)
        {
            fishPos.x -= 1 * Time.deltaTime;
            if (flipHorizontally == false)
            {
                fishRot.y += 180;
                flipHorizontally = true;
            }
            //If flip-flop is false, move the fish to the left and flip it to face the left.
        }

        transform.eulerAngles = fishRot;
        transform.position = fishPos;
        //Set the fish's position and rotation.

    }
}
