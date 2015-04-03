using UnityEngine;
using System.Collections;

public class BulletAI : MonoBehaviour
{
    public float speed = 5.0f;              //movement speed

    void Update()
    {
        //get the current position
        Vector2 newPosition = transform.position;
        //move over time
        newPosition.y += speed * Time.deltaTime;
        //apply the movement
        transform.position = newPosition;
    }
}
