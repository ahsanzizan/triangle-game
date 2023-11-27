using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootPoint;


    public void Shoot(bool isAuto, float fireRate, GameObject bullet, Transform shootPoint, bool conditionToShoot = true)
    {
        float timeBtwShots = fireRate;

        if (timeBtwShots <= 0)
        {
            if (!isAuto)
            {
                if (conditionToShoot)
                {
                    Instantiate(bullet, shootPoint.position, shootPoint.rotation);
                    timeBtwShots = fireRate;
                }
            } else
            {
                Instantiate(bullet, shootPoint.position, shootPoint.rotation);
                timeBtwShots = fireRate;
            }
        } else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
