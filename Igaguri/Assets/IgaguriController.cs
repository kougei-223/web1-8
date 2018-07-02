using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour {
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
	// Use this for initialization
	void Start () {
        // shoot(new Vector3(0, 200, 2000));
		
	}

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
