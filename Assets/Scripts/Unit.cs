using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    private Vector3 targetPosition;
    private bool isMoving;


    private void Start()
    {
        targetPosition = transform.position;
    }

    private void Update()
    {
        float stopDistance = 1f;
        if(Vector3.Distance(transform.position, targetPosition) > stopDistance)
        {
            
            Vector3 moveDir = (targetPosition - transform.position).normalized;
            float moveSpeed = 4f;
            transform.position += moveDir * moveSpeed * Time.deltaTime;

            float rotationSpeed = 10f;
            transform.forward = Vector3.Lerp(transform.forward, moveDir, Time.deltaTime * rotationSpeed);

            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        
    }

    public void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }

    public bool IsUnitMoving()
    {
        return isMoving;
    }
}
