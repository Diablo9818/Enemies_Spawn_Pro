using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 3.0f;
    private Transform _target;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (_target != null)
        {
            Move();
        }
    }
    public void SetTarget(Transform newTarget)
    {
        _target = newTarget;
    }

    private void Move()
    {
        _rigidbody2D.velocity = CalculateDirection() * _moveSpeed;
    }

    private Vector3 CalculateDirection()
    {
        return (_target.position - transform.position).normalized;
    }
}
