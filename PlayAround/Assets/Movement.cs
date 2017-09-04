using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float forward;
    public float rotation;
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity += transform.forward * forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity += -transform.forward * forward * Time.deltaTime;
        }




        var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotation;

        transform.Rotate(0, x, 0);
      
    }
}
