using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarknessDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag =="Darkness")
        {
           Debug.Log("you did it");
           other.gameObject.SetActive(false);
            
        }
    }
}
