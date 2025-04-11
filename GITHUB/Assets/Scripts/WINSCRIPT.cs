using UnityEngine;
using UnityEngine.SceneManagement;

public class WINSCRIPT : MonoBehaviour
{
    public string SCENETOLOAD = "HUB";
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
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "Player_New") { 
            MovementController.ifControlsEnabled = false;
            SceneManager.LoadScene(SCENETOLOAD);
        }
    }
}
