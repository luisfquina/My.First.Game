using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    [SerializeField] private float velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        velocity *= Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0, velocity, 0);
    }

    
}
