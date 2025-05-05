using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterCollisionHandler : MonoBehaviour
{
    public Canvas deathCanvas; // Assign in Inspector

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has been hit by the monster!");
            if (deathCanvas != null)
            {
                deathCanvas.gameObject.SetActive(true);
            }
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;
        }
    }
}
