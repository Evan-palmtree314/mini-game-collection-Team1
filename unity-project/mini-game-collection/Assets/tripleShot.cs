/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class tripleShot : MonoBehaviour
{
    public GameObject BossBullet;

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
        if (Input.GetKeyDown(KeyCode.F))
        {
            for (int i = 0; i < 3; i++)
            {
                Instantiate(BossBullet, transform.position, Quaternion.identity);
      
            }
            
        }

    }
}
*/
using System.Collections;
using UnityEngine;

public class tripleShot : MonoBehaviour
{
    public GameObject BossBullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(Blast());
        }
    }

    IEnumerator Blast()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(BossBullet, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f); // delay between bullets
        }
    }
}