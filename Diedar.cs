using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diedar : MonoBehaviour {

    NextLevel nl;
    LevelComplete lc;
    LevelKeeper lv;

    public int menuu;

    // Use this for initialization
    void Start () {
        nl = FindObjectOfType<NextLevel>();
        lc = FindObjectOfType<LevelComplete>();
        lv = FindObjectOfType<LevelKeeper>();
        menuu = lv.LvlKeeper;
    }
	
	// Update is called once per frame
	void Update () {


        if (nl.triggered == 1 && nl.isUp == true)
        {
            lv = FindObjectOfType<LevelKeeper>();
            menuu = lv.LvlKeeper;
        }
    }
}
