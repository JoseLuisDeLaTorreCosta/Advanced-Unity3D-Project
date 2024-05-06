using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace FSM
{
    public class ControllerNPC : Controller
    {
        public Enemies_Controller _enem;
        public FPS_Controller _fps;
        public GameObject bulletsitem;
        public Movement_Controller _head;
        public MovementRB_Controller _gun_cannon;
        public Shoot_Controller _shoot;

        public NavMeshAgent agent;
        public Vector3 posObjetivo;

        void Start()
        {
            ActiveAI = true;

            if (ActiveAI)
            {
                _enem = GameObject.FindGameObjectWithTag("EnemyController").GetComponent<Enemies_Controller>();
                _fps = GetComponent<FPS_Controller>();
                _gun_cannon = GetComponentInChildren<MovementRB_Controller>();
                _head = GetComponentInChildren<Movement_Controller>();
                _shoot = GetComponentInChildren<Shoot_Controller>();
                agent = gameObject.GetComponent<NavMeshAgent>();
                bulletsitem = GameObject.FindGameObjectWithTag("BulletsItem");
                Generar_pos_al();
            }
        }

        private void Update()
        {
            if (!ActiveAI)
            {
                return;
            }

            currentState.UpdateState(this);
        }

        public void Generar_pos_al()
        {
            Vector3 dest;
            if (RandomPoint(transform.position, 200f, out dest))
            {
                agent.destination = dest;
            }
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
    }
}