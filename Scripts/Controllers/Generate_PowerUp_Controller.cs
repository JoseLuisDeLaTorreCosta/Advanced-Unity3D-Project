using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Generate_PowerUp_Controller : MonoBehaviour
{
    public string powerup;
    
    // Start is called before the first frame update
    void Start()
    {
        generate();
    }
    bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {
        for (int i = 0; i < 30; i++)
        {
            Vector3 randomPoint = center + Random.insideUnitSphere * range;
            NavMeshHit hit;
            if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas))
            {
                result = hit.position;
                return true;
            }
        }
        result = Vector3.zero;
        return false;
    }

    void Put(Vector3 posObjetivo)
    {
        GameObject shot = Pulling_Controller.Instance.GetPooledObject(powerup);
        shot.transform.position = posObjetivo;
        shot.SetActive(true);
    }

    public void generate()
    {
        Vector3 pos;
        while (!RandomPoint(transform.position, 500f, out pos)) ;
        Put(pos);
    }
}
