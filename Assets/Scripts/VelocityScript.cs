using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocitySript : MonoBehaviour
{
    public float startSpeed = 50f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3 (startSpeed, 0, startSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
