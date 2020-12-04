using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class NortsSpawner : MonoBehaviour
{

    public GameObject Norts_R;
    public GameObject Norts_L;
    public double[] spawntime= { 1.196, 2.658, 4.171, 4.929, 5.641, 7.145, 8.701, 10.172, 10.88, 11.622, 13.152, 14.646, 16.150, 16.94,
    17.642, 19.135, 20.675, 22.114, 23.592, 25.1, 25.501, 26.327, 26.682, 27.042, 27.831, 28.196, 28.519, 29.322, 30.033, 30.845, 31.183,
    31.521, 32.324, 32.67, 33.042, 33.821, 34.196, 34.514, 35.28, 36.018, 37.162, 38.645, 40.133, 40.901, 41.591, 43.111, 44.657, 46.128,
    46.879, 47.6, 49.132, 50.658, 52.113, 52.865, 53.570, 55.117, 56.629, 58.138, 58.874, 59.599, 60.391, 61.127, 61.903, 62.447};

    public int[] count = { 1, 2, 3, 6, 5, 4, 7, 8, 9, 1, 5, 7, 2, 4, 8, 6, 3, 1, 5, 9, 7, 2, 6, 9, 8, 4, 1, 3, 6, 8, 5, 1, 4, 9, 6, 8, 3,
        5, 7, 2, 4, 1, 3, 2, 4, 5, 9, 8, 1, 6, 7, 3, 2, 8, 4, 6, 7, 9, 1, 2, 5, 4, 2, 6, 5 ,8};

    public float[] x = { 4, 2, 3 };
    public float[] y = { 1, 2, 3 };
    public Transform pos;
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;
    public Transform pos5;
    public Transform pos6;
    public Transform pos7;
    public Transform pos8;
    public Transform pos9;

    public int number = 0;


    public GameObject norts;
    public GameObject start;
    public GameObject start1;
    public GameObject finish;
    public GameObject finish1;

    public double time;

    private AudioSource music;
    public AudioClip bgm;

    
    


    // Start is called before the first frame update
    void Start()
    {
        SteamVR_Fade.Start(Color.black, 0f);
        SteamVR_Fade.Start(Color.clear, 1f);

        music = gameObject.AddComponent<AudioSource>();
        Invoke("begin", 2f);
        Invoke("playmusic", 4f);
       

        Invoke("NortsR", 3.196f);
        Invoke("NortsR", 4.658f);
        Invoke("NortsR", 6.171f);
        Invoke("NortsL", 6.929f);
        Invoke("NortsL", 7.641f);
        Invoke("NortsL", 9.145f);
        Invoke("NortsL", 10.701f);
        Invoke("NortsR", 12.172f);
        Invoke("NortsR", 12.88f);
        Invoke("NortsR", 13.622f);
        Invoke("NortsL", 15.152f);
        Invoke("NortsL", 16.646f);
        Invoke("NortsL", 18.150f);
        Invoke("NortsL", 18.94f);
        Invoke("NortsL", 19.642f);
        Invoke("NortsL", 21.135f);
        Invoke("NortsL", 22.675f);
        Invoke("NortsR", 24.114f);
        Invoke("NortsR", 25.592f);
        Invoke("NortsR", 27.1f);
        Invoke("NortsR", 27.501f);
        Invoke("NortsR", 28.327f);
        Invoke("NortsL", 28.682f);
        Invoke("NortsL", 29.042f);
        Invoke("NortsL", 29.831f);
        Invoke("NortsL", 30.196f);
        Invoke("NortsL", 30.519f);
        Invoke("NortsR", 31.322f);
        Invoke("NortsR", 32.033f);
        Invoke("NortsR", 32.845f);
        Invoke("NortsL", 33.183f);
        Invoke("NortsL", 33.521f);
        Invoke("NortsR", 34.324f);
        Invoke("NortsR", 34.67f);
        Invoke("NortsR", 35.042f);
        Invoke("NortsR", 35.821f);
        Invoke("NortsL", 36.196f);
        Invoke("NortsL", 36.514f);
        Invoke("NortsR", 37.28f);
        Invoke("NortsR", 38.018f);
        Invoke("NortsL", 39.162f);
        Invoke("NortsL", 40.645f);
        Invoke("NortsR", 42.133f);
        Invoke("NortsR", 42.901f);
        Invoke("NortsR", 43.591f);
        Invoke("NortsL", 45.111f);
        Invoke("NortsL", 46.657f);
        Invoke("NortsR", 48.128f);
        Invoke("NortsR", 48.879f);
        Invoke("NortsL", 49.6f);
        Invoke("NortsL", 51.132f);
        Invoke("NortsL", 52.658f);
        Invoke("NortsR", 54.113f);
        Invoke("NortsR", 54.865f);
        Invoke("NortsL", 55.570f);
        Invoke("NortsL", 57.117f);
        Invoke("NortsR", 58.629f);
        Invoke("NortsR", 60.138f);
        Invoke("NortsR", 60.874f);
        Invoke("NortsL", 61.599f);
        Invoke("NortsL", 62.391f);
        Invoke("NortsL", 63.127f);
        Invoke("NortsR", 63.903f);
        Invoke("NortsR", 64.447f);
        Invoke("end", 69f);
        Invoke("fadeout", 71f);
        Invoke("Result", 73f);




    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void begin()
    {
        start1 = Instantiate(start);
        Destroy(start1, 1.5f);
    }

    void end()
    {
        
        finish1 = Instantiate(finish);
    }

    void playmusic()
    {


        music.PlayOneShot(bgm);

    }

    void fadeout()
    {
        SteamVR_Fade.Start(Color.black, 1f);
    }

    void NortsR()
    {
        switch (count[number]) {
            case 1:
                pos = pos1;
                norts = Instantiate(Norts_R, pos) as GameObject;

                break;

            case 2:
                pos = pos2;
                norts = Instantiate(Norts_R, pos) as GameObject;

                break;

            case 3:
                pos = pos3;
                norts = Instantiate(Norts_R, pos) as GameObject;

                break;

            case 4:
                pos = pos4;
                norts = Instantiate(Norts_R, pos) as GameObject;

                break;

            case 5:
                pos = pos5;
                norts = Instantiate(Norts_R, pos) as GameObject;

                break;

            case 6:
                pos = pos6;
                norts = Instantiate(Norts_R, pos) as GameObject;

                break;

            case 7:
                pos = pos7;
                norts = Instantiate(Norts_R, pos) as GameObject;

                break;

            case 8:
                pos = pos8;
                norts = Instantiate(Norts_R, pos) as GameObject;

                break;

            case 9:
                pos = pos9;
                norts = Instantiate(Norts_R, pos) as GameObject;

                break;
        }

        number = number + 1;

    }

    void NortsL()
    {
        switch (count[number])
        {
            case 1:
                pos = pos1;
                norts = Instantiate(Norts_L, pos) as GameObject;

                break;

            case 2:
                pos = pos2;
                norts = Instantiate(Norts_L, pos) as GameObject;

                break;

            case 3:
                pos = pos3;
                norts = Instantiate(Norts_L, pos) as GameObject;

                break;

            case 4:
                pos = pos4;
                norts = Instantiate(Norts_L, pos) as GameObject;

                break;

            case 5:
                pos = pos5;
                norts = Instantiate(Norts_L, pos) as GameObject;

                break;

            case 6:
                pos = pos6;
                norts = Instantiate(Norts_L, pos) as GameObject;

                break;

            case 7:
                pos = pos7;
                norts = Instantiate(Norts_L, pos) as GameObject;

                break;

            case 8:
                pos = pos8;
                norts = Instantiate(Norts_L, pos) as GameObject;

                break;

            case 9:
                pos = pos9;
                norts = Instantiate(Norts_L, pos) as GameObject;

                break;
        }

        number = number + 1;
    }

    void Result()
    {
        SceneManager.LoadScene("result");
    }

    
}
