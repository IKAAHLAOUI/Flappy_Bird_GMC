using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{ public float minY;
    public float maxY;
    public float distance;
    void OnTriggerEnter2D(Collider2D col)
    {
       if(col.tag=="Obstacle")
        {
            Debug.Log("no");
            float ObstacleY = Random.Range(minY, maxY);
            Vector3 spawnPosition = new Vector3(transform.position.x + distance, ObstacleY, 0);
            transform.position = spawnPosition;
        }
        
    }



}
