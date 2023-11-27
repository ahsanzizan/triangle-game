using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Main script of the player

    Shooting shooting;
    PlayerMovement playerMovement;

    [Header("Movement")]
    Rigidbody2D rb;
    public float moveSpeed = 10f;
    public float lookOffset = -90f;

    [Header("Shooting")]
    public float fireRate = .5f;
    public GameObject bullet;
    public Transform shootPoint;


    private void Start()
    {
        shooting = this.GetComponent<Shooting>();
        playerMovement = this.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        playerMovement.LookAtMouse(lookOffset: lookOffset);
        shooting.Shoot(isAuto: false, fireRate: fireRate, bullet, shootPoint, Input.GetMouseButtonDown(0));
    }

    private void FixedUpdate()
    {
        playerMovement.Move(rb: rb, moveSpeed: moveSpeed);
    }
}
