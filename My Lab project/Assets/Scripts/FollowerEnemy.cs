using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerEnemy : EnemyController
{
public Transform player;
    void Start()
    {
        
    }
    void FixedUpdate(){
        transform.position= Vector3.MoveTowards(transform.position,player.transform.position,maxSpeed*Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
    if (other.tag=="Player"){
        FindObjectOfType<playerStats>().TakeDamage(damage);
        Flip();

    }
     
}
}
