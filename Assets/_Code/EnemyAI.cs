using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    public float speed = 5.0f;          //speed to move
    public float rightEdge;             //right edge of screen
    public float leftEdge;              //left edge of screen
    public float dropDistance;          //amount to drop when changing direction

    private int direction = 1;          //direction we are moving

    void Update()
    {
        //get current position
        Vector2 newPosition = transform.position;
        
        //move at speed over time in a direction
        newPosition.x += speed * direction * Time.deltaTime;
        //apply the movement
        transform.position = newPosition;

        if (transform.position.x > rightEdge)
        {
            //change to move left
            direction = -1;
            //get current position
            newPosition = transform.position;
            newPosition.x = 8.0f;
            //drop to lower row
            newPosition.y -= dropDistance;
            //apply movement
            transform.position = newPosition;
            //change sprite facing direction
            transform.Rotate (new Vector3 (transform.localRotation.x, transform.localRotation.y, 180));
        }
        if (transform.position.x < leftEdge)
        {
            //change to move right
            direction = 1;
            //get current position
            newPosition = transform.position;
            newPosition.x = -8.0f;
            //drop to lower row
            newPosition.y -= dropDistance;
            //apply movement
            transform.position = newPosition;
            //change sprite facing direction
            transform.Rotate (new Vector3 (transform.localRotation.x, transform.localRotation.y, 180));
        }
    }
}
