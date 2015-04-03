using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour 
{
    public float speed = 1.0f;                  //movement speed
    public GameObject tracks;                   //tracks game object
    
    void Update()
    {
        //get the current position
        Vector2 newPosition = transform.position;
        //move based on user input
        newPosition.x += Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
        if (newPosition.x >= 8) newPosition.x = 8;
        if (newPosition.x <= -8) newPosition.x = -8;
        //spawn tire tracks
        if (Input.GetButtonDown("Horizontal"))
        {
            GameObject tankTrack = Instantiate (tracks, transform.position, transform.rotation) as GameObject;
            tankTrack.transform.Rotate (new Vector3 (transform.localRotation.x, transform.localRotation.y, 90));
        }
        //apply the movement
        transform.position = newPosition;
    }
}
