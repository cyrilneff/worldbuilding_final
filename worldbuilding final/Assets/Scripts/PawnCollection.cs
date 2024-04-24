using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PawnCollection : MonoBehaviour
{
    //input
        //collision data
    //when
        //there is a collision between the player and the pawn
    //output
        //delete the pawn
        
        //void OnTriggerEnter(Collider other)
        //void OnCollisionEnter(Collision other)
        void OnCollisionEnter(Collision other)
        {
            Debug.Log(message:"Done Hit IT"+other.gameObject.name);
            if (other.gameObject.CompareTag("CollisionPawns"))
            {
               Destroy(other.gameObject); 
            }
            
       
            
        }
}
