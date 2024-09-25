using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float tiltSpeed = 2f;
    // Update is called once per frame
    void Update()
    {
        float tiltHorizontal = Input.GetAxis("HorizontalArrow");
        float tiltVertical = Input.GetAxis("VerticalArrow");

        transform.Rotate(Vector3.forward, tiltHorizontal * tiltSpeed);
        transform.Rotate(Vector3.right, -tiltVertical * tiltSpeed);
    }
}
