using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	// declaring some variables
	int max; // max is the highest number a player possibly can pick
	int min;  // min is the lowest number a player possibly can pick
	int guess; // guess holds the guess of the computer, we start with 500
	int counter; // counter will hold the number of guesses the computer needs to find your number
	
	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print("Up Arrow key was pressed");
			min = guess;
			NextGuess();
			}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			// print("Down Arrow key was pressed");
			max = guess;
			NextGuess ();
		}
		else if (Input.GetKeyDown(KeyCode.Return)){
			print("Hurra! I won!");
			print ("It took me only " + counter +" guesses to find your number.");
			StartGame ();
		}
	}
	
	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
		counter = 0;
		print ("======================");
		print("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		// Now tell the player about the possible numbers range
		print("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		max = max + 1; // Just a small hack, otherwise computer will stop at 999 instead of 1000
		
		// The computer makes his first guess
		print ("Is the number higher or lower then " + guess + "?");
		print ("Press: Up Arrow for higher, Down Arrow for lower and Return for equal.");
	}
	
	void NextGuess (){
		// guess = (max + min) / 2;
		guess = Random.Range(min, max); // Letting the computer pick a random number gives the game a more natural feeling
		print ("Higher or lower than " + guess + "?");  // Computer makes a new guess
		print ("Press: Up Arrow for higher, Down Arrow for lower and Return for equal."); // Repeating the instructions
		counter ++; // after every unsuccessfull guess we increase our counter by 1
	}
}
