using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClaire : MonoBehaviour
{

    public GameObject player;
    public float offset;
    private float cameraRotation;

    private void LateUpdate()
    {
        Vector3 desiredPosition = player.transform.position + Vector3.up * offset;
        transform.position = desiredPosition;
        transform.rotation = Quaternion.Euler(90f, 200f, 0f);
    }
}
