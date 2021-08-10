using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Invincibility : MonoBehaviour {

    public Image charImage;
    public bool isInvincible = false;
    public float timed = 10.0f;

   bool isActive = false;
    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (isInvincible == true)
        {
            timed -= Time.deltaTime;

        }
        if (timed < 0)
        {
            isInvincible = false;
            charImage.color = Color.white;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isActive == false) { 
        if (other.gameObject.CompareTag("Player"))
        {
            ////timed = 30.0f;
            isInvincible = true;
            SoundKeeper.sndMan.PlayDefSound();
            charImage.color = Color.green;
                isActive = true;
            //Destroy(gameObject);
        }
    }
}
    public void Invincible()
    {
        
    }
}
