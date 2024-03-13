using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] float launchPower = 250;
    Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }

    void OnMouseUp()
    {
        Vector3 directionAndMagnitude = startingPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionAndMagnitude * launchPower);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    void OnMouseDrag()
    {
        Vector3 destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        destination.z = 0;
        transform.position = destination;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
