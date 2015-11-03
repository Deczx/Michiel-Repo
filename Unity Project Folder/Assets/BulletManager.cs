using UnityEngine;
using System.Collections;

public class BulletManager : MonoBehaviour {

    AudioSource ac;
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

        ac = this.GetComponent<AudioSource>();
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
            ac.Play();
        }
    }

   public void SellBlue()
    {
        if (ammoBlue > 0)
        {
            ammo += 2;
            ammoBlue--;
            ac.Play();
        }
    }

    public void BuyGreen()
    {
        if (ammo > 2)
        {
            ammo -= 3;
            ammoGreen++;
            ac.Play();
        }
    }

    public void SellGreen()
    {
       if (ammoGreen > 0)
       {
            ammo += 2;
            ammoGreen--;
            ac.Play();
        }
       
    }

    public void BuyRed()
    {
        if (ammo > 2)
        {
            ammo -= 3;
            ammoRed++;
            ac.Play();
        }
    }

    public void SellRed()
    {
        if (ammoRed > 0)
        {
            ammo += 2;
            ammoRed--;
            ac.Play();
        }

    }
}
