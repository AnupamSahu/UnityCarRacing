using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringController : MonoBehaviour
{
    public float rotationSpeed;
    public float maxAngle;

    private void Update()
    {
        Quaternion targetRot = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -1 * Input.GetAxis("Horizontal") * maxAngle);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, rotationSpeed);
    }
}
