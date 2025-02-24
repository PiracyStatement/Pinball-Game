using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject b;
    private GameObject healthHUD;
    private GameObject scoreManager;
    private GameObject resetButton;

    private AudioSource audioSource;

    public int lives = 5;
    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        b = GameObject.Find("Ball");
        healthHUD = GameObject.Find("hud");
        scoreManager = GameObject.Find("Text (TMP)");
        resetButton = GameObject.Find("Canvas");

        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LosePoint()
    {
        lives--;
        //Debug.Log(lives);

        if (lives > 0)
        {
            b.GetComponent<Ball>().ResetBall();
        }
        else if (lives <= 0)
        {
            resetButton.GetComponent<RestartButton>().ShowRestartButton();
            audioSource.Play();
        }

        healthHUD.GetComponent<Health>().UpdateHealth(lives);
    }

    public void ScoreChange(int val)
    {
        score += val;
        //Debug.Log(score);
        scoreManager.GetComponent<Score>().UpdateScoreText(score);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
