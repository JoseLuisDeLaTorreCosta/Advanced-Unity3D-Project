using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math_Controller : MonoBehaviour
{
    public Vector3 QuaternionToVector(Quaternion q)
    {
        return new Vector3(q.x, q.y, q.z);
    }
}
