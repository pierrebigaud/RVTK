using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drapeau : MonoBehaviour {

    public GameManager gameManager ;
    public bool activate;


    // Use this for initialization
    void Awake() {
        gameManager = Object.FindObjectOfType<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Player" && !activate)
        {
            activate = true;
            Debug.Log("win");
            gameManager.stateText.gameObject.SetActive(true);
            gameManager.stateText.state.text = "You win!";
            gameManager.Invoke("Victoire", 2);
            Destroy(gameObject);
        }
    }
}

