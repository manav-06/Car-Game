using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringWheel : MonoBehaviour
{
    public float maxTurnAngle = 45f;
    public float steerRotationDamp = 0.5f;


    void Update()
    {

        transform.localEulerAngles = Vector3.back * Mathf.Clamp((Input.GetAxis("Horizontal") * 100) * steerRotationDamp, -maxTurnAngle, maxTurnAngle);


    }
}
