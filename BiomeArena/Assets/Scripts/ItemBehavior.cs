using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour 
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
            Debug.Log("Item collected!");

            GameManager.Items += 1;

            GameManager.PrintLootReport();
        }
    }
} 