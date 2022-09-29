using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomePad : MonoBehaviour
{   
    public GameObject enemy;

    private Enemy enemyScript;

    private void OnTriggerEnter(Collider other) {
        Debug.Log("oops");
        enemyScript.isChasing = true;
    }

    void Start() {
        enemyScript = enemy.GetComponent<Enemy>();
    }
}
