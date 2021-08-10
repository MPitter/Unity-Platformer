using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamStopFollowX : MonoBehaviour {

    public CamFollowX cfx;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cfx.enabled = false;
            ////cf2.enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cfx.enabled = true;
            //cf2.enabled = true;
        }
    }
}
