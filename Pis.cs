using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Pis : MonoBehaviour
{
    public SteamVR_Input_Sources rightHand;
    public SteamVR_Action_Boolean RightGripPinch;
    public SteamVR_Action_Boolean Pause;
    public SteamVR_Action_Boolean RightReload;

    public GameObject Bullet;  //弾
    public GameObject Bullet1;  // 弾インスタンス入れ
    public GameObject Gun;  //本体
    public Transform fire;  //発射位置
    

    private AudioSource pistol_audio;
    public AudioClip audio_shot;  //発射音
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
        
        trigger = GameObject.Find("Trigger");
        slider = GameObject.Find("Slide");
        trigger1 = trigger.gameObject.GetComponent<Animation>();
        slider1 = slider.gameObject.GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Input.GetStateDown("RightGripPinch", rightHand))
        {
            trigger1.Play("trigger");
            slider1.Play("slide");
            
            Bullet1 = Instantiate(Bullet, fire) as GameObject;
            pistol_audio.PlayOneShot(audio_shot);
            Bullet1.transform.parent = null;
        }

    }
}
