using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.InputSystem;

public class RainbowFish : MonoBehaviour
{
   
    public SpriteRenderer spriteRenderer;
    Color fishColour;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);

        fishColour = new Color(Mathf.Lerp(worldMousePosition.x, worldMousePosition.y, 1),0.4f, 0.9f, 1);

        spriteRenderer.color = fishColour;



    }
}