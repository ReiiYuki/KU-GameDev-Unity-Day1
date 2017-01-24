using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControl : MonoBehaviour {
    Rigidbody physicObject;
    Vector3 leftForce;
    Vector3 rightForce;
	// Use this for initialization
	void Start () {
        physicObject = GetComponent<Rigidbody>();
        leftForce = new Vector3(10,0);
        rightForce = new Vector3(-10, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") != 0)
        {
            this.gameObject.transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime *10);
            Debug.Log(this.gameObject.transform.position);
            
        }
    }
}
