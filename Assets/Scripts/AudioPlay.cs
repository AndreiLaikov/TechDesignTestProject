using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    [SerializeField] private AudioSource audio;

    private void Start()
    {
        if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }
    }

    private void OnMouseDown()
    {
        if (!audio.isPlaying)
        {
            audio.Play();
        }
    }
}
