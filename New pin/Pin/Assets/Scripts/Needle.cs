using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Pin;
    public Transform TargetPosition;
    public BulletController Bullet;
    private int proyectil;
    private int cuenta;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            proyectil++;
           
           
            cuenta = proyectil-ColliderController.y;
            print(ColliderController.y);
            Bullet.enabled = true;
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(Pin, TargetPosition.position, Quaternion.identity);
    }

}
