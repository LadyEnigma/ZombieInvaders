using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour
{
    public float timeBeforeDeath = 5.0f;

    private float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5.0)
        {
            timer = 5.0f;
            Destroy (gameObject);
        }
    }
}
