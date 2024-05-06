using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 direccion;
    
    private Movement_Controller _move;

    // Start is called before the first frame update
    void Start()
    {
        _move = GetComponent<Movement_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        _move.Movement(direccion);
    }

    public void setDir(Vector3 x)
    {
        direccion = x;
    }
}
