using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathUI : MonoBehaviour {

	public void Restart()
    {
        SceneManager.LoadScene("1 level Scene");

    }
        
    public void ExitGame()
    {
        Application.Quit();
    }
}
