using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Wave Data", menuName = "Wave Data", order = 51)]
public class WavesScriptableObject : ScriptableObject
{
    [SerializeField] private int idOfWave;
    [SerializeField] private float timeOfWaves;
    [SerializeField] private float timeBeetweenSpaunOfMob;



    public int IdOfWave
    {
        get
        {
            return idOfWave;
        }  
    }

    public float TimeOfWaves
    {
        get
        {
            return timeOfWaves;
        }    
    }

    public float TimeBeetweenSpaunOfMob
    {
        get
        {
            return timeBeetweenSpaunOfMob;
        }
    }
}
