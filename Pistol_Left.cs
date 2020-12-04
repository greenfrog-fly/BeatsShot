using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Pistol_Left : MonoBehaviour
{
    public SteamVR_Input_Sources leftHand;
    public SteamVR_Action_Boolean LeftGripPinch;
    public SteamVR_Action_Boolean Pause;
    public SteamVR_Action_Boolean LeftReload;

    public GameObject Bullet;  //弾
    public GameObject Bullet1;  // 弾インスタンス入れ
    public GameObject Gun;  //本体
    public Transform fire;  //発射位置
    public int MagCon;  //マガジン数
    public int Mag;  //マガジン残弾数

    private AudioSource pistol_audio;
    public AudioClip audio_shot;  //発射音
    public AudioClip audio_noammo;  //弾切れ音
    public AudioClip audio_reload;  //リロード音


    public GameObject trigger;
    public Animation trigger1;
    public GameObject slider;
    public Animation slider1;

    // Start is called before the first frame update
    void Start()
    {
        Gun = this.gameObject;
        fire = Gun.GetComponent<Transform>();
        pistol_audio = gameObject.AddComponent<AudioSource>();
        Mag = MagCon;

        trigger = GameObject.Find("Trigger_L");
        slider = GameObject.Find("Slide_L");
        trigger1 = trigger.gameObject.GetComponent<Animation>();
        slider1 = slider.gameObject.GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Mag > 0)
        {
            if (SteamVR_Input.GetStateDown("LeftGripPinch", leftHand))
            {
                trigger1.Play("trigger_L");
                slider1.Play("slide_L");

                Bullet1 = Instantiate(Bullet, fire) as GameObject;
                pistol_audio.PlayOneShot(audio_shot);
                Bullet1.transform.parent = null;
                Mag = Mag - 1;
            }
        }
        else if (Mag == 0)
        {
            if (SteamVR_Input.GetStateDown("LeftGripPinch", leftHand))
            {
                trigger1.Play("trigger_L");
                pistol_audio.PlayOneShot(audio_noammo);
            }
        }

        if (SteamVR_Input.GetStateDown("LeftReload", leftHand))
        {
            Mag = MagCon;
            pistol_audio.PlayOneShot(audio_reload);
        }
    }
}
