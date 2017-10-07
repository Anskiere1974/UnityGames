using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

	public void levelLoader(string name) {
		Application.LoadLevel(name);
	}
	
	public void quitter() {
		Application.Quit();
	}
}
