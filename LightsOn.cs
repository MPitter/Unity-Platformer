using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOn : MonoBehaviour {

    public Light Lit; 

	// Use this for initialization
	void Start () {
        Lit.GetComponent<Light>().enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Lit.GetComponent<Light>().enabled = true;
        }
    }
}
