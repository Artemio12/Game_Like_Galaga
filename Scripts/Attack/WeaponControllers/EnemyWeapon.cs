using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : Weapon
{
   // [SerializeField, Min(0)] private int enemyScore;
  //  public int EnemyScore => enemyScore;

    private void Awake()
    {
        SetFactory(new WeaponAttackFactory(firePoint, progectilePrefub, forse)); // ������ ���������� � ��������� ������ �������
        SetTypeAttack(GetAttack(playerAttack)); // ������ �� ���������
    }

    private void Update()
    {
        DoEnemyAttack();
    }

    private void DoEnemyAttack()
    {
        if (timeCounter.Timer() >= cooldown)
        {
            AttackType();
            timeCounter.Counter = 0;
        }
    }
}
