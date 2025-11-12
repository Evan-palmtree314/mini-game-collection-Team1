using MiniGameCollection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class shipGuns : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
}

    void shootaGun()
    {
        Vector3 
        if (ArcadeInput.Player1.Action1.Pressed)
        {

            GameObject prefab = Instantiate(BulletPrefab, position, transform.rotation);
        }
    }
