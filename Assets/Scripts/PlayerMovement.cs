using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 movement, moveDir;

    [Header("Attributes")]
    public float moveSpeed = 10f;
    public float lookOffset;

    private void Start()
    {
        if (rb == null)
        {
            rb = this.GetComponent<Rigidbody2D>();
        }
    }

    private void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal"), moveY = Input.GetAxisRaw("Vertical");
        movement = new Vector2(moveX, moveY).normalized;
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);
    }

    private void FixedUpdate()
    {
        Move();
    }
     
    private void LookAtMouse()
    {
        // Get player to mouse position direction
        moveDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotation = Mathf.Atan2(moveDir.y, moveDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotation + lookOffset);
    }

    private void Update()
    {
        LookAtMouse();
    }
}
