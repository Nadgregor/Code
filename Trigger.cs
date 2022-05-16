using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] public AudioSource audio;
    [SerializeField] private Animator axen = null;
    [SerializeField] private bool openTrigger = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
                axen.Play("axe", 0, 0.0f);
                gameObject.SetActive(false);

            Invoke(nameof(PlaySound), 0.5f);

        }
    }
    private void PlaySound()
    {
        audio.Play();
    }

    
}
