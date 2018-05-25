using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public int numberLevel;
    public TextState stateText;
    public AudioSource soundGame;
    public AudioListener soundListener;
    public GameObject player;

    // Use this for initialization
    void Awake () {
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void Victoire()
    {
        //fait changer de niveau
        numberLevel++;
        SceneManager.LoadScene("level" + numberLevel);
    }
    public void Defaite()
    {
        //refait le niveau
        SceneManager.LoadScene("level" + numberLevel);
    }
}
