using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour 
{
    [Header("Referenses to components")]
    [SerializeField] protected EnumAttack playerAttack;
    [SerializeField] protected Rigidbody progectilePrefub;
    [SerializeField] protected Transform firePoint;
    [Header("Fight parameters")]
    [SerializeField] protected float forse;
    [SerializeField, Min(0)] protected float cooldown;
  
    protected TimeCounter timeCounter = new TimeCounter();

    protected AttackFactory attackFactory;
    private ITypeAttack typeAttack;
    
    protected void SetFactory(AttackFactory factory)
    {
        attackFactory = factory;
        if (attackFactory == null) 
        {
            Debug.LogError("Error: SetFactory(AttackFactory factory) returns attackFactory == null");
        }
    }
    protected void SetTypeAttack(ITypeAttack attack)
    {
        typeAttack = attack;
        if (typeAttack == null)
        {
            Debug.LogError("Error: SetTypeAttack(ITypeAttack attack) returns typeAttack == null");
        }
    }

    protected ITypeAttack GetAttack(EnumAttack enumAttack)
    {
        ITypeAttack typeAttack = attackFactory.CreateAttack(enumAttack); //получение нужного экземл€ра класса (из фабрики)
                                                                         //и присваивание его переменной typeAttack; 
        if (typeAttack == null)
        {
            Debug.LogError("Error: GetAttack(EnumAttack enumAttack) returns typeAttack == null");
        }
        return typeAttack;
    }

    protected void AttackType()
    {
        typeAttack.Attack();
       
    }
}
