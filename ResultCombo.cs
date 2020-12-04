using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultCombo : MonoBehaviour
{
    public GameObject score;
    ScoreBox scorebox;
    public GameObject Text;

    public int combo;
    public string combo1;


    // Start is called before the first frame update
    void Start()
    {
        Text = this.gameObject;
        score = GameObject.Find("ScoreBox");
        scorebox = score.GetComponent<ScoreBox>();
        combo = scorebox.combomax;
        combo1 = combo.ToString();
        Text.GetComponent<TextMesh>().text = combo1;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
