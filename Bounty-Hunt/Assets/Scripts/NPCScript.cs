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
    private SpriteRenderer sprite;
    //public Animation anim;
    // Use this for initialization
    private Animator animator;
    private Animation anim;
    private Rigidbody2D rg;
    private Vector3 velocity;
    private int sortingOrder = -1;
    private int sortingOrder2 = 2;
    private int sortingOrder3;
    void Awake()
    {


        sprite = GetComponent<SpriteRenderer>();
        sprite.sortingOrder = sortingOrder3;
        animator = gameObject.GetComponent<Animator>();
        height = Random.Range(80, 100) / 100f;
        Vector3 scale = new Vector3(width, height, 1f);
        transform.localScale = scale;


        speed = Random.Range(7, 12) / 10f;
        npc = GameObject.FindGameObjectWithTag("NPC");

        animator.speed = speed;
        //anim["walk"].time = 0.5f;
        boolValue = (Random.Range(0, 2) == 0);
        if (!boolValue)
        {
            Flip();
        }
    }
    void Start()
    {



    }
    int Number()
    {
        //https://answers.unity.com/questions/452983/how-to-exclude-int-values-from-randomrange.html
        while ( == NotThisDirection)
        {
            newDir = Random.Range(1, 8);
        }

        return sortingOrder3;
    }
    // Update is called once per frame
    void Update()
    {
       

    }
    void Move()
    {
        if (transform.position.x > 500 || transform.position.x < -75)
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
    void FixedUpdate()
    {
        Move();
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

