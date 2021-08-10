﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowX : MonoBehaviour {

    Transform CamTransform;
    public Transform Player;

    void Start()
    {
        CamTransform = Camera.main.transform;
    }

    void Update()
    {

        CamTransform.position = new Vector3(Player.position.x, CamTransform.position.y, CamTransform.position.z);
    }
}
