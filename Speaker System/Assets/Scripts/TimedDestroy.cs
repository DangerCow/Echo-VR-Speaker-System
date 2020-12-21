﻿/**
 * iblowatsports
 * Date: 19 December 2020
 * Purpose: Destroy or deactivate objects
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
    public float destoryTime = 10f;
    public bool destroy = true;
    private float startTime;

    // Start is called before the first frame update
    void Awake()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= startTime + destoryTime)
        {
            if (destroy) Destroy(gameObject);
            else gameObject.SetActive(false);
        }

    }
}
