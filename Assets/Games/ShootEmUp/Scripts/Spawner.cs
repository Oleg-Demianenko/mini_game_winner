using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float cooldownMin = 1f;
    public float cooldownMax = 5f;
    //public GameObject enemyPrefab_1;
    public GameObject enemyPrefab_2;
    //public GameObject enemyPrefab_3;

    void Start()
    {
        StartCoroutine(SpawnEnemy(enemyPrefab_2, cooldownMin, cooldownMax));
    }

    IEnumerator SpawnEnemy(GameObject enemyPrefab, float cooldownMin, float cooldownMax)
    {
        for(;;) {
            Instantiate(
                enemyPrefab,
                new Vector3(9.9f, Random.Range(-3.37f, 2.96f), 0),
                Quaternion.identity
            );

            yield return new WaitForSeconds(Random.Range(cooldownMin, cooldownMax));
        }
    }
}
