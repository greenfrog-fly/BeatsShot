using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultMiss : MonoBehaviour
{
    public GameObject score;
    ScoreBox scorebox;
    public GameObject Text;

    public int miss;
    public string miss1;


    // Start is called before the first frame update
    void Start()
    {
        Text = this.gameObject;
        score = GameObject.Find("ScoreBox");
        scorebox = score.GetComponent<ScoreBox>();
        miss = scorebox.miss;
        miss1 = miss.ToString();
        Text.GetComponent<TextMesh>().text = miss1;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
