using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CollectHP : MonoBehaviour {

    PlayerHealth playerHealth;
    public float hpOrb = 10f;
    public Animator anim;

    public CircleCollider2D bc;
    public SpriteRenderer s0;

    bool isA = false;
    bool isTouch = false;
    float timed = .5f;
    // Use this for initialization
    void Awake()
    {
        isTouch = false;
        playerHealth = FindObjectOfType<PlayerHealth>();
        anim.GetComponent<Animator>();
        anim.SetBool("isInvisi", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouch == true)
        {
            timed -= Time.deltaTime;

        }
        if (timed < 0)
        {
            anim.SetBool("isInvisi", true);
            isTouch = false;
            isA = false;
            Destroy(gameObject);
        }

        while (playerHealth.currentHealth > playerHealth.maxHealth)
        {
            playerHealth.currentHealth = playerHealth.maxHealth;
            playerHealth.hpText.text = playerHealth.currentHealth.ToString();
        }
    }
     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") && isA == false)
        {
            if (playerHealth.currentHealth < playerHealth.maxHealth)
            {
                isTouch = true;
                anim.SetBool("isInvisi", false);
                //HealthKeeper.instance.ChangeHealth(hpOrb);
                playerHealth.currentHealth += hpOrb;
                playerHealth.hpText.text = playerHealth.currentHealth.ToString();
                s0.color = new Color(1f, 1f, 1f, 0f);
                SoundKeeper.sndMan.PlayPickUpSound();
                //Destroy(gameObject);
                bc.enabled = true;
            }
        }
    }

  
}
