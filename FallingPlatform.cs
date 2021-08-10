using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour {

    Rigidbody2D rb;
    public Transform t;

    public float time = 2f;
    float timed,timed2;
    bool isFall, isHit;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        timed = time;
        timed2 = time;
	}
	
	// Update is called once per frame
	void Update () {
        if (isFall == true)
        {
            timed -= Time.deltaTime;
        }
        if (isHit == true)
        {
            timed2 -= Time.deltaTime;
        }
        if (timed < 0)
        {
            rb.isKinematic = true;
            gameObject.transform.position = t.position;
            
            isFall = false;
            timed = time;
        }
        if (timed2 < 0)
        {
            rb.isKinematic = true;
            gameObject.transform.position = t.position;

            isHit = false;
            timed2 = time;
        }
    }
     void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Invoke("Fall", 0.01f);
            Invoke("Drop", 1f);
            ///Destroy(gameObject, 2f);
            
        }
        if (col.gameObject.CompareTag("FX"))
        {
            isHit = true;
            //gameObject.transform.position = t.position;
            //rb.isKinematic = true;
            //isFall = false;
            //timed = time;
        }
    }
    void Drop()
    {
        rb.isKinematic = false;
    }
    void Fall()
    {
        isFall = true;
    }
}
