using MiniGameCollection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

public class playerMove : MonoBehaviour
{
    private Vector3 beans = Vector3.zero;
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Yaxe = ArcadeInput.Player1.AxisY;
        float Xaxe = ArcadeInput.Player1.AxisX;
        beans = new Vector3(Yaxe, Xaxe, 0);
        if (Xaxe >= 1 || Yaxe >= 1)
        {
            beans.Normalize();
        }
        transform.Translate(beans * Time.deltaTime);
    }

  
}
