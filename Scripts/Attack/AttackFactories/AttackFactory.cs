using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackFactory 
{
    protected Rigidbody projectile;
    protected Transform firePoint;

    protected float forse;

    public AttackFactory(Transform firePoint, Rigidbody projectile, float forse )
    {
        this.firePoint = firePoint;
        this.projectile = projectile;
        this.forse = forse;
    }

    public abstract ITypeAttack CreateAttack(EnumAttack enumAttack);
}
