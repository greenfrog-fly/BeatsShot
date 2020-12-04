using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    private AudioSource click;
    public AudioClip hit;

    // Start is called before the first frame update
    void Start()
    {
        click = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            SteamVR_Fade.Start(Color.black, 1f);
            click.PlayOneShot(hit);
            Invoke("NextScene", 1);
            
        }
    }

    public void NextScene() 
        {
            SceneManager.LoadScene("select");
        } 
}
