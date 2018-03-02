using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private Transform[] positions;
    private int wayIndex = 0;
    public float speed = 10;

    // Use this for initialization
    void Start () {
        positions = WayPoints.positions;
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    void Move()
    { 
        if (wayIndex >= positions.Length) return;
        transform.Translate((positions[wayIndex].position - transform.position).normalized * Time.deltaTime * speed);
        if (Vector3.Distance(positions[wayIndex].position, transform.position) < 0.2f)
        {
            wayIndex++;
        }
        if (wayIndex == positions.Length)
        {
            ReachDestination();
        }
    }

    void ReachDestination()
    {
        GameObject.Destroy(this.gameObject);
    }

    void OnDestroy()
    {
        EnemySpawner.enemyActiveCount--;
        Debug.Log(EnemySpawner.enemyActiveCount);
    }
}
