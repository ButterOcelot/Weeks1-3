using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.InputSystem;

public class RainbowFish : MonoBehaviour
{
    //These store the fish's sprite and colour.
    public SpriteRenderer spriteRenderer;
    Color fishColour;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This just gets the position of the mouse in the world.
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);

        //This then converts the mouse position into a colour depending on physical location, either pink or blue.
        fishColour = new Color(Mathf.Lerp(worldMousePosition.x, worldMousePosition.y, 1),0.4f, 0.9f, 1);

        //This update's the fish's colour.
        spriteRenderer.color = fishColour;



    }
}