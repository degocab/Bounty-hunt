using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{

    //public float random = Random.Range(0.75f, 1);
    float speed;
    GameObject npc;
    float test;
    bool boolValue;
    float gravity = 1;
    float width = 1;
    float height;
    BoxCollider2D bx;
    bool facingRight;
    SpriteRenderer sprite;
    //public Animation anim;
    // Use this for initialization
    Animator animator;
    Animation anim;
    Rigidbody2D rg;
    Vector3 velocity;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        height = Random.Range(80, 100) / 100f;
        Vector3 scale = new Vector3(width, height, 1f);
        transform.localScale = scale;


        speed = Random.Range(7, 10) / 10f;
        npc = GameObject.FindGameObjectWithTag("NPC");
        animator = gameObject.GetComponent<Animator>();
        animator.speed = speed;
        //anim["walk"].time = 0.5f;
        boolValue = (Random.Range(0, 2) == 0);
        if (!boolValue)
        {
            Flip();
        }

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(boolValue);

    }
    void FixedUpdate()
    {
        if (transform.position.x > 75 || transform.position.x < -75)
        {
            Destroy(gameObject);
        }

        if (boolValue)
        {
            transform.position += new Vector3((animator.speed * 4) * Time.deltaTime, 0, 0);
        }
        else
        {


            transform.position -= new Vector3((animator.speed * 4) * Time.deltaTime, 0, 0);
        }
    }

    void Flip()
    {

        //facingRight = !facingRight;
        //Vector3 theScale = transform.localScale;
        //theScale.x *= -1;
        //transform.localScale = theScale;
        facingRight = !facingRight;
        Vector3 theScale = sprite.transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

    }
    // void OnCollisionEnter2D(Collision2D collision)
    //{

    //    if(collision.gameObject.layer == 9)
    //    {
    //        Debug.Log("test");
    //        bx.isTrigger = true;
    //    }
    //}
}

