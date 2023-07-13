using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float health = 4f;
    public GameObject deatheffect;
    public static int enemiesalive;

    void Start()
    {
        enemiesalive++;
    }

    void OnCollisionEnter2D (Collision2D colinfo)
    {
        if(colinfo.relativeVelocity.magnitude > health )
            {
            Die();
            }
    }

    void Die()
    {

        Scores.number += 300;

        Instantiate(deatheffect, transform.position, Quaternion.identity);
        enemiesalive--;
        if (enemiesalive <= 0)
        {
            Debug.Log("YOU WON");
        }
        Destroy(gameObject);
    }       
}
