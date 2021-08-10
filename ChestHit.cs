using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestHit : MonoBehaviour {

    public int coinValue = 1;

    public static ChestHit Instance;

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
            
            SoundKeeper.sndMan.PlayGetItSound();
            ScoreKeeper.instance.ChangeScore(coinValue);
            Destroy(gameObject);
        }
    }
}
