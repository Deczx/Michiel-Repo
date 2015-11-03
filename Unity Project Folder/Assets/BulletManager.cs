using UnityEngine;
using System.Collections;

public class BulletManager : MonoBehaviour {

    public static int ammo;
    public static int ammoBlue;
    public static int ammoGreen;
    public static int ammoRed;
	
    // Use this for initialization
	void Start () {
        ammo = 20;
        ammoBlue = 0;
        ammoGreen = 0;
        ammoRed = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BuyBlue()
    {
        if (ammo > 2)
        {
            ammo -= 3;
            ammoBlue++;
        }
    }

   public void SellBlue()
    {
        if (ammoBlue > 0)
        {
            ammo += 2;
            ammoBlue--;
        }
    }

    public void BuyGreen()
    {
        if (ammo > 2)
        {
            ammo -= 3;
            ammoGreen++;
        }
    }

    public void SellGreen()
    {
       if (ammoGreen > 0)
       {
            ammo += 2;
            ammoGreen--;
       }
       
    }

    public void BuyRed()
    {
        if (ammo > 2)
        {
            ammo -= 3;
            ammoRed++;
        }
    }

    public void SellRed()
    {
        if (ammoRed > 0)
        {
            ammo += 2;
            ammoRed--;
        }

    }
}
