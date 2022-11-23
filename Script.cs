using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    private int health;
    public int level;
    public int speed;
    Vector3 newPosition;
    
    
    void Start()
    {
        newPosition = transform.position;
        speed = 5;
        health += level;
        print($"Уровень здоровья = {health}");
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
