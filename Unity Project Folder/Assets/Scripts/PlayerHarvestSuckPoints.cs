using UnityEngine;
using System.Collections;

public class PlayerHarvestSuckPoints : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(other.gameObject);
        Debug.Log("10000000000 PUNTEN YO");

    }

}
