using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectChest : MonoBehaviour {

    //public int coinValue = 1;
    public Animator anim;

    // Use this for initialization
    void Start() {
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isOpen", true);
            //SoundKeeper.sndMan.PlayGetItSound();
            //ScoreKeeper.instance.ChangeScore(coinValue);
            
        }   
}
}
