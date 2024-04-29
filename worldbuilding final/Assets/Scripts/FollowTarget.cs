using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
 
    private Vector3 offset;

    //Some Input
    //the players position
    //Some Logic ("WHEN")
    //always be following
    //Some Output
    //the cameras position

    private void Start()
    {
        if (target == null)
        {
            Debug.LogWarning(message: "No Target for script.", context: this);
        }
        offset = transform.position - target.position;
    }

    private void Update()
    {
        //move our position to player position
        transform.position = target.position + offset;
        transform.LookAt(target.position);
    }
}
