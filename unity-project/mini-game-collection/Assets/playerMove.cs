using MiniGameCollection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

public class playerMove : MonoBehaviour
{
    public Vector2 playerloc;
     Vector2 playerNewLoc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ArcadeInput.Player1.Up.Held)
        {
           playerNewLoc.x ++1;
        }
    }

    Vector2 aaaaaaaaa(Vector2 a,Vector2 b)
    { 
        
        a = b+(1,0)

        return a;
    }
}
