using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class burnplace : MonoBehaviour
{


    private AudioSource click;
    public AudioClip hit;

    public AudioSource bgm;
    public GameObject bgmobj;

    // Start is called before the first frame update
    void Start()
    {
        SteamVR_Fade.Start(Color.black, 0f);
        SteamVR_Fade.Start(Color.clear, 1f);
        click = gameObject.AddComponent<AudioSource>();
        bgmobj = GameObject.Find("BGM");
        bgm = bgmobj.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {

        click.PlayOneShot(hit);
        SteamVR_Fade.Start(Color.black, 1f);
            Invoke("NextScene", 1.5f);
        }
    }

    public void NextScene()
    {
        bgm.mute = true;
        SceneManager.LoadScene("Main");
    }
}
