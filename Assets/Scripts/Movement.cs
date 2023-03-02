using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    
    public float velocity = 5;
    private int hitObstacles;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        float movex = Input.GetAxis("Horizontal") * Time.deltaTime * velocity;
        float movey = Input.GetAxis("Vertical") * Time.deltaTime * velocity;
        transform.Translate(movey, 0, -movex);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag != "Hit")
        {
            hitObstacles++;
            Debug.Log($"You hit {hitObstacles} obstacles");
        }
    }

}
