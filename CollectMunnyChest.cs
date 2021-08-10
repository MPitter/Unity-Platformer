using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMunnyChest : MonoBehaviour {

    //public int coinValue = 1;
    //public int munnyValue = 1;

    public Animator anim;

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
            anim.SetBool("isOpen", true);
            //SoundKeeper.sndMan.PlayMunnySound();
            //ScoreKeeper.instance.ChangeScore(coinValue);
            //MunnyKeeper.instance.ChangeMunny(munnyValue);
            //Destroy(gameObject);
        }
    }
}
