using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;


public class restart : MonoBehaviour
{
    public GameObject score;
    ScoreBox scorebox;

    private AudioSource click;
    public AudioClip hit;

    // Start is called before the first frame update
    void Start()
    {
        SteamVR_Fade.Start(Color.black, 0f);
        SteamVR_Fade.Start(Color.clear, 1f);
        score = GameObject.Find("ScoreBox");
        scorebox = score.GetComponent<ScoreBox>();
        click = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            click.PlayOneShot(hit);
            SteamVR_Fade.Start(Color.black, 1f);
            Invoke("ReStart", 1);

        }
    }

    public void ReStart()
    {
        scorebox.getpoint = 0;
        scorebox.combo = 0;
        scorebox.combomax = 0;
        scorebox.miss = 0;
        scorebox.save = true;
        SceneManager.LoadScene("Main");
    }

}
