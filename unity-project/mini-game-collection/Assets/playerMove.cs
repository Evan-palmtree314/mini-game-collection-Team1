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
            Yaxe = ArcadeInput.Player1.AxisY * 3;
            Xaxe = ArcadeInput.Player1.AxisX * 3;
        }
        else
        {
            Yaxe = ArcadeInput.Player1.AxisY;
            Xaxe = ArcadeInput.Player1.AxisX;
        }

        beans = new Vector3(Yaxe, Xaxe, 0);
      
        transform.Translate(beans * Time.deltaTime);
        
    }

  
}
