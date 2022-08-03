using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;
    public Transform cameraFollow;

    void Start() { }

    void Update()
    {
        transform.position = cameraFollow.position;
        transform.LookAt(lookAt);
    }
}
