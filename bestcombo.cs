using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bestcombo : MonoBehaviour
{
    public GameObject Text;
    ScoreBox scorebox;
    public GameObject databox;

    public int combo;
    public string combo1;


    // Start is called before the first frame update
    void Start()
    {
        Text = this.gameObject;
        databox = GameObject.Find("ScoreBox");
        scorebox = databox.GetComponent<ScoreBox>();

        combo = scorebox.getCombo;
        combo1 = combo.ToString();
        Text.GetComponent<TextMesh>().text = combo1;

    }

    // Update is called once per frame
    void Update()
    {
        combo = scorebox.getCombo;
        combo1 = combo.ToString();
        Text.GetComponent<TextMesh>().text = combo1;
    }
}
