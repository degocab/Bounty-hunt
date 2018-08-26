using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour {
    public float speed;
    GameObject train;

    private void Awake()
    {
        train = GetComponent<GameObject>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Move();

    }
    void Move()
    {
        if (transform.position.x < -500)
        {
            Destroy(gameObject);
            Instantiate(gameObject);
        }


 
            transform.position -= new Vector3((speed) * Time.deltaTime, 0, 0);
       
    }
}
