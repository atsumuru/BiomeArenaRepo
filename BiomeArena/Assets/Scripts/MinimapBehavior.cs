using UnityEngine;

public class MinimapBehavior : MonoBehaviour
{

    public Transform Player; // Reference to the player's transform
    void LateUpdate()
    {
        if (Player != null)
        {
            Vector3 newPosition = Player.position;
            newPosition.y = transform.position.y; // Keep the minimap at a fixed height
            transform.position = newPosition;

            transform.rotation = Quaternion.Euler(90f, Player.eulerAngles.y, 0f); // Rotate the minimap to match the player's orientation
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
