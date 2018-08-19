using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D myRigidBody;

    private bool attack;

    private Animator myAnimator;

    private bool facingRight;
    [SerializeField]
    private float movementSpeed;
	// Use this for initialization
	void Start () {
        facingRight = true;
        myAnimator = GetComponent<Animator>();
        myRigidBody = GetComponent<Rigidbody2D>();


	}
	void Update()
    {

        HandleInput();
    }
	void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");
        HandleMovement(horizontal);
        Flip(horizontal);
        HandleAttacks();

        ResetValues();
    }

    private void HandleMovement(float horizontal)
    {
        if (!this.myAnimator.GetCurrentAnimatorStateInfo(0).IsTag("Attack"))
        {
            myRigidBody.velocity = new Vector2(horizontal * movementSpeed, myRigidBody.velocity.y);

        }
        myAnimator.SetFloat("speed", Mathf.Abs(horizontal));
    }

    private void HandleAttacks()
    {

        if (attack && !this.myAnimator.GetCurrentAnimatorStateInfo(0).IsTag("Attack"))
        {
            myAnimator.SetTrigger("punch");
            myRigidBody.velocity = Vector2.zero;
        }

    }
    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attack = true;
        }
    }
    private void Flip(float horizontal)
    {
        if(horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }
    /// <summary>
    /// Rest all values after
    /// </summary>
    private void ResetValues()
    {

        attack = false;
    }
}
