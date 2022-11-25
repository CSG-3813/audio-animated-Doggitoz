using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLampFall : MonoBehaviour
{
    public string animtionParamater;
    Animator anim;
    AudioSource audioS;
    AudioClip clip;

    private void Start()
    {
        anim = GetComponent<Animator>();
        audioS = GetComponent<AudioSource>();
        clip = audioS.clip;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger(animtionParamater);
        }
    }

}
