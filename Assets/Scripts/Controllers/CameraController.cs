using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;

    public Vector3 offset;
    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;

    public float pitch = 2f; // character height

    public float yawSpeed = 100f; //camera rotation speed

    private float currentZoom = 10f;
    private float yawInput = 0f;

    private void Update()
    {
       currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
       currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

       yawInput += Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime; //check for horizontal access keyes (e.g. a + d from WASD)
    }

    void LateUpdate ()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up * pitch); //raises camera level to top of character

        transform.RotateAround(target.position, Vector3.up, yawInput);
    }
    
}
