using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string levelName)
    {
        Application.LoadLevel(levelName);
    }
    public void quitRequest()
    {
        Application.Quit();
    }

}
