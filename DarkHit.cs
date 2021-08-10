using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkHit : MonoBehaviour {

    public Animator anim;

    PlayerHealth playerHealth;
    Invincibility inv;
    bool isAtk;
    float timed = 1f;
   /// AttackMe2 am2;

    // Use this for initialization
    void Start() {
        isAtk = false;
        playerHealth = FindObjectOfType<PlayerHealth>();
        anim.GetComponent<Animator>();
        inv = FindObjectOfType<Invincibility>();
        //am2 = FindObjectOfType<AttackMe2>();
    }

    // Update is called once per frame
    void Update() {
        if (isAtk == true)
        {
            timed -= Time.deltaTime;
        }
        if (timed < 0)
        {

            anim.SetBool("isHit", true);
            anim.SetBool("isHurt", false);
            anim.SetBool("isOK", false);
            timed = 1f;
        }
        }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Player") && inv.isInvincible == false)
        {
            if (playerHealth.currentHealth > 0f)
            {
                isAtk = true;
                anim.SetBool("isHit", true);
                anim.SetBool("isHurt", false);
                anim.SetBool("isOK", false);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        isAtk = false;
        timed = 1f;
        anim.SetBool("isHit", false);
    }
}
