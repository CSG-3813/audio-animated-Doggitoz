using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TriggerLampFall : MonoBehaviour
{
    public string animtionParamater;
    Animator anim;
    AudioSource audioS;
    [SerializeField] AudioClip clip;
    [SerializeField] AudioMixer audioM;
    [SerializeField] AudioMixerSnapshot snapshot;

    bool playerTriggered = false;
    float timeSinceTriggered = 0f;
    bool finished = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
        audioS = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!playerTriggered || finished)
        {
            return;
        }
        timeSinceTriggered += Time.deltaTime;
        if (timeSinceTriggered >= 1.7f)
        {
            audioS.PlayOneShot(clip);
            audioM.FindSnapshot("Default").TransitionTo(2f);
            finished = true;
        }
        else if (timeSinceTriggered >= 1f)
        {
            anim.SetTrigger(animtionParamater);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTriggered = true;
            snapshot.TransitionTo(1f);
        }
    }

}
