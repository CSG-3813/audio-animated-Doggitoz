/***
 * Author: Stu Dent
 * Create: 10/18/22
 * Modified:
 * Description: triggers the witch animation and sound cackle
 ***/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
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
      if(other.tag == "Player")
        {
            anim.SetTrigger(animtionParamater);
        }
    }

////private void OnTriggerExit(Collider other)
////    {
////        if (other.tag == "Player")
////        {
////            anim.Trigger(animtionParamater, false);
////        }
////    }


    void playCackle()
    {
        audioS.PlayOneShot(clip);
    }


}
