using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Controller : MonoBehaviour
{
    public float lim_y_s, lim_y_i;
    public GameObject gun;
    public Vector2 sensibility;

    public Movement_Controller _move_head;
    public MovementRB_Controller _move_gun;

    public void horiz_move(float dir)
    {
        _move_head.Rotate(dir, sensibility.x);
    }

    public void verti_move(float dir)
    {
        verti_move(dir, sensibility.y);
    }

    public void verti_move(float dir, float sense)
    {
        float angle = (gun.transform.localEulerAngles.z + dir * sense + 360) % 360;
        if (angle > 180) angle -= 360;
        angle = Mathf.Clamp(angle, lim_y_i, lim_y_s);
        _move_gun.Rotate_vert(angle);
    }
}
