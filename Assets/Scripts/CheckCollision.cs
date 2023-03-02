using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{

    private MeshRenderer meshRenderer;
    private int hitObstacles;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.collider.tag == "Player" && gameObject.tag != "Hit")
        {
            hitObstacles++;
            Debug.Log($"You hit {hitObstacles} obstacles");
            meshRenderer.material.color = Color.black;
        }
            gameObject.tag = "Hit";
    }
}
