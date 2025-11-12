using MiniGameCollection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

public class playerMove : MonoBehaviour
{
    private Vector3 beans = Vector3.zero;
    public float player1MoveSpeed;
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
            Yaxe = ArcadeInput.Player1.AxisY / 2;
            Xaxe = ArcadeInput.Player1.AxisX / 2;
        }
        beans = new Vector3(Yaxe, Xaxe, 0);
      
        transform.Translate(beans * Time.deltaTime);
        
    }

  
}
