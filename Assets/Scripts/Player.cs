using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Gun;
    public GameObject Head;
    public GameObject Shoot_point;
    
    Animator anim;
    float move, rot, cam_hor, cam_ver;

    FPS_Controller _fps;
    Movement_Controller _move;
    MovementRB_Controller _moveRB;
    public Movement_Controller _move_head;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        _fps = GetComponent<FPS_Controller>();
        _move = GetComponent<Movement_Controller>();
        _moveRB = GetComponent<MovementRB_Controller>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            anim.SetFloat("move", move);
            anim.SetFloat("rot", rot);
            if (move != 0) _moveRB.Movement(-transform.forward, move);
            if (rot != 0)
            {
                _move.Rotate(rot);
                _move_head.Rotate(-rot);
            }
            if (cam_hor != 0) _fps.horiz_move(cam_hor);
            if (cam_ver != 0) _fps.verti_move(cam_ver);
        }
    }

    public void movement(InputAction.CallbackContext ctx)
    {
        move = ctx.ReadValue<float>();
    }

    public void rotation(InputAction.CallbackContext ctx)
    {
        rot = ctx.ReadValue<float>();
    }

    public void camera_hor(InputAction.CallbackContext ctx)
    {
        cam_hor = ctx.ReadValue<float>();
    }

    public void camera_ver(InputAction.CallbackContext ctx)
    {
        cam_ver = ctx.ReadValue<float>();
    }

    public void shoot(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            Shoot_point.GetComponent<Shoot_Controller>().Shoot(Bullet, Shoot_point.transform.position, Shoot_point.transform.rotation);
        }
    }
}
