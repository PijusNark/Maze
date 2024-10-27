using UnityEngine;
using UnityEngine.UI; // Required for UI elements

public class LevelCompletion : MonoBehaviour
{
    public GameObject completionImage; // Assign the UI Image object
    public AudioSource completionSound; // Assign the Audio Source object

    // Call this method when the player completes the level
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
