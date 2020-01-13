using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bailey Burke
// code inspired from https://www.youtube.com/watch?v=pCBqgREiSUE

public class ConstantVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Bailey;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += v3Bailey; 
    }
}
