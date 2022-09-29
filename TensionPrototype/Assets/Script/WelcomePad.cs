using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomePad : MonoBehaviour
{   
    public GameObject enemy;
    public AudioClip gameover;

    AudioSource audiosource;

    private Enemy enemyScript;

    private void OnTriggerEnter(Collider other) {
        Debug.Log("oops");
        enemyScript.isChasing = true;
        audiosource.PlayOneShot(gameover, 1.0f);
    }
    void Start() {
        enemyScript = enemy.GetComponent<Enemy>();
        audiosource = GetComponent<AudioSource>();
    }
}
