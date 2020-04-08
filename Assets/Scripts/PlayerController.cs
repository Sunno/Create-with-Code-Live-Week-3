using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float speed = 10f;
    public float xRange = 10f;
    public float zRangeUp = 10f;
    public float zRangeDown = 0f;

    public GameObject[] projectilePrefabs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int projectileIndex = Random.Range(0, projectilePrefabs.Length);
            //launch projectile from player
            Instantiate(
                projectilePrefabs[projectileIndex],
                transform.position,
                projectilePrefabs[projectileIndex].transform.rotation);
        }

        // Moving the player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(
            Vector3.right * horizontalInput * Time.deltaTime * speed
            + Vector3.forward * verticalInput * Time.deltaTime * speed
        );

        // Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < zRangeDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeDown);
        }

        if (transform.position.z > zRangeUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeUp);
        }
    }
}
