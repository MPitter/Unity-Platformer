using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardHit : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization
    void Start()
    {
        anim.GetComponent<Animator>();
        anim.SetBool("isGuard", false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isGuard", true);
            //SoundKeeper.sndMan.PlayGetItSound();
            //ScoreKeeper.instance.ChangeScore(coinValue);

        }
    }
        private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isGuard", false);
            //SoundKeeper.sndMan.PlayGetItSound();
            //ScoreKeeper.instance.ChangeScore(coinValue);

        }
    }
}