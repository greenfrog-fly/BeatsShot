using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboText : MonoBehaviour
{
    public GameObject score;
    ScoreBox scorebox;
    public GameObject Text;

    public int chein;
    public string chein1;


    // Start is called before the first frame update
    void Start()
    {
        Text = this.gameObject;
        score = GameObject.Find("ScoreBox");
        scorebox = score.GetComponent<ScoreBox>();
        chein = scorebox.combo;


    }

    // Update is called once per frame
    void Update()
    {

        chein = scorebox.combo;
        chein1 = chein.ToString();
        Text.GetComponent<TextMesh>().text = chein1;



    }
}
