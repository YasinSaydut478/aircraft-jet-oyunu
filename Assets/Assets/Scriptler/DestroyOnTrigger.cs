using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DestroyOnTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.name == "AircraftJet")
        {
           
            Destroy(gameObject);
        }
    }
}

