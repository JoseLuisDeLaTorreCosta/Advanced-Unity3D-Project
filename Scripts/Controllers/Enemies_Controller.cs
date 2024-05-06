using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemies_Controller : MonoBehaviour
{
    public UnityEvent OnWinningEvent;
    public GameObject[] Players;
    public int num_Players;
    
    // Start is called before the first frame update
    void Start()
    {
        Players = GameObject.FindGameObjectsWithTag("Tank");
        num_Players = Players.Length;
    }

    public Vector3 NearestPlayerPos(Vector3 Player)
    {
        Vector3 near = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
        float dist = float.MaxValue;

        for (int i = 0; i < Players.Length; ++i)
        {
            Vector3 pos = Players[i].transform.position;
            float dist2 = Vector3.Distance(Player, pos);
            if (pos != Player && dist2 < dist)
            {
                dist = dist2;
                near = pos;
            }
        }

        return near;
    }

    public GameObject NearestPlayer(Vector3 Player)
    {
        GameObject near = null;
        float dist = float.MaxValue;

        for (int i = 0; i < Players.Length; ++i)
        {
            Vector3 pos = Players[i].transform.position;
            float dist2 = Vector3.Distance(Player, pos);
            if (pos != Player && dist2 < dist)
            {
                dist = dist2;
                near = Players[i];
            }
        }

        return near;
    }

    public void Decrease_Players()
    {
        --num_Players;
        if (num_Players == 1) OnWinningEvent.Invoke();
    }
}
