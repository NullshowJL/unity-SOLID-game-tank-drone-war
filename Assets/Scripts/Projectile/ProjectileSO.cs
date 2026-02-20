using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ProjectileSO : ScriptableObject
{
    [SerializeField] private float cooldown;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float speed;
    [SerializeField] private int damage;
    
    public float Cooldown => cooldown;
    public GameObject ProjectilePrefab => projectilePrefab;
    public float Speed => speed;
    public int Damage => damage;
}
