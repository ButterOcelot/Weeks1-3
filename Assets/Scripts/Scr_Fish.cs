using UnityEngine;

public class Scr_Fish : MonoBehaviour
{

    public float timerMax;
    public float timer;
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

        timer += 1 * Time.deltaTime;

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

        if (flipFlop == true)
        {
            fishPos.x += 1 * Time.deltaTime;
            if (flipHorizontally == true)
            {
                fishRot.y += 180;
                flipHorizontally = false;
            }

        }
        else if(flipFlop == false)
        {
            fishPos.x -= 1 * Time.deltaTime;
            if (flipHorizontally == false)
            {
                fishRot.y += 180;
                flipHorizontally = true;
            }
        }

        transform.eulerAngles = fishRot;
        transform.position = fishPos;

    }
}
