using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class PawnCollection : MonoBehaviour
{
    private int Pawn = 0;

    public TextMeshProUGUI pawnText;
    private void OnTriggerEnter(Collider other)
    {
       if(other.transform.tag == "CollisionPawns")
        //Add coin to counter
        Pawn++;
       pawnText.text = Pawn.ToString();
        Destroy(other.gameObject);
        
    }
}
