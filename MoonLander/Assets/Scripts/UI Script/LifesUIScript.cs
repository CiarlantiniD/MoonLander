﻿using UnityEngine;
using UnityEngine.UI;

public class LifesUIScript : MonoBehaviour {

	Text lifesCount;
	int lifes = 99;

	void Awake () {
		lifesCount = GetComponent<Text> ();
	}
		
	void Update () {
		lifes = PlayerPrefs.GetInt("Lifes");

		if (lifes < 0)
			lifesCount.text = "x 0";
		else if (lifes > 99)
			lifesCount.text = "x Ilimit";
		else
			lifesCount.text = "x " + lifes.ToString();
	}
}
