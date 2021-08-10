using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMunny : MonoBehaviour {

    public int coinValue = 1;
    public int munnyValue = 1;

    Rigidbody2D rb;
    GameObject Sora;
    Vector2 soraDir;
    float timeStamp;
    bool flyToChar;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (flyToChar)
        {
            soraDir = -(transform.position - Sora.transform.position).normalized;
            rb.velocity = new Vector2(soraDir.x, soraDir.y) * 3f * (Time.time / timeStamp);

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Magnet"))
        {
            timeStamp = Time.time;
            Sora = GameObject.Find("Char");
            flyToChar = true;


        }
        if (other.gameObject.CompareTag("Player"))
        {
            SoundKeeper.sndMan.PlayMunnySound();
            ScoreKeeper.instance.ChangeScore(coinValue);
            MunnyKeeper.instance.ChangeMunny(munnyValue);
            Destroy(gameObject);
        }
    }
}
