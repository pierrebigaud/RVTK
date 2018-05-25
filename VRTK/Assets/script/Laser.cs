using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Laser : MonoBehaviour {

    public GameManager gameManager;
    public VRTK_ControllerEvents touch;
    public bool activate;
    public AudioClip lasersound;

    // Use this for initialization
    void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        activate = false;
    }

    // Update is called once per frame
    void Update () {
        Debug.Log(touch.touchpadPressed);
        if (touch.touchpadPressed && activate==false)
        {
            gameManager.soundGame.clip = lasersound;
            gameManager.soundGame.Play();
            activate = true;
        }
        if(!touch.touchpadPressed)
        {
            activate = false;
        }
    }
}
