using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {


    public Wave[] waves;
    public float waitTime;
    public Transform start;
    public static int enemyActiveCount = 0;

	void Start () {
        StartCoroutine(SpawnEnemy());
	}

    IEnumerator SpawnEnemy()
    {
        foreach (Wave wave in waves)
        {
            enemyActiveCount += wave.count;
            for (int i = 0; i < wave.count; i++)
            { 
                GameObject.Instantiate(wave.enemy, start.position,Quaternion.identity);
                if (i != wave.count)
                {
                    yield return new WaitForSeconds(wave.rate);
                }
            }
            while (enemyActiveCount > 0)
            {
                yield return 0;
            }
            //yield return new WaitForSeconds(waitTime);
        }
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
