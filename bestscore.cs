using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bestscore : MonoBehaviour
{
    public GameObject Text;
    ScoreBox scorebox;
    public GameObject databox;

    public int score;
    public string score1;


    // Start is called before the first frame update
    void Start()
    {
        Text = this.gameObject;
        databox = GameObject.Find("ScoreBox");
        scorebox = databox.GetComponent<ScoreBox>();

        score = scorebox.getScore;
        score1 = score.ToString();
        Text.GetComponent<TextMesh>().text = score1;
        
    }

    // Update is called once per frame
    void Update()
    {
        score = scorebox.getScore;
        score1 = score.ToString();
        Text.GetComponent<TextMesh>().text = score1;
    }
}
