using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    [SerializeField] TextMeshProUGUI scoreText;
    int guess;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
        score = 0;
        max = max + 1;
    }

   public void OnPressHigher()
   {
        min = guess + 1;
        NextGuess();
   }

   public void OnPressLower()
   {
        max = guess - 1;
        NextGuess();
   }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
        scoreText.text = score.ToString();
        score = score + 1;
        
    }

}