using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace FSM
{
    [CreateAssetMenu(menuName = "FSM/Carnation/Decisions/Attack_to_MoveRandom")]
    public class A_to_MRDecision : Decision
    {
        public float shoot_distance;
        
        public override bool Decide(ControllerNPC c)
        {

            GameObject nearest_enem = c._enem.NearestPlayer(c.transform.position);
            return (!nearest_enem.activeSelf || Vector3.Distance(c.transform.position, nearest_enem.transform.position) > shoot_distance);
        }
    }
}
