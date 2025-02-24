using System.Collections;
using UnityEngine;

public class Boost : MonoBehaviour
{
    private GameObject gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gm = GameObject.Find("GameManager");
        StartCoroutine(ScaleInAndOut(5f, 0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            gm.GetComponent<GameManager>().ScoreChange(2);
            collision.gameObject.GetComponent<Rigidbody2D>().linearVelocity = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 7f, ForceMode2D.Impulse);
        }

        this.transform.position = new Vector3(Random.Range(-3.5f, 3.5f), Random.Range(-0.0f, -3.0f), 0.06f);
    }

    IEnumerator ScaleInAndOut(float duration, float scale)
    {
        var startScale = transform.localScale;
        var endScale = Vector3.one * scale;
        var elapsed = 0f;

        while (elapsed < duration)
        {
            var t = elapsed / duration;
            transform.localScale = Vector3.Lerp(startScale, endScale, t);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.localScale = endScale;

        yield return new WaitForSeconds(0.1f);

        if (scale > 1)
        {
            StartCoroutine(ScaleInAndOut(5f, 0.5f));
        }
        else
        {
            StartCoroutine(ScaleInAndOut(5f, 1.5f));
        }
    }
}
