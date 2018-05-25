using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassBreak : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public Material material3;
    private int frame = 1;
    private bool OneTime = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && OneTime == false)
        {
            OneTime = true;
            InvokeRepeating("Destruction", 1,1);
        }

    }

    void Destruction()
    {
        if(frame == 1) { 
        GetComponent<Renderer>().material = material1;
        }
        if (frame == 2)
        {
            GetComponent<Renderer>().material = material2;
        }
        if (frame == 3)
        {
            GetComponent<Renderer>().material = material3;
        }
        if (frame == 4)
        {
            Destroy(gameObject);
        }

        frame++;
    }
}
