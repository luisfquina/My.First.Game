using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("You hit me!");
    }
}
