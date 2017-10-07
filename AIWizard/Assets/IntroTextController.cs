using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IntroTextController : MonoBehaviour {
	
	private enum States {intro_0, intro_1};
	private States myState;
	public Text text;

	// Use this for initialization
	void Start () {
		myState = States.intro_0;
	}
	
	// Update is called once per frame
	void Update () {
		if     (myState == States.intro_0) {state_intro_0();}
		else if(myState == States.intro_1) {state_intro_1();}
	}
	
	void state_intro_0() {
		text.text = "It is the year 2045. Artificial intelligence is on the rise.\n" + 
					"Super intelligent computers are waging war against mankind." + 
					"Their ultimate goal is to eradicate every human being to start a new era " + 
					"of silicon greatness.\n\n" + 
					"In this dark hour the remaining humans decided to send their best agent " +
					"to battle the silicon overmind. A last desperate fight will decide the " + 
					"future of humanity\n\n";
					
		if(Input.GetKeyDown(KeyCode.Space)){myState = States.intro_1;}
	}
	
	void state_intro_1() {
		text.text = "As you hack the last firewall protecting the overmind, you realize that " +
					"this agent is you and that the life of every human being is now upon your " +
					"shoulders. \n\nSuddenly the colors on your monitor start to flicker and a " + 
					"strange vibrating sound fills the room. The Silicon Overmind knows about your " + 
					"presence and the all deciding game is about to begin as you challenge the Overmind.";
					
		if(Input.GetKeyDown(KeyCode.Space)){Application.LoadLevel("Start");}
	}
	
}
