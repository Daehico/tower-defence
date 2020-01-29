using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour {

    private Touch touch;
    private Vector2 gameObjectVector2Position;

    private void Start()
    {
        gameObjectVector2Position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        touch = Input.GetTouch(0);
    }

    private void Update ()
    {

		if(touch.phase == TouchPhase.Began && touch.position == gameObjectVector2Position)
        {
            Debug.Log("test");
        }
       
	}
}
