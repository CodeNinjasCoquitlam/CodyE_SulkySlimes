using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    [Header("Mouse Info")]
    public Vector3 clickStartLocation;

    [Header("Physics")]
    public Vector3 launchVector;
    public float launchForce;

    [Header("Goo Ball")]
    public Transform ballTransform;
    public Vector3 originalBallPosition;
    public Quaternion originalBallRotation;
    public Rigidbody ballRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        originalBallPosition = ballTransform.position;
        originalBallRotation = ballTransform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(
                mouseDifference.x * 1f,
                mouseDifference.y * 1.2f,
                mouseDifference.y * -1.5f
                );
            ballTransform.position = originalBallPosition - launchVector / 400;
            launchVector.Normalize();
        }

        if (Input.GetMouseButtonUp(0))
        {
            ballRigidbody.isKinematic = false;
            ballRigidbody.AddForce(launchVector * launchForce, ForceMode.Impulse);
        }

        if (Input.GetMouseButtonDown(1))
        {
            ballTransform.position = originalBallPosition;
            ballTransform.rotation = originalBallRotation;
            ballRigidbody.isKinematic = true;
        }
    }
}
