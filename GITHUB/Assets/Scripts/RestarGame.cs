using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestarGame : MonoBehaviour
{
    public Button restartbtn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        restartbtn.onClick.AddListener(RESTART);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RESTART() {
        SceneManager.LoadScene("HUB");
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
    }

}
