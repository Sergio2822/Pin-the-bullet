using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    // Start is called before the first frame update
    public static int y;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(y);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        
        y++;
    }
}
