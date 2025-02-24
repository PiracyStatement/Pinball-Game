using Unity.VisualScripting;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private GameObject gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            gm.GetComponent<GameManager>().ScoreChange(1);
        }
    }
}
