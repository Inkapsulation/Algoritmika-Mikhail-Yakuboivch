using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 2;
    public Transform target;
    public float speed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        transform.LookAt(target.position);

    }


    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(damage);
        
        
    }
}

