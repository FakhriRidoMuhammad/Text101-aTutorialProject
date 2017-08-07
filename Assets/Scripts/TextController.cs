using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {


    public Text text;
    private enum States {Cell_0,Lock_0,Bed_0,Cell_key,Bed_key,Lock_key,Freedom};
    private States myStates;


	void Start () {
        myStates = States.Cell_0;
	}
	
	void Update () {
		if (myStates == States.Cell_0)
        {
            Cell_0();            
        }
        if (myStates == States.Lock_0)
        {
            Lock_0();
        }
        if (myStates == States.Bed_0)
        {
            Bed_0();
        }
        
        if (myStates == States.Cell_key)
        {
            Cell_key();
        }
        if (myStates == States.Lock_key)
        {
            Lock_key();
        }
        if (myStates == States.Bed_key)
        {
            Bed_key();
        }
        if (myStates == States.Freedom)
        {
            Freedom();
        }
    }

    void Freedom()
    {
        text.text = "You are escaping the prison!\n\n" +
                    "Press F to finish the game\n";

        if (Input.GetKeyDown(KeyCode.F))
        {
            Application.LoadLevel("Result");
        }
        
    }

    void Bed_0()
    {
        text.text = "You are standing in front of the cell's bed\n\n" +
                    "Press L to walk into the locked cell door\n" +
                    "Press C to walk into the center of the cell room\n" +
                    "Press S to search the area for any usefull item\n";
                    
        if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.Lock_0;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myStates = States.Cell_0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.Bed_key;
        }
    }
    
    void Bed_key()
    {
        text.text = "You are standing in front of the cell's bed\n\n" +
                    "Press L to walk into the locked cell door\n" +
                    "Press C to walk into the center of the cell room\n" +
                    "You find a secret key under the bed!\n";

        if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.Lock_key;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            myStates = States.Cell_key;
        }
    }

    void Cell_0()
    {
        text.text = "You are in a prison cell\n\n"+
                    "Press L to walk into the locked cell door\n" +
                    "Press B to walk into the cell's bed\n";

        if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.Lock_0;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myStates = States.Bed_0;
        }
    }

    void Cell_key()
    {
        text.text = "You are in a prison cell\n\n" +
                    "Press L to walk into the locked cell door\n" +
                    "Press B to walk into the cell's bed\n" +
                    "You have the key to unlock the door\n";

        if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.Lock_key;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myStates = States.Bed_key;
        }
    }

    void Lock_0()
    {
        text.text = "You are standing in front of the locked door\n\n"+
                    "Press C to go back to the center of the Cell\n" +
                    "Press B to walk into the cell's bed\n";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myStates = States.Cell_0;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myStates = States.Bed_0;
        }
    }

    void Lock_key()
    {
        text.text = "You are standing in front of the locked door\n\n" +
                    "Press C to go back to the center of the Cell\n" +
                    "Press B to walk into the cell's bed\n" +
                    "Press U to unlock the cell door\n";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myStates = States.Cell_key;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myStates = States.Bed_key;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            myStates = States.Freedom;
        }
    }
}
