using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    [SerializeField] private AudioSource audioSrc;

    private void Start()
    {
        if (audioSrc == null)
        {
            audioSrc = GetComponent<AudioSource>();
        }
    }

    private void OnMouseDown()
    {
        if (!audioSrc.isPlaying)
        {
            audioSrc.Play();
        }
    }
}
