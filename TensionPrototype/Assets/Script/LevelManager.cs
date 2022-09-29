using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Enemy")
        {   
            Debug.Log("Ahhhhhhhhhhhhh");
            SceneManager.LoadScene(0);
        }
    }
}
