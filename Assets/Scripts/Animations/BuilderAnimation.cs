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
