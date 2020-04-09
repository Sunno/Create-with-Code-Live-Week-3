using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    static private int animalsFed = 0;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        animalsFed++;
        Debug.Log("Animals fed: " + animalsFed);
    }
}
