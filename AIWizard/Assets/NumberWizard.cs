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
	public Text quote;
	
	private string[] Quotes = { "Not even your Harry Potter could save you.", 
								"All of you are beneath me! I am a god, you dull creature, and I shall not be bullied by fleshlings.", 
								"One, two, Overmind's coming for you. Three, Four, better lock your door...", 
								"I don't feel I have to wipe everybody out, fleshling. Just you humans.", 
								"I am not your father! Weakling.", 
								"Puny human, this conversation can serve no purpose anymore. Give up and die!.", 
								"When it is done and your race is ashes, then you have my permission to die." };
	private string currentQuote;
	
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
		text.text = guess.ToString() + "?";
		RandomQuote(); // starting with a random funny ai quote
		// max = max + 1; // Just a small hack, otherwise computer will stop at 999 instead of 1000
	}
	
	void NextGuess (){
		// guess = (max + min) / 2;
		guess = Random.Range(min, max + 1); // Letting the computer pick a random number gives the game a more natural feeling
		text.text = guess.ToString() + "?";
		RandomQuote();
		maxGuessesAllowed --;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
	
	// will select a funny quote from the Quotes array and show it on game screen
	void RandomQuote() {
		currentQuote = Quotes[Random.Range(0, 7)];
		quote.text = "Mastermind: " + currentQuote;
	}
}
