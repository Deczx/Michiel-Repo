using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

    public float health = 50f;
    public float damage_mod = 25.0f;

    // 1-to-1 mapping with BulletType
    enum EnemyType
    {
        NORMAL = 0,
        BLUE,
        GREEN,
        RED
    };

    EnemyType enemy_type = EnemyType.RED;

    public void TakeDamage(int bullet_type)
    {
        int damage_bonus = 1;
        if (bullet_type == (int)enemy_type && bullet_type > 0)
            damage_bonus = 2;

        health -= damage_mod * (float) damage_bonus;

        if (health <= 0)
        {
            BroadcastMessage("Killed");
            Object.Destroy(this.gameObject);
        }
    }

    void SetType(int type)
    {
        enemy_type = (EnemyType) type;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}
