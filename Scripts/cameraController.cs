using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour
{
    [Range(0, 1)] public float[] bias = { 0.96f, 0.5f, 0.5f };
    public float height;
    public float dist;
    public float shift;
    public float lookVert;
    public float lookHorBias;
    public Transform target;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPos = target.position - target.forward * dist + target.right * shift + target.up * height;

        Vector3 transformPos = transform.position;
        transformPos.x = newPos.x * (1 - bias[0]) + transformPos.x * bias[0];
        transformPos.y = newPos.y * (1 - bias[0]) + transformPos.y * bias[0];
        transformPos.z = newPos.z * (1 - bias[0]) + transformPos.z * bias[0];

        transform.position = transformPos;

        Vector3 lookDir = target.position + target.up * lookVert;
        transform.LookAt(lookDir);
    }
}