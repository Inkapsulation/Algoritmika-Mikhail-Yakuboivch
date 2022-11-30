using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public float jumpBoost = 10.5f;
    Vector3 newPosition;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpBoost;
        
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpBoost;
        newPosition.x = other.GetComponent<Transform>().position.x * Time.deltaTime; //+= transform.position.y * Time.deltaTime;
        other.GetComponent<Transform>().position = newPosition;
    }
}
