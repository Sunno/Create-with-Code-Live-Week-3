using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private bool rotated = false;
    static private int animalsFed = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (!rotated)
        {
            transform.Rotate(Vector3.up, 180f);
            Destroy(other.gameObject);
            animalsFed++;
            Debug.Log("Animals fed: " + animalsFed);
            rotated = true;
        }
    }
}
