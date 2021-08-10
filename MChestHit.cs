using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MChestHit : MonoBehaviour {

    //ChestDetect cd;
   public bool isChest;
    public int Value;

    public Animator anim;
    PlayerHealth ph;

    // Use this for initialization
    void Start () {
        //cd = FindObjectOfType<ChestDetect>();
        ph = FindObjectOfType<PlayerHealth>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            if (Value == 30)
            {
                anim.SetBool("+30", true);
                ph.currentHealth += 30;
                ph.hpText.text = ph.currentHealth.ToString();
                isChest = false;
                //isTouch = true;
                SoundKeeper.sndMan.PlayGetItSound();
                Destroy(gameObject);
            }
            else if (Value == 100)
            {
                anim.SetBool("+100", true);
                ScoreKeeper.instance.ChangeScore(100);
                isChest = false;
                //isTouch = true;
                SoundKeeper.sndMan.PlayGetItSound();
                Destroy(gameObject);
            }
            else if (Value == 500)
            {
                anim.SetBool("+500", true);
                ScoreKeeper.instance.ChangeScore(500);
                isChest = false;
                //isTouch = true;
                SoundKeeper.sndMan.PlayGetItSound();
                Destroy(gameObject);
            }
            else if (Value == 2000)
            {
                anim.SetBool("+2000", true);
                ScoreKeeper.instance.ChangeScore(2000);
                isChest = false;
                ///isTouch = true;
                SoundKeeper.sndMan.PlayGetItSound();
                Destroy(gameObject);
            }
            
        }
    }


        
}
