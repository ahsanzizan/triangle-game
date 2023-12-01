using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Attributes")]
    public float speed = 10f;
    public float lifeTime = 2.5f;

    private void Start()
    {
        Invoke(nameof(DestroyBullet), lifeTime);
    }

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);
    }

    public void DestroyBullet()
    {
        Destroy(this.gameObject);
        // Instantiate destroy fx
    }
}
