using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    public int setScore;  //セーブデータ
    public int setCombo;
    public int getScore = 0;
    public int getCombo = 0;

    public int getpoint = 0;  //生もの
    public int combo = 0;
    public int combomax = 0;
    public int miss = 0;

    public bool DontDestroyEnabled = true;
    public bool save = false;

    public AudioSource hitaudio;
    public AudioClip bad;

    // Start is called before the first frame update
    void Start()
    {
        if (DontDestroyEnabled)
        {
            
            DontDestroyOnLoad(this);
        }

        hitaudio = gameObject.AddComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        getScore = PlayerPrefs.GetInt("Score");
        getCombo = PlayerPrefs.GetInt("Combo");


        if (combomax < combo)
        {
            combomax = combo;
        }

        if(getScore < getpoint)
        {
            setScore = getpoint;
        }

        if(getCombo < combomax)
        {
            setCombo = combomax;
        }

        if(save == true)
        {
            PlayerPrefs.SetInt("Score", setScore);
            PlayerPrefs.SetInt("Combo", setCombo);
            PlayerPrefs.Save();
            save = false;
        }
    }
}
