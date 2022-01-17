using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(obstacleWave());
    }

    private void spawnObstacle() {
        GameObject newObstacle = Instantiate(obstaclePrefab) as GameObject;
        newObstacle.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
    }

    IEnumerator obstacleWave() {
        while (true) {
            yield return new WaitForSeconds(respawnTime);
            spawnObstacle();
        }
    }

}
