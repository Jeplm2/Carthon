using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    public AudioSource med;
    public AudioSource low;
    public AudioSource clank;

    public AudioSource drift;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            med.Pause();
            low.Play();
            clank.Play();
            drift.Play();
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
