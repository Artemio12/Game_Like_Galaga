using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : Weapon
{
    private void Awake()
    {
        SetFactory(new WeaponAttackFactory(firePoint, progectilePrefub, forse)); // подача параметров в экземпл€р класса фабрики
        SetTypeAttack(GetAttack(playerAttack)); // ссылка на интерфейс
    }

    private void Update()
    {
        DoPlayerAttack();
    }

    private void DoPlayerAttack()
    {
       
        if (Input.GetButton("Fire1") && timeCounter.Timer() >= cooldown)
        {
            timeCounter.Counter = 0;
            AttackType();
            
        }   
    }
}
