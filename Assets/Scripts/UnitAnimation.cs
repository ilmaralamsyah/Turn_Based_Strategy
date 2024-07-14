using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimation : MonoBehaviour
{
    private const string IS_MOVING = "IsMoving";

    [SerializeField] private Unit unit;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool(IS_MOVING, unit.IsUnitMoving());
    }
}
