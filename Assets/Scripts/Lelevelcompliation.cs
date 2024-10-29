using UnityEngine;
using UnityEngine.UI; // Required for UI elements

public class LevelCompletion : MonoBehaviour
{
    public GameObject completionImage; 
    public AudioSource completionSound; 

    
    public void OnLevelComplete()
    {
        // Play the completion sound
        if (completionSound != null)
        {
            completionSound.Play();
        }

        // Show the completion image
        if (completionImage != null)
        {
            completionImage.SetActive(true);
        }
    }
}
