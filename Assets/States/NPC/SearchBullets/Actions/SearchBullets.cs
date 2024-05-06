using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace FSM
{
    [CreateAssetMenu(menuName = "FSM/Carnation/Actions/SearchBullets")]
    public class SearchBullets : Action
    {
        
        public override void Act(ControllerNPC c)
        {
            if (c.bulletsitem == null) c.bulletsitem = GameObject.FindGameObjectWithTag("BulletsItem");

            if (c.agent.destination != c.bulletsitem.transform.position || c.agent.remainingDistance < 0.1f) c.agent.destination = c.bulletsitem.transform.position;
        }
    }
}