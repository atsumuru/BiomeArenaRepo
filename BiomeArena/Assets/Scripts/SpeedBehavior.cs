using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBehavior : MonoBehaviour
{
    public GameBehavior GameManager;
    void Start()
    {
          GameManager = GameObject.Find("Game Manager").GetComponent<GameBehavior>();        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("help me pls :3");
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("Speed Pickup collected!");


            GameManager.Speed *= 2f;
        }
        
    }
}