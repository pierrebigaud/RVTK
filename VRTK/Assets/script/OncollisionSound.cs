using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncollisionSound : MonoBehaviour {

    private bool OneTime;
    public AudioClip clipTeleportation;
    public GameManager gameManager;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && OneTime == false)
        {
            OneTime = true;
            InvokeRepeating("Destruction", 1, 1);
        }

    }
}
