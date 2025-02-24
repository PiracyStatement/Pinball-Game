using TMPro;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class RestartButton : MonoBehaviour
{
    [SerializeField] private GameObject resetButton;
    private Button restartButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowRestartButton()
    {
        resetButton.SetActive(true);
    }
}
