using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public AudioClip explosionSFX;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Translate(Vector3.up*Time.deltaTime*10);
        if (transform.position.y >= 10f)
            Destroy(this.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().clip = explosionSFX;
        GetComponent<AudioSource>().Play();
        Destroy(other.gameObject);
    }
}
