using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FSM
{
    [CreateAssetMenu(menuName = "FSM/Carnation/State")]
    public class State : ScriptableObject
    {
        public Action[] actions;
        public Transition[] transitions;

        public void UpdateState(ControllerNPC c)
        {
            DoActions(c);
            CheckTransitions(c);
        }

        private void DoActions(ControllerNPC c)
        {
            for (int i = 0; i < actions.Length; i++)
            {
                actions[i].Act(c);
            }
        }

        private void CheckTransitions(ControllerNPC c)
        {
            for (int i = 0; i < transitions.Length; ++i)
            {
                bool decision = transitions[i].decision.Decide(c);

                if (decision)
                {
                    c.Transition(transitions[i].trueState);
                    return;
                }
                else
                {
                    c.Transition(transitions[i].falseState);
                }
            }
        }
    }
}
