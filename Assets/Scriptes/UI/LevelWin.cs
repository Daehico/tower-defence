using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelWin : MonoBehaviour {

    [SerializeField] private GameObject winPanel;

   public void WinGame()
    {
        winPanel.SetActive(true);
    }
}
