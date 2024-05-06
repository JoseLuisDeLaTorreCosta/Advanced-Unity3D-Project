using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_PowerUp : MonoBehaviour
{
    Enemies_Controller _enem;

    private void Start()
    {
        _enem = GameObject.FindGameObjectWithTag("EnemyController").GetComponent<Enemies_Controller>();
    }

    public void update_bullets(int bullets)
    {
        GameObject nearest = _enem.NearestPlayer(transform.position);
        nearest.GetComponentInChildren<Shoot_Controller>().increase_bullets(bullets);
    }
}
