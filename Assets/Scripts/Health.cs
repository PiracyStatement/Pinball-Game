using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] Sprite[] healthSprites;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealth(int health)
    {
        SpriteRenderer sr = this.GetComponent<SpriteRenderer>();
        switch (health)
        {
            case 4:
                sr.sprite = healthSprites[1];
                break;
            case 3:
                sr.sprite = healthSprites[2];
                break;
            case 2:
                sr.sprite = healthSprites[3];
                break;
            case 1:
                sr.sprite = healthSprites[4];
                break;
            case 0:
                sr.sprite = healthSprites[5];
                break;
        }
    }
}
