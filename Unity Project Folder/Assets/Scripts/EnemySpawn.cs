using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
    int enemy_currency = 0;

    public GameObject normal_enemy;
    public GameObject blue_enemy;
    public GameObject green_enemy;
    public GameObject red_enemy;

    public GameObject enemy_manager;

    enum EnemyCost
    {
        NORMAL = 50,
        BLUE = 150,
        GREEN = 200,
        RED = 250
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void Spawn(int currency)
    {
        enemy_currency = currency;

        System.Random rnd = new System.Random();

        while (enemy_currency > (int)EnemyCost.NORMAL)
        {
            Vector3 rand_pos = new Vector2(rnd.Next(3), rnd.Next(3));
            Vector3 new_pos = this.transform.position + rand_pos;
            if (enemy_currency > (int)EnemyCost.RED)
            {
                //Spawn red enemy Instantiate()
                Instantiate(red_enemy, new_pos, Quaternion.identity);
                enemy_currency -= (int)EnemyCost.RED;
            }
            else if (enemy_currency > (int)EnemyCost.GREEN)
            {
                //Spawn green enemy
                Instantiate(green_enemy, new_pos, Quaternion.identity);
                enemy_currency -= (int)EnemyCost.GREEN;
            }
            else if (enemy_currency > (int)EnemyCost.BLUE)
            {
                //spawn blue enemy
                Instantiate(blue_enemy, new_pos, Quaternion.identity);
                enemy_currency -= (int)EnemyCost.BLUE;
            }
            else if (enemy_currency > (int)EnemyCost.NORMAL)
            {
                //spawn normal enemy
                Instantiate(green_enemy, new_pos, Quaternion.identity);
                enemy_currency -= (int)EnemyCost.NORMAL;
            }

            enemy_manager.BroadcastMessage("Spawned");
        }
    }
}
