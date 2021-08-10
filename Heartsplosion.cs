using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartsplosion : MonoBehaviour {
    public Animator anim;

    bool isTou = false;
    public float timed = 1f;
    // Use this for initialization
    void Start () {
        anim.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (isTou == true)
        {
            timed -= Time.deltaTime;

        }
        if (timed < 0)
        {
            isTou = false;
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    { 
        if (other.gameObject.CompareTag("FX"))
        {
            isTou = true;
            anim.SetBool("isDead", true);
            this.transform.parent = null;
        }
        if (other.transform.CompareTag("Enemy"))
        {
            SoundKeeper.sndMan.PlayHeartless();
            Destroy(other.gameObject);
        }
    }
}
