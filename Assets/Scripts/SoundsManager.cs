using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip jumpSound; // Assign in Inspector
    public AudioClip gameOverSound; // Assign in Inspector
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpSound);
    }

    public void PlayGameOverSound()
    {
        audioSource.PlayOneShot(gameOverSound);
    }
}
