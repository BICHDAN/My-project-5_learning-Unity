using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotation : MonoBehaviour
{
    [Tooltip("Total seconds for a full day (360 degrees rotation)")]
    public float dayDurationInSeconds = 60f;

    void Update()
    {
        // Degrees per second = 360 degrees / total duration
        float rotationSpeed = 360f / dayDurationInSeconds;

        // Rotate around X axis (pitch)
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
