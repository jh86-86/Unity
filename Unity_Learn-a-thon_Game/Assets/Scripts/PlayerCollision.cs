
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public int points = 0;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collisionInfo.collider.tag != "Ground")
        {
            movement.forwardForce = 100f;
        }

    }

    private void OnGUI()
    {
        //GUI.Label(new Rect(10, 10, 1000, 20), "Score: " + points);
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     GetComponent<tag>
    //     if (other.collider.tag == "CoinToCollect")
    //     {
    //         // Here you can do all sorts of cool stuff with the collected coin.
    //         // Like rotate it, activate particles, play audio, or just destroy it.
    //         Debug.Log("coin collected");
    //         // Destroys collected coin.
    //         Destroy(other.collider.gameObject);
    //     }
    // }


}
