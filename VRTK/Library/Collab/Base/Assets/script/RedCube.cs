using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : MonoBehaviour {

    //public GameObject player;
    public Text GameState;
    public float hauteur;
    public GameManager gameManager;
    // Use this for initialization
    void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("loose");
            GameState.gameObject.SetActive(true);
            GameState.text = "You loose!";
            gameManager.Invoke("Defaite", 2);
        }
    }

}
