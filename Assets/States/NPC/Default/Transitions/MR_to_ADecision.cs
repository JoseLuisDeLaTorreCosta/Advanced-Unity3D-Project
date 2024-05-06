using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    [CreateAssetMenu(menuName = "FSM/Carnation/Decisions/MoveRandom_to_Attack")]
    public class MR_to_ADecision : Decision
    {
        public int shoot_distance;

        public override bool Decide(ControllerNPC c)
        {
            GameObject nearest_enem = c._enem.NearestPlayer(c.transform.position);
            return (nearest_enem.activeSelf && Vector3.Distance(c.transform.position, nearest_enem.transform.position) <= shoot_distance);
        }
    }
}