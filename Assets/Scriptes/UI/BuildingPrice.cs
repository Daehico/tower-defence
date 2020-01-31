using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildingPrice : MonoBehaviour {

    [SerializeField] private TMP_Text[] text;
    [SerializeField] private Towers[] towers;

    private void Update()
    {
        for(int i = 0; i < text.Length; i++)
        {
           text[i].text = towers[i].BuildPrice.ToString();
        }
    }
}
