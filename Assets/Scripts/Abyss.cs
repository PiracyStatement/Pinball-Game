using UnityEngine;

public class Abyss : MonoBehaviour
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.GetComponent<GameManager>().LosePoint();
    }
}
