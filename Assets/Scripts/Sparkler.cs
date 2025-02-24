using System.Collections;
using UnityEngine;

public class Sparkler : MonoBehaviour
{
    private Rigidbody2D ballRB;
    private bool isHolding = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballRB = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isHolding) // Keep the ball in the anomaly
        {
            ballRB.transform.position = this.transform.position;
        }

        transform.Rotate(Vector3.forward * Time.deltaTime * -10);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            ballRB.linearVelocity = Vector3.zero;
            ballRB.transform.position = this.transform.position;
            ballRB.AddTorque(-30f);

            StartCoroutine(Yeetus());
        }
    }

    IEnumerator Yeetus()
    {
        isHolding = true;

        yield return new WaitForSeconds(3);

        isHolding = false;
    }
}
