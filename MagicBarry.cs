using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBarry : MonoBehaviour {

    public SpriteRenderer sr;
    public Animator anim;

    // Use this for initialization
    void Start () {
        sr.enabled = false;
        anim.SetBool("isGuard", false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            sr.enabled = true;
            anim.SetBool("isGuard", true);
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            sr.enabled = false;
            anim.SetBool("isGuard", false);
        }
    }
}
