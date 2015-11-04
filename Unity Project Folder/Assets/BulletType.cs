using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BulletType : MonoBehaviour {

    Text text;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();



    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        if (shootingScript.b_type == shootingScript.BulletType.BULLET_TYPE_BLUE)
            text.text = "Ammo Type: Blue";
        else if (shootingScript.b_type == shootingScript.BulletType.BULLET_TYPE_GREEN)
            text.text = "Ammo Type: Green";
        else if (shootingScript.b_type == shootingScript.BulletType.BULLET_TYPE_RED)
            text.text = "Ammo Type: Red";
        else
            text.text = "Ammo Type: Normal";
        

    }
}
