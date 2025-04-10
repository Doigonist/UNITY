using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LVL_LOADER : MonoBehaviour
{
    public string WhatLvlToLoad;
    public Button btn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        btn.onClick.AddListener(LoadLVL);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadLVL() {
        SceneManager.LoadScene(WhatLvlToLoad);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
    }
}
