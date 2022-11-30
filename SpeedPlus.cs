using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPlus : MonoBehaviour
{
    public float SpeedBoost = 2.5f;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= SpeedBoost;
        other.GetComponent<FirstPersonMovement>().speed *= SpeedBoost;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= SpeedBoost;
        other.GetComponent<FirstPersonMovement>().speed /= SpeedBoost;
    }
}
