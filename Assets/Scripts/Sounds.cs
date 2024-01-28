using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public SoundArrays[] sounds;
    
    public AudioSource audioSrc => GetComponent<AudioSource>();

    public void PlaySound(int i, float volume = 1f, bool random = false, bool destroyed = false, float p1=0.8f,float p2 = 1.2f)
    {
        AudioClip clip = random ? sounds[i].randSound[Random.Range(0, sounds[i].randSound.Length)] : sounds[i].randSound[0];
        audioSrc.pitch = Random.Range(p1, p2);
        if (destroyed)
            AudioSource.PlayClipAtPoint(clip, transform.position, volume);
        else
            audioSrc.PlayOneShot(clip, volume);
        
    }



    [System.Serializable]
    public class SoundArrays
    {
        public AudioClip[] randSound;
    }
}
