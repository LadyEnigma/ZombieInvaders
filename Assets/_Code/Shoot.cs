using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;               //the bullet to shoot out
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //spawn a bullet
            Instantiate (bullet, transform.position, transform.rotation); 
        }
    }
}
