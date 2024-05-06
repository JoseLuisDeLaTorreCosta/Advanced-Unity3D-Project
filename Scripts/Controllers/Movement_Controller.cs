using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Controller : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;

    public void moveforward()
    {
        transform.position += Time.deltaTime * transform.forward * moveSpeed;
    }

    public void Movement(Vector3 dir)
    {
        transform.position += Time.deltaTime * dir * moveSpeed;
    }

    public void Movement(Vector3 dir, float move)
    {
        transform.position += Time.deltaTime * dir * moveSpeed * move;
    }

    public void Rotate(float dir)
    {
        transform.Rotate(0, Time.deltaTime * dir * rotateSpeed, 0);
    }

    public void Rotate(float dir, float sense)
    {
        transform.Rotate(Vector3.up * dir * sense);
    }

    public void Rotate_vert(float angle)
    {
        transform.localEulerAngles = Vector3.forward * angle;
    }

    public void RotateTo(Vector3 target)
    {
        transform.LookAt(target);
    }

    public void RotateTo(Vector3 target, Vector3 axis)
    {
        transform.LookAt(new Vector3(target.x * axis.x, target.y * axis.y, target.z * axis.z));
    }
}
