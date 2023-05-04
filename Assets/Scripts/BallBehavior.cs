using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float initialPositionX = Random.value * 5;
        transform.position = new Vector3(initialPositionX, 24, -1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
