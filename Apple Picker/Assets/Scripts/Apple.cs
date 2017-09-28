﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    public static float bottomY = -20f;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            // Get a reference to the ApplePicker component of Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>(); // 1
            // Call the public AppleDestroyed() method of apScript
            apScript.AppleDestroyed();                                      // 2
        }
    }
}
