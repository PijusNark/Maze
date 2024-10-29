using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform nextLevelSpawnPoint; 
    public SpriteRenderer scaryCompletionImage; 
    public AudioSource scarySound; 
    public Camera mainCamera; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (mainCamera != null)
        {
            Vector3 newCameraPosition = mainCamera.transform.position;
            newCameraPosition.z -= 20f; 
            mainCamera.transform.position = newCameraPosition;
        }
           
            if (scarySound != null)
            {
                scarySound.Play();
                
                
                if (scaryCompletionImage != null)
                {
                    scaryCompletionImage.enabled = true; 
                }
            }

            other.transform.position = nextLevelSpawnPoint.position;


            
        }
    }


   
    }
