using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5f;

    private float leftScreen;


    // Start is called before the first frame update
    void Start()
    {
        leftScreen = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if(transform.position.x < leftScreen)
        {
            Destroy(gameObject);
        }
    }
}
