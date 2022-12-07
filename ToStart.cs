using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStart : MonoBehaviour
{
   Vector3 startPosition;

   public void OnTriggerEnter(Collider other){
        startPosition.y = 14.98f;
        startPosition.x = -16.87f;
        startPosition.z = -58.12846f;
        other.GetComponent<Transform>().position = startPosition;
   } 

}
