using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float maxHeight;
    public float minHeight;

    public float timeBetweenSpawn = 2f;
    private float timer;


    // Update is called once per frame
    void Update()
    {
        if(timer > timeBetweenSpawn)
        {
            Spawn();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    public void Spawn()
    {
        GameObject pipes = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
