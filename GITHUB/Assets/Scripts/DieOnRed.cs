using UnityEngine;

public class DieOnRed : MonoBehaviour
{
    public Canvas LOSESCREEN;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player") {
            MovementController.ifControlsEnabled = false;
            Lose();
        }
    }
    void Lose() {
        LOSESCREEN.enabled = true;
    }
}
