using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAttack : MonoBehaviour
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

        if (collider.TryGetComponent(out EnemyHealth enemyHealth))
        {
            enemyHealth.TakeDamage(_damage);
            IsAttacking = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;

        if (collider.TryGetComponent(out EnemyMove enemyMove))
        {
            IsAttacking = false;
        }
    }

    public float GetDamage()
    {
        return _damage;
    }

    public void PlayAnimation()
    {
        _animator.Play(Attack);
    }
}
