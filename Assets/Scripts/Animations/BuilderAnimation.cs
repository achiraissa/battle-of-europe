using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderAnimation : MonoBehaviour
{
    Animator anim;
    Unit unit;

    void ChooseAnimation(Unit u)
    {
        anim.SetBool("IsIdle", false);
        anim.SetBool("IsMove", false);
        anim.SetBool("IsBuild", false);
        anim.SetBool("IsMoveToBuild", false);
        anim.SetBool("IsMoveToResource", false);
        anim.SetBool("IsDeliverToHQ", false);
        anim.SetBool("IsGather", false);
        anim.SetBool("IsStoreAtHQ", false) ;

        switch (u.State)
        {
            case UnitState.Idle:
                anim.SetBool("IsIdle", true);
                break;
            case UnitState.Move:
                anim.SetBool("IsMove", true);
                break;
            case UnitState.BuildProgress:
                anim.SetBool("IsBuild", true);
                break;
            case UnitState.MoveToBuild:
                anim.SetBool("IsMoveToBuild", true);
                break;
            case UnitState.Gather:
                anim.SetBool("IsGather", true);
                break;
            case UnitState.MoveToResource:
                anim.SetBool("IsMoveToResource", true);
                break;
            case UnitState.DeliverToHQ:
                anim.SetBool("IsDeliverToHQ", true);
                break;
            case UnitState.StoreAtHQ:
                anim.SetBool("IsStoreAtHQ", true);
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
