using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{

    public int health = 10; 
    public int lives = 3; 
    public bool isImmune = false; 
    public float immunityDuration = 1.5f; 
    private float filckerTime = 0f; 
    private float immunityTime = 0f; 
    private float filckerDuration= 0.1f; 

    private SpriteRenderer sr;
    
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void SpirteFlicker(){
        if(filckerTime<filckerDuration){
            filckerTime += Time.deltaTime;
        }
        else if (filckerTime>= filckerDuration){
            sr.enabled =!(sr.enabled);
            filckerTime =0;
        }
    }
void TakeDamage(int damage){

if (isImmune == false){

health -= damage;
if(health<0)health=0;
if (lives>0&& health==0){

    FindObjectOfType<LevelManger>().RespawnPlayer();
    health =3;
    lives--;
}
else if (lives==0&&health==0){
    Debug.Log("Gameovever");
    Destroy(this.gameObject);
    Debug.Log("player health "+ health.ToString());
    Debug.Log("palyer lives"+ lives.ToString());


}
}
isImmune=true;
immunityTime=0f;
}
    // Update is called once per frame
    void Update()
    {
        if(isImmune== true){
            SpirteFlicker();
            immunityTime+= Time.deltaTime;
            if(immunityTime>=immunityDuration){
                isImmune = false;
                sr.enabled=true;
            }
        }
        
    }
}
