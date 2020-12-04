using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class LeftHand : MonoBehaviour
{
    //コントローラー右制御

    public SteamVR_Input_Sources leftHand;
    public SteamVR_Action_Boolean leftGripPinch;
    public SteamVR_Action_Boolean Pause;
    public SteamVR_Action_Boolean leftReload;

    public GameObject HandGun;
    public GameObject HandGun1;
    public GameObject Pos;
    public Transform Pos1;


    // Start is called before the first frame update
    void Start()
    {
        Pos = GameObject.Find("Controller (left)");
        Pos1 = Pos.GetComponent<Transform>();
        
        HandGun1 = Instantiate(HandGun,Pos1) as GameObject;
        HandGun1.transform.parent = Pos.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
