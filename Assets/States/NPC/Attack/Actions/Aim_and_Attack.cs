using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    [CreateAssetMenu(menuName = "FSM/Carnation/Actions/Aim_and_Attack")]
    public class Aim_and_Attack : Action
    {

        public override void Act(ControllerNPC c)
        {
            GameObject nearest_enem = c._enem.NearestPlayer(c.transform.position);
            if (nearest_enem != null)
            {
                c._head.RotateTo(nearest_enem.transform.position, new Vector3(1, 1, 1));
                float dir = nearest_enem.transform.position.y - c._gun_cannon.transform.position.y;
                dir = dir / 40;
                c._fps.verti_move(dir, 0.005f);

                c._shoot.Shoot(c._shoot.transform.position, c._shoot.transform.rotation);
            }
        }

    }
}
