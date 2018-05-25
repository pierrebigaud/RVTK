using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Fall : MonoBehaviour
{

    public float hauteur; 
    public GameManager gameManager;
    public bool activate, soundLaserActivate;

    // Use this for initialization
    void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        gameManager.player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.y < -10)
        if (transform.position.y < hauteur && !activate)
        {
            Debug.Log("loose");
            activate = true;
            gameManager.stateText.gameObject.SetActive(true);
            gameManager.stateText.state.text = "You loose!";
            gameManager.Invoke("Defaite", 2);
            Destroy(gameObject);
        }

    }
}
