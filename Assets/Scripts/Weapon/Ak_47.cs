using UnityEngine;

public class Ak_47 : Weapon
{
    private int _maxCountBullet = 5;

    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < _maxCountBullet; i++)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        }
    }
}