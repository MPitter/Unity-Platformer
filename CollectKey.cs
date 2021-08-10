using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour {

    public int coinValue = 1;
    public int keyNum;

    public static int KeyKounter;

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
            if (keyNum == 1)
            {
                KeyKeeper.cle1 = true;               
            }
            if (keyNum == 2)
            {
                KeyKeeper.cle2 = true;
            }
            if (keyNum == 3)
            {
                KeyKeeper.cle3 = true;
            }
            if (keyNum == 4)
            {
                KeyKeeper.cle4 = true;
            }
            if (keyNum == 5)
            {
                KeyKeeper.cle5 = true;
            }
            if (keyNum == 6)
            {
                KeyKeeper.cle6 = true;
            }
            if (keyNum == 7)
            {
                KeyKeeper.cle7 = true;
            }
            if (keyNum == 8)
            {
                KeyKeeper.cle8 = true;
            }
            if (keyNum == 9)
            {
                KeyKeeper.cle9 = true;
            }
            if (keyNum == 10)
            {
                KeyKeeper.cle10 = true;
            }
            if (keyNum == 11)
            {
                KeyKeeper.cle11 = true;
            }
            if (keyNum == 12)
            {
                KeyKeeper.cle12 = true;
            }
            if (keyNum == 13)
            {
                KeyKeeper.cle13 = true;
            }
            if (keyNum == 14)
            {
                KeyKeeper.cle14 = true;
            }
            if (keyNum == 15)
            {
                KeyKeeper.cle15 = true;
            }
            if (keyNum == 16)
            {
                KeyKeeper.cle16 = true;
            }
            if (keyNum == 17)
            {
                KeyKeeper.cle17 = true;
            }
            if (keyNum == 18)
            {
                KeyKeeper.cle18 = true;
            }
            if (keyNum == 19)
            {
                KeyKeeper.cle19 = true;
            }
            if (keyNum == 20)
            {
                KeyKeeper.cle20 = true;
            }
            if (keyNum == 21)
            {
                KeyKeeper.cle21 = true;
            }
            if (keyNum == 22)
            {
                KeyKeeper.cle22 = true;
            }
            if (keyNum == 23)
            {
                KeyKeeper.cle23 = true;
            }
            SoundKeeper.sndMan.PlayGetItSound();
            ScoreKeeper.instance.ChangeScore(coinValue);
            KeyKounter += 1;
            Destroy(gameObject);
        }
        }
    }
