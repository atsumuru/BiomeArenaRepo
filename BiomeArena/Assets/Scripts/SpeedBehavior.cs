using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBehavior : MonoBehaviour
{
    public GameBehavior GameManager;
    public AudioSource sound;

    void Start()
    {
        GameManager = GameObject.Find("Game Manager").GetComponent<GameBehavior>();
        sound = gameObject.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            AudioSource.PlayClipAtPoint(sound.clip, transform.position);
            Destroy(this.gameObject);
            Debug.Log("Speed Pickup collected!");

            GameManager.Speed *= 2f;
        }
        
    }
}