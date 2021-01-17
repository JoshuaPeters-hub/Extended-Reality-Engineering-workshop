using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HitWoman : MonoBehaviour
{
    public AudioSource Slapclip;
    public int EnterNewScene;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            EnterNewScene++;
            if(EnterNewScene >= 2)
            {
                Debug.Log("HIT");
                Slapclip.Play();
            }
        }
    }

    private void Update()
    {
        if (EnterNewScene == 3)
        {
            SceneManager.LoadScene("End");
        }
    }
}
