﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(transform.position.x,0,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
