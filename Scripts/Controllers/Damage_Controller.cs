using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DetectedCollision
{
    public string name;
    public string tag;
    public bool collision_for_name;
}

public class Damage_Controller : MonoBehaviour
{
    public float damage;
    public bool damage_all;
    [SerializeField]
    private List<DetectedCollision> names_colliders = new List<DetectedCollision>();

    [SerializeField]
    private HashSet<string> names_colliders_name = new HashSet<string>();

    [SerializeField]
    private HashSet<string> names_colliders_tags = new HashSet<string>();

    private void Awake()
    {
        if (!damage_all)
        {
            for (int i = 0; i < names_colliders.Count; ++i)
            {
                DetectedCollision c = names_colliders[i];

                if (c.collision_for_name) names_colliders_name.Add(c.name);
                else names_colliders_tags.Add(c.tag);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Health_Controller>(out Health_Controller h) && (damage_all || names_colliders_tags.Contains(collision.gameObject.tag) || names_colliders_name.Contains(collision.gameObject.name)))
        {
            h.Hurt(damage);
        }
    }
}
