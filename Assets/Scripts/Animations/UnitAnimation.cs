using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimation : MonoBehaviour
{
    Animator anim;
    Unit unit;

    void ChooseAnimation(Unit u)
    {
        anim.SetBool("IsIdle", false);
        anim.SetBool("IsMove", false);
        anim.SetBool("IsAttack", false);
        anim.SetBool("IsDie", false);
        anim.SetBool("IsMoveToEnemy", false);

        switch (u.State)
        {
            case UnitState.Idle:
                anim.SetBool("IsIdle", true);
                break;
            case UnitState.Move:
                anim.SetBool("IsMove", true);
                break;
            case UnitState.AttackUnit:
                anim.SetBool("IsAttack", true);
                break;
            case UnitState.MoveToEnemy:
                anim.SetBool("IsMoveToEnemy", true);
                break;
            case UnitState.Die:
                anim.SetBool("IsDie", true);
                break;
        }
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        unit = GetComponent<Unit>();
    }

    void Update()
    {
        ChooseAnimation(unit);
    }
}
