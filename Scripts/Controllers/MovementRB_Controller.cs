using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRB_Controller : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody rb;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        if (!TryGetComponent<Rigidbody>(out rb))
        {
            rb = GetComponentInParent<Rigidbody>();
        }
    }

    public void moveforward()
    {
        rb.velocity = new Vector3(transform.forward.x * moveSpeed, rb.velocity.y, transform.forward.z * moveSpeed);
    }

    public void Movement(Vector3 dir)
    {
        rb.velocity = dir * moveSpeed;
    }

    public void Movement(Vector3 dir, float move)
    {
        rb.velocity = new Vector3(dir.x * moveSpeed * move, rb.velocity.y, dir.z * moveSpeed * move);
    }

    public void Rotate(float dir)
    {
        rb.MoveRotation(Quaternion.Euler(0, dir * rotateSpeed, 0));
    }

    public void Rotate(float dir, float sense)
    {
        rb.MoveRotation(Quaternion.Euler(Vector3.up * dir * sense));
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

    public void SetEulerLocalAngles(Vector3 x)
    {
        transform.localEulerAngles = x;
    }

}
