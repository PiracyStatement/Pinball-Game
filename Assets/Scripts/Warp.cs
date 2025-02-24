using UnityEngine;

public class Warp : MonoBehaviour
{
    private GameObject gm;
    private Rigidbody2D ballRB;
    public float grav = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballRB = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
        gm = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * 45);

        var dirOfBallFromWarp = ((Vector2)transform.position - ballRB.position).normalized;

        ballRB.AddForce(dirOfBallFromWarp * grav);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            gm.GetComponent<GameManager>().ScoreChange(3);
        }
    }
}
