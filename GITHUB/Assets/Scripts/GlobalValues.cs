using NUnit.Framework;
using TMPro;
using UnityEngine;

public class GlobalValues : MonoBehaviour
{
    public static int Score;
    public TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Score.ToString();
    }
}
