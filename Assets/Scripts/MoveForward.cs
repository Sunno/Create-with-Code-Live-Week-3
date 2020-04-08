using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float minSpeed = 40f;
    public float maxSpeed = 40f;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = minSpeed < maxSpeed ? Random.Range(minSpeed, maxSpeed) : maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
