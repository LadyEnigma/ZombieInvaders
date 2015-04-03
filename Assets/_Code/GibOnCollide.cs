using UnityEngine;
using System.Collections;

public class GibOnCollide : MonoBehaviour
{
    public GameObject [] gibs;              //gibs to spawn
    public GameObject [] staticGibs;        //sound objects
    public float explosionForce = 100.0f;
    public float spawnRadius = 1.0f;
    
    void OnCollisionEnter2D()
    {
        foreach (GameObject gib in gibs)
        {
            //spawn a gib randomly in this area
            GameObject gibInstance = Instantiate (gib, transform.position + Random.insideUnitSphere * spawnRadius, transform.rotation) as GameObject;
            Rigidbody2D gibBody = gibInstance.GetComponent<Rigidbody2D> ();
            gibBody.AddForce (new Vector2 (Random.Range(-explosionForce, explosionForce), Random.Range(-explosionForce, explosionForce)));
        }
        foreach (GameObject gib in staticGibs)
        {
            //spawn a gib randomly in this area
            GameObject gibInstance = Instantiate (gib, transform.position, transform.rotation) as GameObject;
        }
        //destroy this game object
        Destroy (gameObject);
    }
}
