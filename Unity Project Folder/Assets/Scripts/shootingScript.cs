using UnityEngine;
using System.Collections;

public class shootingScript : MonoBehaviour
{

    public GameObject normal_bullet;
    public GameObject blue_bullet;
    public GameObject green_bullet;
    public GameObject red_bullet;

    public Vector2 direction;
    public GameObject player;
    Vector2 mouseWorldSpace;
    public Rigidbody2D rb;

    public float projectileSpeed;
    public Vector2 startPosition;

    public bool isFired;

    enum BulletType
    {
        BULLET_TYPE_NORMAL = 0,
        BULLET_TYPE_BLUE,
        BULLET_TYPE_GREEN,
        BULLET_TYPE_RED
    };

    BulletType b_type = BulletType.BULLET_TYPE_NORMAL;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseScreenPosition = Input.mousePosition;
        mouseWorldSpace = (Vector2)Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        startPosition = player.transform.position;

        if (Input.GetMouseButtonDown(0) && isFired == false)
        {
            direction = mouseWorldSpace - startPosition;
            direction.Normalize();
            StartCoroutine(Fire());

        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            ++b_type;
        } else if(Input.GetAxis("Mouse ScrollWheel") < 0) {
            --b_type;
        }

        //handle wrap-around
        if (b_type < 0)
        {
            b_type = BulletType.BULLET_TYPE_RED;
        }
        else if (b_type > BulletType.BULLET_TYPE_RED)
        {
            b_type = BulletType.BULLET_TYPE_NORMAL;
        }
    }

    IEnumerator Fire()
    {
        if (!isFired)
        {
            isFired = true;
            GameObject bullet = null;

            switch (b_type)
            {
                case BulletType.BULLET_TYPE_NORMAL:
                    bullet = normal_bullet;
                    break; 
                case BulletType.BULLET_TYPE_BLUE:
                    bullet = blue_bullet;
                    break;
                case BulletType.BULLET_TYPE_GREEN:
                    bullet = green_bullet;
                    break;
                case BulletType.BULLET_TYPE_RED:
                    bullet = red_bullet;
                    break;
                default:
                    bullet = normal_bullet;
                    break;
            }

            GameObject bulletTemp = Instantiate(bullet, startPosition, Quaternion.identity) as GameObject;
            rb = bulletTemp.GetComponent<Rigidbody2D>();
            rb.velocity = direction * projectileSpeed;
            bulletTemp.SendMessage("SetType", (int) b_type);
            yield return new WaitForSeconds(0.4f);
            isFired = false;
        }
    }
}
