using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public float distance;
    public float height;
    public float sensitivity;

    private float currentAngleX = 0f;
    private float currentAngleY = 0f;

    private void Start()
    {
        if (target == null)
        {
            Debug.LogWarning("Target not set for ThirdPersonCamera");
            enabled = false;
        }
    }

    private void LateUpdate()
    {
        currentAngleX += Input.GetAxis("Mouse X") * sensitivity;
        currentAngleY -= Input.GetAxis("Mouse Y") * sensitivity;
        currentAngleY = Mathf.Clamp(currentAngleY, -30f, 80f);

        Quaternion rotation = Quaternion.Euler(currentAngleY, currentAngleX, 0);
        Vector3 position = rotation * new Vector3(0, height, -distance) + target.position;

        transform.rotation = rotation;
        transform.position = position;
    }
}
