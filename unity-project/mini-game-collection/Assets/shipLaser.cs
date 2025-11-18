using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipLaser : MonoBehaviour
{
    public GameObject laser;
    float laserCharge = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Blast();
    }

    void Blast()
    {
        if (Input.GetKey(KeyCode.E))
        {
            laserCharge += (1 * Time.deltaTime);

        }
        else
        {
            laserCharge = 0;
        }

        if (laserCharge >= 2)
        {
            Instantiate(laser, transform.position, Quaternion.identity);
            laserCharge = 0;
        }
    }
}
