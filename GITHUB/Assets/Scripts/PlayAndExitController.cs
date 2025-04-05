using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayAndExitController : MonoBehaviour
{
    public Button exitbtn;
    public Button playbtn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playbtn.onClick.AddListener(LoadLVL);
        exitbtn.onClick.AddListener(CloseGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadLVL() {
        SceneManager.LoadScene("SampleScene");
    }
    void CloseGame() {
        Application.Quit();
    }
}
