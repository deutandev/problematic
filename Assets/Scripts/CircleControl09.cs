using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleControl09 : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private Vector3 target;
    private bool clicked;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = transform.position;
    }

    void Update()
    {
        // if (Input.GetMouseButtonDown(0)) 
        // {
        //     target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //     target.z = transform.position.z;
        //     clicked = true;
        // }
        // if (clicked == true)
        // {
        //     transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        // }
        // if (transform.position == target)
        // {
        //     clicked = false;
        // }
        // transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        ProcessInput();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInput()
    {
        // get input
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Proses input. Normalize agar kecepatan konstan pada gerak diagonal
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }
}
