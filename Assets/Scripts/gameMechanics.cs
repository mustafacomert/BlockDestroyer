using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameMechanics : MonoBehaviour {

    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] int guess;
    [SerializeField] TextMeshProUGUI guessText;

	// Use this for initialization
	void Start () {
        gameStart();
    }
	
    void gameStart()
    {
        ++max;
        nextGuess();
    }
	public void Increase()
    {
        min = guess;
        nextGuess();
    }

    public void Decrease()
    {
        max = guess;
        nextGuess();
    }

    public void nextGuess()
    {
        //guess = (min + max) / 2;
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
}
