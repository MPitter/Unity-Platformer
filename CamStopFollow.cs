using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamStopFollow : MonoBehaviour {

    public CamFollow cf,cf2;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cf.enabled = false;
            cf2.enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cf.enabled = true;
            cf2.enabled = true;
        }
    }
}
