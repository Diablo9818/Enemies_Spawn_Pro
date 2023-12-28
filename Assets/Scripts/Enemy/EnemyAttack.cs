using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    const string Attack = "Attack";

    [SerializeField] private float _damage;

    private Animator _animator;

    public bool IsAttacking { get; private set; }

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;

        if (collider.TryGetComponent(out UnitHealth health))
        {
            health.TakeDamage(_damage);
        }
    }

    public void PlayAnimation()
    {
        _animator.Play(Attack);
    }

    public float GetDamage()
    {
        return _damage;
    }
}
