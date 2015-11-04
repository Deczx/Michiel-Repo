using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

    bool is_started = false;
    bool first_wave_started = false;

    int level = 0;
    public int currency = 2500;
    public int level_modifier = 2;

    int count_enemies = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (!first_wave_started)
        {
            first_wave_started = true;
            StartWave();
        }

        if (count_enemies == 0 && is_started == true)
        {
            //MOVE TO STORE!
        }
	}

    void StartWave()
    {
        if (is_started == false)
        {
            is_started = true;
            GameObject[] spawns = GameObject.FindGameObjectsWithTag("Spawn");
            foreach (GameObject spawn in spawns)
            {
                spawn.BroadcastMessage("Spawn", currency / spawns.Length); //int division
            }
        }
    }

    void Spawned()
    {
        ++count_enemies;
    }

    void Killed()
    {
        --count_enemies;
    }
}
