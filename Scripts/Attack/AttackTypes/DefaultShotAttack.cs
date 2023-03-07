using UnityEngine;

public class DefaulShotAttack :  ITypeAttack
{
    private Transform firePoint;
    private Rigidbody bulletPrefab;

    private float bulletForse;

    public DefaulShotAttack(Transform firePoint, Rigidbody bulletPrefab, float bulletForse)
    {
        this.firePoint = firePoint;
        this.bulletPrefab = bulletPrefab;
        this.bulletForse = bulletForse;
    }

    public void Attack()
    {
        var bullet = GameObject.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.AddForce(firePoint.up * bulletForse, ForceMode.Impulse);
    }
}
