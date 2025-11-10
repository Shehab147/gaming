using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject CurrentCheckpoint;

    public Transform player;

    public Vector2 initialSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        CurrentCheckpoint = null;
        initialSpawnPoint = FindObjectOfType<PlayerController>().transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerRespawn(){
        FindObjectOfType<PlayerController>().transform.position = CurrentCheckpoint == null ? initialSpawnPoint : CurrentCheckpoint.transform.position;
    }
}
