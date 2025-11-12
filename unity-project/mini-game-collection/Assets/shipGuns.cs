using MiniGameCollection;
using MiniGameCollection.Games2025.Team00;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class shipGuns : MonoBehaviour
{
    private Bullet player1Bullet; 

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(player1Bullet, new Vector3(3, 3, 0), new Quaternion(0,0,0,0));
        }
        
    }
}
