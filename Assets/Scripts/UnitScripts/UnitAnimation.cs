using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(UnitAttack))]
public class UnitAnimation : MonoBehaviour
{

    const string UnitAttack = "Attack";
    const string UnitRun = "Run";
    const string UnitTakeHit = "TakeHit";
    const string UnitDeath = "Death";

    private Animator _animator;
    private UnitAttack _unitAttack;
    private UnitHealth _health;
    private string _currentState;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _unitAttack = GetComponent<UnitAttack>();
        _health = GetComponent<UnitHealth>();
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void Update()
    {

    }


}
