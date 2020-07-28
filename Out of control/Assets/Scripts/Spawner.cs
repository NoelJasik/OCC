using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] ThingsToSpawn;
    public float SpawnTime;
    float time;
    public bool SpawnAsChild;
    [SerializeField]
    float MaxUndoTime;

    // Start is called before the first frame update
    void Start()
    {
        time = SpawnTime / 2 - Random.Range(0, MaxUndoTime / 2);
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
         var Spawnable  = Instantiate(ThingsToSpawn[Random.Range(0, ThingsToSpawn.Length)], transform.position, Quaternion.identity);
            if (SpawnAsChild)
            {
                Spawnable.transform.parent = gameObject.transform;
            }
            
            time = SpawnTime - Random.Range(0, MaxUndoTime);
        }
    }
}
