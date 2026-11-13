using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLight()
    {
        rb.AddForce(Vector3.up * 100f * Time.deltaTime, ForceMode.Impulse);
    }
}
