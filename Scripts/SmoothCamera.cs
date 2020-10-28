using UnityEngine;
using System.Collections;

public class SmoothCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 positionBias;
    public Vector3 positionShift;
    public Vector3 lookBias;
    public float rollDamping;

    private void FixedUpdate()
    {
        Vector3 newPos = target.position + target.right * positionShift.x + target.up * positionShift.y + target.forward * positionShift.z;

        newPos.x = target.position.x * (1 - positionBias.x) + newPos.x * positionBias.x;
        newPos.y = target.position.y * (1 - positionBias.y) + newPos.y * positionBias.y;
        newPos.z = target.position.z * (1 - positionBias.z) + newPos.z * positionBias.z;

        transform.position = newPos;
        transform.LookAt(target);
    }
}