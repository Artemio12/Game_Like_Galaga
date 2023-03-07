using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : Weapon
{
    private void Awake()
    {
        SetFactory(new WeaponAttackFactory(firePoint, progectilePrefub, forse)); // ������ ���������� � ��������� ������ �������
        SetTypeAttack(GetAttack(playerAttack)); // ������ �� ���������
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
