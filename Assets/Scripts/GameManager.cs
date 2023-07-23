using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject bird;
    public bool isGameOver;
    [SerializeField] private GameObject tryAgainButton;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private TextMeshProUGUI scoreText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (isGameOver == true)
        {
            gameOverText.SetActive(true);
            tryAgainButton.SetActive(true);
        }
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = $"{score}";
    }

    
}
