using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        print("Welcome to HNumber Wizard!");
        print("Pick a number from 1 to 1000 and don't tell me what it is!");

        int min = 1;
        int max = 1000;
        int guess = 500;

        print("Is the number higher, lower or equal to " + guess + "?");
        print("UP Arrow: your number is higher, DOWN Arrow: your number is lower, ENTER: it is equal!");
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("up"))
        {
            print("up arrow pressed!");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("down arrow pressed!");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("enter is pressed");
        }

    }
}
