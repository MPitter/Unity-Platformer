using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipKeeper : MonoBehaviour {

    public SpriteRenderer sr,sr2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {
            // flip the sprite
            sr.flipX = true;
            sr2.flipX = true;
            //sr3.flipX = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            // flip the sprite
            sr.flipX = false;
            sr2.flipX = false;
            //sr3.flipX = false;
        }
    }
}
