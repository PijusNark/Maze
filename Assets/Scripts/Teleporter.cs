using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform nextLevelSpawnPoint; // Assign the spawn point for the next level
    public SpriteRenderer scaryCompletionImage; // Assign the Sprite Renderer for the scary image
    public AudioSource scarySound; // Assign the scary sound to play
    public Camera mainCamera; // Assign the Camera to move

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (mainCamera != null)
        {
            Vector3 newCameraPosition = mainCamera.transform.position;
            newCameraPosition.z -= 20f; // Move the camera 20 units to the left (adjust as needed)
            mainCamera.transform.position = newCameraPosition;
        }
            // Play the scary sound
            if (scarySound != null)
            {
                scarySound.Play();
                
                // Activate the scary image when the sound plays
                if (scaryCompletionImage != null)
                {
                    scaryCompletionImage.enabled = true; // Enable the Sprite Renderer
                }
            }

            // Teleport the player to the next level spawn point
            other.transform.position = nextLevelSpawnPoint.position;

            // Move the camera back
            MoveCameraBack();

            
        }
    }

    private void MoveCameraBack()
    {
        
    }

   
    }
