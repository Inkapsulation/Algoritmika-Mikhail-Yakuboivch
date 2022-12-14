using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    int speed = 3;
    public Vector3 direction;
    bool isActive = false;

    private void Update()
    {
        if (isActive)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {   
        
        if(other.tag == "PlatformStop")
        {
            direction *= -1;
        }

        if(other.tag == "Player")
        {
            isActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isActive = false;
        }
    }
}
