using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // x and z movement
        transform.Translate(transform.forward * Input.GetAxis("Vertical"));
        transform.Translate(transform.right * Input.GetAxis("Horizontal"));

        // scaling
        if (Input.GetButtonDown("Fire1"))
        {
            transform.localScale = transform.localScale + Vector3.one;
        }
        if (Input.GetButtonDown("Fire2"))
        {
            transform.localScale = transform.localScale - Vector3.one;
        }
    }
}
