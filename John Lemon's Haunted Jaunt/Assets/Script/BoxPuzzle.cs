using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BoxPuzzle : MonoBehaviour
{
    public Transform player;
    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            SceneManager.LoadScene(0);
        }
    }
}
