using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PauseKey : MonoBehaviour
{
    public SteamVR_Input_Sources rightHand;
    
    public SteamVR_Action_Boolean Pause;
    

    public SteamVR_Input_Sources leftHand;

    public bool pausebool = false;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (pausebool == false)
        {
            if (SteamVR_Input.GetStateDown("Pause", rightHand))
            {
                Time.timeScale = 0f;
                pausebool = true;
                Debug.Log(pausebool);
            }else if(SteamVR_Input.GetStateDown("Pause", leftHand))
            {
                Time.timeScale = 0f;
                pausebool = true;
                Debug.Log(pausebool);
            }
        }

        if(pausebool == true)
        {
            if (SteamVR_Input.GetStateDown("Pause", rightHand))
            {
                Time.timeScale = 1f;
                pausebool = false;
            }
            else if (SteamVR_Input.GetStateDown("Pause", leftHand))
            {
                Time.timeScale = 1f;
                pausebool = false;
            }
        }*/
    }
}
