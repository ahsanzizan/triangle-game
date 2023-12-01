using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float timeBtwShots = 0;

    public void Shoot(bool isAuto, float fireRate, GameObject bullet, Transform shootPoint, bool conditionToShoot = true)
    {
        if (timeBtwShots <= 0)
        {
            if (isAuto || conditionToShoot)
            {
                Instantiate(bullet, shootPoint.position, shootPoint.rotation);
                timeBtwShots = fireRate;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
