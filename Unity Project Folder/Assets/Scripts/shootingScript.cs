using UnityEngine;
using System.Collections;

public class shootingScript : MonoBehaviour
{

    public GameObject bullet;
    public Vector2 direction;
    public GameObject player;
    Vector2 mouseWorldSpace;
    public Rigidbody2D rb;

    public float projectileSpeed;
    public Vector2 startPosition;

    public bool isFired;


    // Use this for initialization
    void Start()
    {

        projectileSpeed = 5f;



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
    }

    IEnumerator Fire()
    {
        if (!isFired)
        {
            isFired = true;

            GameObject bulletTemp = Instantiate(bullet, startPosition, Quaternion.identity) as GameObject;
            rb = bulletTemp.GetComponent<Rigidbody2D>();
            rb.velocity = direction * 10f;
            yield return new WaitForSeconds(0.4f);
            isFired = false;
        }
    }
}
