using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{  
    private SpriteRenderer sr;
    public float maxSpeed = 2; 
    public int damage = 1; 
    // Start is called before the first frame update
    void Start()
    {
                sr = GetComponent<SpriteRenderer>();

    }
    public void Flip()
    {
                sr.flipX= !sr.flipX;

    }
void OnTriggerEnter2D(Collider2D other){
    if (other.tag=="Player"){
        FindObjectOfType<playerStats>().TakeDamage(damage);
        Flip();
    }
       else if (other.tag=="Wall"){
Flip();
}
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
