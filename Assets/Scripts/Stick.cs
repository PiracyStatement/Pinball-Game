using UnityEngine;

public class Stick : MonoBehaviour
{
    private Rigidbody2D ballRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballRB = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            ballRB.linearVelocity = Vector3.zero;
        }
    }
}
