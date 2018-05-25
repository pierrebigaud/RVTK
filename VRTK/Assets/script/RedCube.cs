using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RedCube : MonoBehaviour {

    public GameManager gameManager;
    public float boundariesUp, boundariesDown,speed,initialX,initialY;
    public bool horizontal,pos=true;
    public bool activate;


    // Use this for initialization
    void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        initialX = transform.position.x;
        initialY = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (horizontal)
        {
            if (pos == true)
            {
                transform.Translate(Vector3.right*speed);
            }
            else
            {
                transform.Translate(Vector3.left*speed);
            }
            if (initialX+boundariesUp< transform.position.x && pos== true)
            {
                pos = false;
            }
            if (initialX + boundariesDown > transform.position.x && pos == false)
            {
                pos = true;
            }
        }
        else
        {
            if (pos == true)
            {
                transform.Translate(Vector3.up * speed);
            }
            else
            {
                transform.Translate(Vector3.down * speed);
            }
            if (initialY + boundariesUp < transform.position.y && pos == true)
            {
                pos = false;
            }
            if (initialY + boundariesDown > transform.position.y && pos == false)
            {
                pos = true;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"&&!activate)
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
