using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float loadDelay = 0.5F;
    public void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
