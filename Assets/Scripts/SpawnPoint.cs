using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform pipe;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DoSpawn", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DoSpawn()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-3, 3), 0), Quaternion.identity);
    }
}
