﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bailey Burke
// code inspired from https://www.youtube.com/watch?v=pCBqgREiSUE

public class AddPlayer : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Bailey;
    [SerializeField]
    KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative;

   
   

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Bailey;
        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Bailey;
    }
}
