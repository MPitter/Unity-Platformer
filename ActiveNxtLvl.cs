using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveNxtLvl : MonoBehaviour {
    ///Space Paranoids related
    NextLevel nl;
    
	// Use this for initialization
	void Start () {
        nl = FindObjectOfType<NextLevel>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            nl.enabled = true;
        }
    }
        }
