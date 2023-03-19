using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    [SerializeField]
    private float enemySpeed = -2;
    private List<GameObject> enemies = new List<GameObject>();
    [SerializeField]
    private float enemySpawnZ = 15.0f;
    [SerializeField]
    private float enemySpawnDistance = 5.0f;
    private int amountOfEnemies = 18;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amountOfEnemies; i++)
        {
            enemies.Add(SpawnEnemy());
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject obj in enemies)
        {
            obj.transform.Translate(0, 0, enemySpeed * Time.deltaTime);
            if (obj.transform.position.z < -20)
            {
                if (Random.value < 0.5f)
                    obj.transform.position = new Vector3(0.9f, 0.25f, 60);
                else
                    obj.transform.position = new Vector3(-0.9f, 0.25f, 60);
                
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private GameObject SpawnEnemy()
    {
        GameObject go;
        go = Instantiate(enemyPrefab) as GameObject;
        go.transform.SetParent(transform);
        if (Random.value < 0.5f)
        {
            go.transform.position = new Vector3(0.9f, 0.25f, enemySpawnZ);
        } else
        {
            go.transform.position = new Vector3(-0.9f, 0.25f, enemySpawnZ);
        }   

        enemySpawnZ += enemySpawnDistance;

        return go;
    }
}
