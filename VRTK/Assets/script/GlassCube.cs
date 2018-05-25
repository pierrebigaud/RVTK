using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassCube : MonoBehaviour {

    public Animation destroy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("DestroyYourself", 5);
        }
        
    }

    private void DestroyYourself()
    {
        Destroy(gameObject);
    }
}
