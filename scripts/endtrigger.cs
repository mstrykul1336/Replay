using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public gamemanager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
}
