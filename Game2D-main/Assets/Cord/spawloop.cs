using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawloop : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePerfabs;
    public float SpawnTime = 3f;
    public float speed = 2f;
    private float timeUntilobstaclespawn;

    void Update()
    {
        if(gamemanager.Instance.Playing)
        {
            spawnloop();
        }
       
    }
    void spawnloop()
    {
        timeUntilobstaclespawn += Time.deltaTime;
        if(timeUntilobstaclespawn >= SpawnTime)
        {
            Spawn();
            timeUntilobstaclespawn = 0f;
        }
    }
    private void Spawn()
    {
        GameObject obstacleToSpawn = obstaclePerfabs[Random.Range(0, obstaclePerfabs.Length)];
        GameObject spawnedobstacle = Instantiate(obstacleToSpawn, transform.position, Quaternion.identity);
        Rigidbody2D obstacleRB = spawnedobstacle.GetComponent<Rigidbody2D>();
        obstacleRB.velocity = Vector2.left * speed;
    }
   
}
