using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class person : MonoBehaviour {

    public int force = 0;
    public int speed = 0;
    public int life = 3;
    public Rigidbody rb;
    public GameObject player;
    public GameObject wall;

	// Use this for initialization
	void Start () {
        rb.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, force);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -force);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-force, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(force, 0, 0);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            Destroy(player);
            Application.LoadLevel("SampleScene");
        }
        
    }
}
