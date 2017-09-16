using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	void OnGUI(){

		if (GUI.Button (new Rect (10, 10, 100, 45), "Roll A Ball")) {
			Application.LoadLevel(1);
		}
		if (GUI.Button (new Rect (10, 65, 100, 45), "Boxes")) {
			Application.LoadLevel(2);
		}

	}
}
