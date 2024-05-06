using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shoot_Controller : MonoBehaviour
{
    public float FireRate;
    public float TimeDeactivation = 5;
    public GameObject b;
    public int bullets_amount = 0;
    public int max_bullets = 0;
    public UnityEvent<int> OnUpdateBullets;

    float timer = 0f;

    private void Start()
    {
        bullets_amount = max_bullets;
    }

    public void Shoot(GameObject x, Vector3 ShootPoint, Quaternion RotShot)
    {
        if (Time.time >= timer && bullets_amount > 0 && Time.timeScale == 1)
        {
            GameObject shot = Pulling_Controller.Instance.GetPooledObject(x.name);
            if (shot != null)
            {
                shot.transform.position = ShootPoint;
                shot.transform.rotation = RotShot;
                shot.SetActive(true);
                shot.GetComponent<Bullet>().setDir(transform.right);
                shot.GetComponent<Destroy_Controller>().StartDeactivation(TimeDeactivation);
                --bullets_amount;
                OnUpdateBullets.Invoke(bullets_amount);
            }


            timer = Time.time + FireRate;
        }
    }

    public void Shoot(Vector3 ShootPoint, Quaternion RotShot)
    {
        Shoot(b, ShootPoint, RotShot);
    }

    public void increase_bullets(int x)
    {
        bullets_amount += x;
        if (bullets_amount > max_bullets) bullets_amount = max_bullets;
        OnUpdateBullets.Invoke(bullets_amount);
    }
}
