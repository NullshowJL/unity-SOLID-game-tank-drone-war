using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMgr : MonoBehaviour
{
    [SerializeField] private AudioClip droneDestroyClip;
    [SerializeField] private AudioClip tankFiredClip;
    [SerializeField] private AudioClip tankDamagedClip;
    [SerializeField] private AudioSource audiosource;

    private void PlayDroneDetroyAudio()
    {
        audiosource.PlayOneShot(droneDestroyClip);
    }
    
    private void PlayTankFiredAudio()
    {
        audiosource.PlayOneShot(tankFiredClip);
    }
    
    private void PlayTankDamagedAudio()
    {
        audiosource.PlayOneShot(tankDamagedClip);
    }
    
    private void OnEnable()
    {
        SubscribeEvents();
    }

    private void OnDisable()
    {
        UnSubscribeEvents();
    }

    private void SubscribeEvents()
    {
        GameEvents.OnDroneDestroy += PlayDroneDetroyAudio;
        GameEvents.OnTankFired += PlayTankFiredAudio;
        GameEvents.OnTankDamaged += PlayTankDamagedAudio;
    }
    
    private void UnSubscribeEvents()
    {
        GameEvents.OnDroneDestroy -= PlayDroneDetroyAudio;
        GameEvents.OnTankFired -= PlayTankFiredAudio;
        GameEvents.OnTankDamaged -= PlayTankDamagedAudio;
    }
}
