using TMPro;
using UnityEngine;

public class TipObjectsLogic : MonoBehaviour
{
    public string tip;
    public Canvas canvas;
    public TMP_Text text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.text = tip;
        canvas.enabled = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canvas.enabled = false;
    }
}
