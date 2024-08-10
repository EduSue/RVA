using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float forceJump = 5.0f;
    public bool isPlayerOne = true;
    private Rigidbody rig;
    private bool isGrounded;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float moveX;
        float moveY;

        if (isPlayerOne)
        {
            moveX = Input.GetAxis("Horizontal");
            moveY = Input.GetAxis("Vertical");
        }
        else
        {
            moveX = Input.GetAxis("Horizontal2");
            moveY = Input.GetAxis("Vertical2");
        }

        Vector3 movimiento = new Vector3(moveX, 0.0f, moveY) * moveSpeed * Time.deltaTime;
        Vector3 newPos = rig.position + rig.transform.TransformDirection(movimiento);
        rig.MovePosition(newPos);
    }

    void Jump()
    {
        if (isPlayerOne)
        {
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                rig.AddForce(Vector3.up * forceJump, ForceMode.Impulse);
            }
        }
        else
        {
            if (Input.GetButtonDown("Jump2") && isGrounded)
            {
                rig.AddForce(Vector3.up * forceJump, ForceMode.Impulse);
            }
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
