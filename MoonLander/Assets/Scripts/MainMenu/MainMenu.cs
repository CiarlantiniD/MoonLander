﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	MainManager mainManager;

	// Save Configuration
	private int haveSave = 1; // CONFIGURATION REVISAR
	private int intTranforText = 1;
	private int optionSlectMaxArgument = 2; // 1 Yes / 2 No

	private int optionSlect = 0;
	private int maxOption = 3;

	Color selectColor = Color.white;
	Color notSelectColor = Color.gray;

	Text[] optionsText;

	void Awake () {
		mainManager = transform.GetComponentInParent<MainManager> ();

		optionsText = new Text[4];

		optionsText[0] =transform.GetChild(0).GetComponent<Text>();
		optionsText[1] =transform.GetChild(1).GetComponent<Text>();
		optionsText[2] =transform.GetChild(2).GetComponent<Text>();
		optionsText[3] =transform.GetChild(3).GetComponent<Text>();

		HaveSave();
		TranforText ();
	}

	void TranforText(){
		for (int i = intTranforText; i <= maxOption; i++) {
			if (i == optionSlect)
				optionsText [i].color = selectColor;
			else
				optionsText [i].color=notSelectColor;
		}
	}


	void Update () {
		 
		if (Input.GetKeyDown (KeyCode.UpArrow) && optionSlect >= optionSlectMaxArgument) {
			optionSlect -= 1;
			TranforText ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow) && optionSlect < maxOption) {
			optionSlect += 1;
			TranforText ();
		}



		if (Input.GetKeyDown (KeyCode.Space)) {
			switch (optionSlect) {
			case 0:
				print ("Continuar Juego");
				break;
			case 1:
				print ("Nuevo Juego");
				break;
			case 2:
				print ("Opciones Juego");
				mainManager.ChangeMenu (2);
				break;
			case 3:
				print ("Salir Juego");
				break;
			default:
				print ("Salir Juego"); // revisar
				break;
			}
		}
	}


	void HaveSave(){
		if (haveSave == 1) {
			print ("Tengo Save");
			intTranforText = 0;
			optionSlectMaxArgument = 1;
			optionSlect = 0;
		}
		else {
			print ("No tengo Save");
			intTranforText = 1;
			optionSlectMaxArgument = 2;
			optionSlect = 1;
			optionsText [0].color=Color.clear;
		}

	}

}
