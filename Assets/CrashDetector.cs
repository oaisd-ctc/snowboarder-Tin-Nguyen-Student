using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float loadDelay = 0.5F;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;
    public void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
