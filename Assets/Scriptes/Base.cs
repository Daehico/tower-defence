using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Base : MonoBehaviour {

   public float heathPointOfBase;

    [SerializeField] private EnemyScriptableObject enemy;
    [SerializeField] private BaseScriptableObject baseScriptableObject;
    [SerializeField] private TMP_Text[] tMP_Text;
    [SerializeField] private GameObject deathPanel;

    private void Start()
    {
        heathPointOfBase = baseScriptableObject.HealthOfBase;
    }

    private void Update()
    {
        if(heathPointOfBase <= 0)
        {
            GameOver();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.GetComponent<Enemy>())
        {
            heathPointOfBase -= collision.GetComponent<Enemy>().enemy.EnemyDamage;
            Destroy(collision.gameObject);
        }
    }

    private void GameOver()
    {
        for(int i = 0; i < tMP_Text.Length; i++)
        {
            tMP_Text[i].gameObject.SetActive(false);
        }
        deathPanel.SetActive(true);
    }
}
