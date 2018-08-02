﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

    //public float random = Random.Range(0.75f, 1);
    public float speed;
    public GameObject npc;
    public float test;
    public bool boolValue;


     bool facingRight;
    
    //public Animation anim;
    // Use this for initialization
    public Animator animator;
    Animation anim;
	void Start () {
        speed = Random.Range(7,10)/10f;
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
    void Update() {


    }
    private void FixedUpdate()
    {
        if (boolValue)
        {
            transform.position += new Vector3((animator.speed * 4) * Time.deltaTime, 0, 0);
        }
        else
        {

      
            transform.position -= new Vector3((animator.speed *4) * Time.deltaTime, 0, 0);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}

