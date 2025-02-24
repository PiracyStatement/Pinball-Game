using UnityEngine;

public class Ball : MonoBehaviour
{
    private AudioSource[] audioSources;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSources = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetBall()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector3.zero;
        this.transform.position = new Vector3(-1.65f, 2, -1);
        audioSources[1].Play();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "FlipperLeft" || collision.gameObject.name == "FlipperRight")
            audioSources[0].Play();
        else if (collision.gameObject.GetComponent<Bounce>() != null)
            audioSources[2].Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Warp")
            audioSources[3].Play();
    }
}
