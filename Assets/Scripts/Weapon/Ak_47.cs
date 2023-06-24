using System.Collections;
using UnityEngine;

public class Ak_47 : Weapon
{
    private int _maxCountBullet = 30;
    private Coroutine _coroutine;

    public override void Shoot(Transform shootPoint)
    {
        _coroutine = StartCoroutine(Fire(shootPoint));
    }

    private IEnumerator Fire(Transform shootPoint)
    {
        for (int i = 0; i < _maxCountBullet; i++)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);

            yield return new WaitForSeconds(0.02f);
        }
        
    }
}