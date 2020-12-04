using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScore : MonoBehaviour
{
    


    public GameObject score;
    ScoreBox scorebox;
    public GameObject Text;

    public int tokuten;
    public string tokuten1;


    // Start is called before the first frame update
    void Start()
    {
        Text = this.gameObject;
        score = GameObject.Find("ScoreBox");
        scorebox = score.GetComponent<ScoreBox>();
        tokuten = scorebox.getpoint;
        tokuten1 = tokuten.ToString();
        Text.GetComponent<TextMesh>().text = tokuten1;


    }

    // Update is called once per frame
    void Update()
    {

        



    }
}
