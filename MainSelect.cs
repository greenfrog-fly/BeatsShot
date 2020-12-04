using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class MainSelect : MonoBehaviour
{
    public GameObject score;
    ScoreBox scorebox;

    private AudioSource click;
    public AudioClip hit;

    public AudioSource bgm;
    public GameObject bgmobj;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("ScoreBox");
        scorebox = score.GetComponent<ScoreBox>();

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
        if (collision.gameObject)
        {
            SteamVR_Fade.Start(Color.black, 1f);
            click.PlayOneShot(hit);
            Invoke("Select", 1);

        }
    }

    public void Select()
    {
        bgm.mute = false;
        scorebox.getpoint = 0;
        scorebox.combo = 0;
        scorebox.combomax = 0;
        scorebox.miss = 0;
        
        SceneManager.LoadScene("select");
    }
}
