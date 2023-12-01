using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Must be called at FixedUpdate
    public void Move(Rigidbody2D rb, float moveSpeed)
    {
        float moveX = Input.GetAxisRaw("Horizontal"), moveY = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(moveX, moveY).normalized;
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);
    }

    // Must be called at Update
    public void LookAtMouse(float lookOffset)
    {
        // Get player to mouse position direction
        Vector2 moveDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotation = Mathf.Atan2(moveDir.y, moveDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotation + lookOffset);
    }
}
