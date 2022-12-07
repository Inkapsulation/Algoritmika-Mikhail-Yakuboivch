using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public float jumpBoost = 10.5f;
    Vector3 newPosition;
    public double timeLeft = 5f;
    public float Speed = 2.5f;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpBoost;
        
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpBoost;
        print("Start");

        
        while (timeLeft < 0)
        {
            print("It works!");
            timeLeft -= Time.deltaTime;
            newPosition.y = other.GetComponent<Transform>().position.y + Speed * Time.deltaTime;
            other.GetComponent<Transform>().position = newPosition;
        }



    }
    
}
