using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public static int y = 18;
    public  List<GameObject> list = new List<GameObject>();
    private GameObject newprefab;
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
        if (collision.gameObject.tag == "Player") {
            Destroy(gameObject);
            newprefab = Instantiate(list[0]);
            newprefab.transform.position = new Vector3(0,y,0);
            LevelGenerator.y += 30;
        }
    }
}
