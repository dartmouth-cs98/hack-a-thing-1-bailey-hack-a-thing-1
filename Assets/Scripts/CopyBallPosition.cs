using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bailey Burke
// code inspired from https://www.youtube.com/watch?v=pCBqgREiSUE

public class CopyBallPosition : MonoBehaviour
{
    [SerializeField]
    Transform transformTarget;
    // Update is called once per frame
    void Update()
    {
        transform.position = transformTarget.position;
    }
}
