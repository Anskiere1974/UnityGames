using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// declaring some variables
	int max; // max is the highest number a player possibly can pick
	int min;  // min is the lowest number a player possibly can pick
	int guess; // guess holds the guess of the computer, we start with 500
	public int maxGuessesAllowed = 10; // the number of guesses the computer may take, before he loses the Game.
	public Text text;
	
	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	public void GuessHigher() {
		min = guess;
		NextGuess();
	}
	
	public void GuessLower() {
		max = guess;
		NextGuess ();
	}
	
	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
		text.text = guess.ToString();
		max = max + 1; // Just a small hack, otherwise computer will stop at 999 instead of 1000
	}
	
	void NextGuess (){
		// guess = (max + min) / 2;
		guess = Random.Range(min, max); // Letting the computer pick a random number gives the game a more natural feeling
		text.text = guess.ToString();
		maxGuessesAllowed --;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
