using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Rigidbody2D rb2d;
    Vector3 bulletN = new Vector3 (0, 20, 0);
    Vector3 bulletNE = new Vector3(20, 20, 0);
    Vector3 bulletE = new Vector3(20, 00, 0);
    Vector3 bulletSE = new Vector3(20, -20, 0);
    Vector3 bulletS = new Vector3(0, -20, 0);
    Vector3 bulletSW = new Vector3(-20, -20, 0);
    Vector3 bulletW = new Vector3(-20, 0, 0);
    Vector3 bulletNW = new Vector3(-20, 20, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector3(100, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boss")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
