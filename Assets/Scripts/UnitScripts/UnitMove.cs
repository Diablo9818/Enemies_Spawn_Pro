using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

[RequireComponent(typeof(Rigidbody2D))]
public class UnitMove : MonoBehaviour
{
    const string UnitRun = "Run";

    [SerializeField] private float _moveSpeed = 3.0f;
    private Transform _target;
    private Rigidbody2D _rigidbody2D;

    private UnitAttack _unitAttack;
    private Animator _animator;
    private string _currentState;

    private void Awake()
    {
        _unitAttack = GetComponent<UnitAttack>();
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!_unitAttack.IsAttacking)
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
        ChangeAnimationState(UnitRun);
        _rigidbody2D.velocity = FindDirection() * _moveSpeed;
    }

    private Vector3 FindDirection()
    {
        return (_target.position - transform.position).normalized;
    }

    private void ChangeAnimationState(string newState)
    {
        if (_currentState == newState)
        {
            return;
        }
        _animator.Play(newState);
        _currentState = newState;
    }
}
