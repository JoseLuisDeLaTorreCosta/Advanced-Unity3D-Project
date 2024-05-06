using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FSM
{
    public class Controller : MonoBehaviour
    {
        public State currentState;
        public State remainState;

        public bool ActiveAI { 
            get; set; 
        }

        private void Start()
        {
            ActiveAI = true;
        }

        private void Update()
        {
            if (!ActiveAI)
            {
                return;
            }

            //currentState.UpdateState(this);
        }

        public void Transition(State nextState)
        {
            if (nextState != remainState)
            {
                currentState = nextState;
            }
        }
    }
}