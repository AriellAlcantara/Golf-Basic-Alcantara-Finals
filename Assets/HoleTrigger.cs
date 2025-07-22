using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    public GameObject victoryPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GolfBall"))
        {
            victoryPanel.SetActive(true);
            Time.timeScale = 0f; // Pause the game
        }
    }
}
