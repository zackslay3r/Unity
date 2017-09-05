using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float sideToSide;
    public float jump;
    // Update is called once per frame



    public void FixedUpdate() {
        Rigidbody rb = GetComponent<Rigidbody>();
        float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        Vector3 movement = new Vector3(moveHorizontal,  0.0f/*0.0f*/,speed/*moveVertical*/);
        rb.velocity = movement * speed;
        //if (Input.GetKey(KeyCode.A))
        //{
        //    //transform.Translate(Vector3.left * sideToSide * Time.deltaTime);

        //    GetComponent<Rigidbody>().velocity += sideToSide * Vector3.left * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    //transform.Translate(Vector3.right * sideToSide * Time.deltaTime );
        //    GetComponent<Rigidbody>().velocity += sideToSide * Vector3.right * Time.deltaTime;
        //}
        if (Input.GetKey(KeyCode.Space))
        {
            //transform.Translate(Vector3.up * jump * Time.deltaTime, Space.World);
            rb.AddForce(Vector3.up * jump);
        }
    }
}
