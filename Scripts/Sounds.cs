using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip Sound;
    public AudioSource AudioSource => GetComponent<AudioSource>();

    public void PlaySound(AudioClip clip, float volume = 1, float p = 0.85f)
    {
        AudioSource.clip = clip;
        AudioSource.pitch = p;
        AudioSource.PlayOneShot(clip, volume);
    }
}
