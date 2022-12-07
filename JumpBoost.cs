using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Time;

public class JumpBoost : MonoBehaviour
{
    public float jumpBoost = 10.5f;
    Vector3 newPosition;
    public double timeLeft = 3f;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpBoost;
        
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpBoost;
            

        
    }
    
    void Update(){
        timeLeft -= Time.deltaTime;
        if ( timeLeft < 0 )
        {
            newPosition.y = other.GetComponent<Transform>().position.y * Time.deltaTime; //+= transform.position.y * Time.deltaTime;
            other.GetComponent<Transform>().position = newPosition;
        }
    }
}
