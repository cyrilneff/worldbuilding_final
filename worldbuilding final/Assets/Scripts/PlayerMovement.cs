using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed;
    public float jumpforce = 1;
 


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        // if (speed == 0);
        // {
        // Debug.Log("Start");
        // }
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
      
        transform.position += new Vector3(0, 0, 0) * Time.deltaTime * speed;


        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) < 0.001f)


        {


            rigidbody.AddForce(new Vector2(0, jumpforce), ForceMode.Impulse);


        }


        Vector3 force = new Vector3(x:horizontal,y:0,z:vertical);
        rigidbody.AddForce(force);
    }
  
}
