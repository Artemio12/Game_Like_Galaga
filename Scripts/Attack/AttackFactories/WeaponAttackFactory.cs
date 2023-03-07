using UnityEngine;

public enum EnumAttack
{
    None = 0,
    DefaultShot = 1,
    Rocket = 2,
    Laser = 3,
}

public class WeaponAttackFactory : AttackFactory
{
    public WeaponAttackFactory(Transform firePoint, Rigidbody projectile, float forse  ) : base(firePoint, projectile, forse) { }
     
    public override ITypeAttack CreateAttack(EnumAttack enumAttack)
    {   
        ITypeAttack typeAttack = null;
        switch (enumAttack)
        {
            case EnumAttack.DefaultShot:
                typeAttack = new DefaulShotAttack(firePoint, projectile, forse);
                break;
            case EnumAttack.Rocket:
                typeAttack = new RocketAttack();
                break;
            case EnumAttack.Laser:
                typeAttack = new LaserAttack();
                break;
            default:
                Debug.LogError("Ошибка, тип атаки не существует");
                break;
        }
        return typeAttack;
    }
    
}
   


