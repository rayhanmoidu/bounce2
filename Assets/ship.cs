using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{

    // public GameObject obstaclePrefab;
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("hit detected");
        Destroy(other.gameObject);
    }
}
