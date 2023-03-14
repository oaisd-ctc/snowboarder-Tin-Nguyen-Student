using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{

    [SerializeField] float loadDelay = 1F;
    [SerializeField] ParticleSystem finisheffect;
    public void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            finisheffect.Play();  
           Invoke("ReloadScene", loadDelay);
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
