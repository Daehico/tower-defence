﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InSceneUI : MonoBehaviour
{

    [SerializeField] private TMP_Text[] text;
    [SerializeField] private Statistics statistics;
    [SerializeField] private Base baseHP;

    	
	// Update is called once per frame
	void Update ()
    {
		for (int i = 0; i < text.Length; i++)
        {
            if(i == 0)
            {
                text[i].text = "HP:" + baseHP.heathPointOfBase;
            }
            if(i == 1)
            {
                text[i].text = "Goald:" + statistics.Gold.ToString(" 0");               
            }
            if (i == 2)
            {
                
                text[i].text = "Waves:" + statistics.CurentWawe.ToString() + "/" + statistics.AllWaweInLevel.ToString();
            }
        }
	}
}
