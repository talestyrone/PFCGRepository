using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text myText;
    // Use this for initialization

    enum States
    {
        cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, corridor_0,
        floor, stairs_0, closet_door, corridor_1, stairs_1, in_closet, stairs_2, corridor_2, corridor_3, courtyard
    };

    States myState;

    void Start() {
        myState = States.cell;
    }

    // Update is called once per frame
    void Update() {
        if (myState == States.cell)
        {
            Cell();
        }

        else if (myState == States.sheets_0)       { sheets_0();       }
        else if (myState == States.mirror)         { mirror();         } 
        else if (myState == States.lock_0)         { lock_0();         }
        else if (myState == States.cell_mirror)    { cell_mirror();    }
        else if (myState == States.sheets_1)       { sheets_1();       }
        else if (myState == States.lock_1)         { lock_1();         }
        else if (myState == States.corridor_0)     { corridor_0();     }

    }

    void Cell()
    {
        myText.text =
            "You are in a prison cell, and you want to escape. "
            + "\nThere are some dirty sheets on the bed, a mirror on the wall, " +
            "and the door is locked from the outside.\n\n" +
            "Press S to view the Sheets, M to view the Mirror and L to " +
            "examine the lock.";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;

        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
    }

    void sheets_0()
    {
        myText.text = "You examine the sheets!\nThey are extremely dirty..\nYou have no use of them..\n\nPress R to continue examining the cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    void cell_mirror()
    {
        myText.text = "You are still in your cell and STILL want to escape!\n There are some dirty sheets on the bed, a mark where the mirror was\n and the door is still locked.\nPress S to view the sheets or L to view the lock.";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }

    void mirror()
    {
        myText.text = "You examine the mirror!\nYou take a broken shard, this may be of use..\nPress T to take the mirror or R to continue examining the cell..";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }

        else if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }
    }

    void lock_0()
    {
        myState = States.lock_0;
        myText.text = "You examine the lock!\nThere's nothing you can do about it..\nMaybe if you could see the keypad, you might be able\nto figure it out using the dirty fingerprints..\nmaybe I could find something to help..\nPress R to continue examining the cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    
    void sheets_1()
    {
        myText.text = "Holding a shard of the mirror won't make them look any better..\nPress R to continue examining the cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void lock_1()
    {
        myText.text = "Using the shard of the mirror you can see the keypad and notice a dirty keypad with some clean buttons..\n You make out the numbers used and attempt the possible codes..\n" +
            "The door clicks open!" + "Press D to open the door, Press R to return to the cell..";

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.corridor_0;
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void corridor_0()
    {
        myText.text = "You are finally FREE..or so you think?\nThe floor is dirty, there's a closet and light coming from the stairs..\nPress C to examine the closet door, F to rummage around the floor or S to check upstairs..";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.closet_door;
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.floor;   
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_0;
        }
    }

    void closet_door()
    {
        myText.text
    }
}
