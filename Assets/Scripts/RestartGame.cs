using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Bailey Burke
// code inspired from https://www.youtube.com/watch?v=pCBqgREiSUE

public class RestartGame : MonoBehaviour
{

    [SerializeField]
    string tagPlayer;

    private void OnCollisionEnter(Collision hit)
    {
        if (hit.collider.tag == tagPlayer)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
