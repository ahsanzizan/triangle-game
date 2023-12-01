using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Main script of the player

    Shooting shooting;
    PlayerMovement playerMovement;
    public Rigidbody2D rb;

    [Header("Movement")]
    public float moveSpeed = 10f;
    public float lookOffset = -90f;

    [Header("Shooting")]
    public float fireRate = .5f;
    public GameObject bullet;
    public Transform shootPoint;


    private void Start()
    {
        if (rb == null) rb = this.GetComponent<Rigidbody2D>();
        shooting = this.GetComponent<Shooting>();
        playerMovement = this.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        playerMovement.LookAtMouse(lookOffset: lookOffset);
        shooting.Shoot(isAuto: false, fireRate: fireRate, bullet: bullet, shootPoint: shootPoint, conditionToShoot: Input.GetMouseButtonDown(0));
    }

    private void FixedUpdate()
    {
        playerMovement.Move(rb: rb, moveSpeed: moveSpeed);
    }
}
