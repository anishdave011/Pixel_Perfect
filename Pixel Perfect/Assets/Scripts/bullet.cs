using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public int Damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy= hitInfo.GetComponent<Enemy>();
        if (enemy!= null)
        {
            enemy.TakeDamage(Damage);
        }
        Destroy(gameObject);
    }
    
}
