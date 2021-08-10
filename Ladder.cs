using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {

    //public float speed;
    public CharMovves cm;
    public Animator anim;

    // Use this for initialization
    void Start() {
        anim.GetComponent<Animator>();
        //cm = FindObjectOfType<CharMovves>();
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
                cm.beClimb = true;
        }
        }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cm.beClimb = false;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {

        //if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    anim.SetBool("isClimbing", true);
        //    //anim.SetBool("isGrounded", true);
        //    other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        //}else if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    anim.SetBool("isClimbing", true);
        //    //anim.SetBool("isGrounded", true);
        //    other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        //}else
        //{
        //   // anim.speed = 0f;

        //    other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
        //}
    }
        }
