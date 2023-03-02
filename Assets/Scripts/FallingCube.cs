using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCube : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;
    private MeshRenderer meshRender;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody.useGravity = false;
        meshRender = GetComponent<MeshRenderer>();
        meshRender.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 3.0f)
        {
            rigidBody.useGravity = true;
            meshRender.shadowCastingMode= UnityEngine.Rendering.ShadowCastingMode.On;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        { 
        Debug.Log("You hit the falling cube");
        }
    }
}
