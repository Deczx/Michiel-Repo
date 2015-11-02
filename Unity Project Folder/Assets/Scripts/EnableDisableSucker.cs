using UnityEngine;
using System.Collections;

public class EnableDisableSucker : MonoBehaviour {

	void Update () {

        if (Input.GetMouseButton(1))
            GameValueManager.suckerEnabled = true;
        else
        {
            GameValueManager.suckerEnabled = false;
        }
        


        if (GameValueManager.suckerEnabled)
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < transform.childCount; ++i)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
	}
}
