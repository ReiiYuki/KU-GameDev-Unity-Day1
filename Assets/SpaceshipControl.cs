using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControl : MonoBehaviour {

    public GameObject bullet;
    List<GameObject> bulletPool;

	// Use this for initialization
	void Start () {
        bulletPool = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") != 0)
        {
            this.gameObject.transform.Translate(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime *10);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet,this.gameObject.transform.position,Quaternion.identity);
        }
        
    }

    
}
