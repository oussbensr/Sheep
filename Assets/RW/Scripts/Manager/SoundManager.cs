using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioClip shootclip;
    public AudioClip sheepHitClip;
    public AudioClip sheepDroppedClip;
    private Vector3 cameraPosition;
    void Awake()
    {
        Instance = this;
        cameraPosition=Camera.main.transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PlaySound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, cameraPosition);
    }
    public void playShootClip()
    {
        PlaySound(shootclip);
    }
    public void playsheepHitClip()
    {
        PlaySound(sheepHitClip);
    }
    public void playsheepDroppedClip()
    {
        PlaySound(sheepDroppedClip);
    }
}
