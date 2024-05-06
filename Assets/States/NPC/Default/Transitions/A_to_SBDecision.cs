using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    [CreateAssetMenu(menuName = "FSM/Carnation/Decisions/Attack_to_SearchBullets")]
    public class A_to_SBDecision : Decision
    {
        public override bool Decide(ControllerNPC c)
        {
            return (c._shoot.bullets_amount == 0);
        }
    }
}