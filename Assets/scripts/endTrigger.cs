using UnityEngine;

public class endTrigger : MonoBehaviour
{

    public GameManager gameManager;
    public bool CompleteLevel = false;
    void OnTriggerEnter()
    {
        CompleteLevel = true;
        gameManager.CompleteLevel();
    }
}
