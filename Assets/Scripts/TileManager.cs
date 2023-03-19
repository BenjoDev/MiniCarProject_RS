using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject tilePrefab;
    [SerializeField]
    private float tileSpawnZ = -10.0f;
    [SerializeField]
    private float tileLenght = 10.0f;
    private int amountOfTiles = 9;
    private List<GameObject> tiles = new List<GameObject>();
    
    [SerializeField]
    private float tileSpeed = -1;
    

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < amountOfTiles; i++)
        {
            tiles.Add(SpawnTile());
        }

    }

    // Update is called once per frame
    private void Update()
    {
        foreach (GameObject obj in tiles)
        {
            obj.transform.Translate(0, 0, tileSpeed * Time.deltaTime);
            if (obj.transform.position.z < -20) 
            {
                obj.transform.position = new Vector3(0, 0, 70);
            }
        }
    }

    private GameObject SpawnTile()
    {
        GameObject go;
        go = Instantiate(tilePrefab) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * tileSpawnZ;
        tileSpawnZ += tileLenght;

        return go;
    }
}
