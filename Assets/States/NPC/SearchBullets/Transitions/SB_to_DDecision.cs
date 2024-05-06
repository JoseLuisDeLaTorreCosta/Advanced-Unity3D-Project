using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    [CreateAssetMenu(menuName = "FSM/Carnation/Decisions/SearchBullets_to_Default")]
    public class SB_to_DDecision : Decision
    {
        public override bool Decide(ControllerNPC c)
        {
            return (c._shoot.bullets_amount > 0);
        }
    }
}
