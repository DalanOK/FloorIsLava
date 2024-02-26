using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target; 
    public float distance = 5f; 
    public float height = 3f; 
    public float rotationSpeed = 2f; 

    private void LateUpdate()
    {
        if (target != null)
        {
           // float desiredAngle = target.eulerAngles.y;
           // Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
            Vector3 targetPosition = target.position - (Vector3.forward * distance) + (Vector3.up * height);

            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * rotationSpeed);
            transform.LookAt(target.position);
        }
    }
}
