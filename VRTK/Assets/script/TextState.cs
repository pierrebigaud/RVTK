using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextState : MonoBehaviour {

    public GameManager gameManager;
    public Text state;

	// Use this for initialization
	void Awake () {
        gameManager = Object.FindObjectOfType<GameManager>();
        gameManager.stateText = this;
        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
