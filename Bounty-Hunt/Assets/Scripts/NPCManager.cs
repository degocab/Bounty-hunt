using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour {
    public GameObject npc;
    public float spawnTime = 10f;
    public Transform[] spawnPoints;


	// Use this for initialization
	void Start () {
        int i = 0;
        int number = 25;
        while (i < number)
        {
            InvokeRepeating("Spawn", spawnTime, 5);
            //Invoke("Spawn",spawnTime);
            i++;
        }

        //StartCoroutine(MyCounter(1));
   
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Spawn()
    {

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        
        Instantiate(npc,spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
    //IEnumerator MyCounter(int number)
    //{
    //    int i = 0;
    //    while(i < number)
    //    {
    //        Invoke("Spawn", spawnTime);


    //        yield return 0;
    //    }
    //}
}
