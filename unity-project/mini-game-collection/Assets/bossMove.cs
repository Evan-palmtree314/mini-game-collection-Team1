using MiniGameCollection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossMove : MonoBehaviour
{
    private Vector3 beans = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Yaxe = ArcadeInput.Player2.AxisY;
        beans = new Vector3(Yaxe, 0, 0);
        if (Yaxe >= 1)
        {
            beans.Normalize();
        }
        transform.Translate(beans * Time.deltaTime);
    }
}
