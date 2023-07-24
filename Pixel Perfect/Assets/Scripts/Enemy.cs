using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D myBody;
    public int health = 3;
    public GameObject deathEffect;
    public void TakeDamage (int damage)
    {
        health-=damage;
        if (health<=0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
    }
}
