using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smile : MonoBehaviour
{
    private float hit = 4;
    public GameObject effect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.magnitude > hit)
        {
            FindObjectOfType<manger>().removeSmile();
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
    }
}
