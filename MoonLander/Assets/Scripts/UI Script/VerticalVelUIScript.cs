﻿using UnityEngine;
using UnityEngine.UI;

public class VerticalVelUIScript : MonoBehaviour {

	UImanager parentScript;

	Text verticalVelCount;
	float naveVerticalVel;

	void Awake () {
		verticalVelCount = GetComponent<Text> ();
		parentScript = transform.GetComponentInParent<UImanager> ();
	}

	void Update () {
		naveVerticalVel = parentScript.naveVerticalVel;

		if (naveVerticalVel > 999)
			verticalVelCount.text = "999";
		else 
		{
			naveVerticalVel = (int)naveVerticalVel;

			if (naveVerticalVel < 1)
				verticalVelCount.text = "000";
			else if (naveVerticalVel < 10)
				verticalVelCount.text = "00" + naveVerticalVel.ToString ();
			else if (naveVerticalVel < 100)
				verticalVelCount.text = "0" + naveVerticalVel.ToString ();
			else
				verticalVelCount.text = naveVerticalVel.ToString ();
		}
	}
}
