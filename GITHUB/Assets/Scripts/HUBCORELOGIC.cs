using UnityEngine;

public class HUBCORELOGIC : MonoBehaviour
{
    public Canvas canvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MovementController.ifControlsEnabled = true;
        LevelGenerator.y = 18;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        canvas.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canvas.enabled = false;
    }
}
