using UnityEngine;
using UnityEngine.SceneManagement; // To reload the scene

public class BoundaryChecker : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Player has left the maze! Game Over!");
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
