using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Statistics
{

	public static float Gold { get; private set; }
    
    public static int CurentWave { get; private set; }
    

    public static void AddGold(float _gold)
    {
        Gold += _gold;
    }
    
    public static void AddCurrentWave(int _curentWave)
    {
        CurentWave += _curentWave;
    }

}
