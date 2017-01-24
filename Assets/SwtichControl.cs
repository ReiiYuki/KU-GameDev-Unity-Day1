using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwtichControl : MonoBehaviour {

    public GameObject sun;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width/2-150/2, Screen.height/2-150/2, 150, 150), sun.GetComponent<Light>().enabled?"Turn Off":"Turn On"))
            sun.GetComponent<Light>().enabled = !sun.GetComponent<Light>().enabled;
    }
}
