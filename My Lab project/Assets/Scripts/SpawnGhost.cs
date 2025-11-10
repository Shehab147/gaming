using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhost : EnemyController
{
public Transform enemy;
public Transform swapPoint;

   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
void RespawnEnemy(){
    Instantiate(enemy,swapPoint.transform.position,swapPoint.transform.rotation);
}

    void OnTriggerEnter2D(Collider2D other){
    if (other.gameObject.tag=="Player"){
     RespawnEnemy();
    }
    
}
}