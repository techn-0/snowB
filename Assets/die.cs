using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour
{

    [SerializeField] ParticleSystem dead;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ground")
        {
            dead.Play();
            Invoke("ReloadScene", 2f);
        }
    }

        void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
