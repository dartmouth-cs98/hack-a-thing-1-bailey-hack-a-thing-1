using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Bailey Burke
// code inspired from https://www.youtube.com/watch?v=pCBqgREiSUE

public class RestartLevel : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyRestart))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
