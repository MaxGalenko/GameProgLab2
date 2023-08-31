using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigidBody;
    private float forceStrength = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        // Grabs component Rigidbody from the gameobject that is running player movement
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float horizontalnput = Input.GetAxis("Horizontal");
        float verticallnput = Input.GetAxis("Vertical");
        rigidBody.AddForce(new Vector3(-verticallnput, 0, horizontalnput) * forceStrength);
    }
}