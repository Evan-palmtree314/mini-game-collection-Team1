using MiniGameCollection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class playerMove : MonoBehaviour
{
    private Vector3 beans = Vector3.zero;

    //private GameObject player1;  
    //public float player1MoveSpeed;
    public string playerFacing;
    private float playerDir;
    bool slowState = false;
    float Yaxe;
    float Xaxe;
    
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            slowState = true;
        }
        else
        {
            slowState = false;
        }

        if (!slowState)
        {
            Yaxe = ArcadeInput.Player1.AxisY * 2;
            Xaxe = ArcadeInput.Player1.AxisX * 2;
        }
        else
        {
            Yaxe = ArcadeInput.Player1.AxisY;
            Xaxe = ArcadeInput.Player1.AxisX;
        }

        if (Yaxe > 0 && Xaxe == 0)
        {
            playerFacing = "N";
            playerDir = 0f;
        }
        else if (Yaxe < 0 && Xaxe == 0)
        {
            playerFacing = "S";
            playerDir = 180f;
        }
        else if (Xaxe > 0 && Yaxe == 0)
        {
            playerFacing = "E";
            playerDir = 270f;
        }
        else if (Xaxe < 0 && Yaxe == 0)
        {
            playerFacing = "W";
            playerDir = 270f;
        }
        else if (Yaxe > 0 && Xaxe > 0)
        {
            playerFacing = "NE";
            playerDir = 45f;
        }
        else if (Yaxe < 0 && Xaxe > 0)
        {
            playerFacing = "SE";
            playerDir = 135f;
        }
        else if (Yaxe < 0 && Xaxe < 0)
        {
            playerFacing = "SW";
            playerDir = 225f;
        }
        else if (Yaxe > 0 && Xaxe < 0)
        {
            playerFacing = "NW";
            playerDir = 315f;
        }

        gameObject.transform.rotation = Quaternion.Euler(0f, 0f, playerDir);

        beans = new Vector3(Yaxe, Xaxe, 0);
      
        transform.Translate(beans * Time.deltaTime);
        
    }

  
}
