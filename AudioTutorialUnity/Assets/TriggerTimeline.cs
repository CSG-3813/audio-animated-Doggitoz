using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeline : MonoBehaviour
{

    PlayableDirector timeline;
    // Start is called before the first frame update
    void Awake()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            timeline.Play();
        }
    }
}
