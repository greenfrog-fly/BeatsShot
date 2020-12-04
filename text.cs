using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text : MonoBehaviour
{
    //残弾表示

    public Pistol pistol;
    public GameObject handgun;
    public GameObject Text;
    
    public int tama1;
    public string tama2;

    // Start is called before the first frame update
    void Start()
    {
        Text = this.gameObject;
        handgun = GameObject.Find("M1911_R(Clone)");
        pistol = handgun.GetComponent<Pistol>();
        tama1 = pistol.Mag;
        tama2 = tama1.ToString();
        Text.GetComponent<TextMesh>().text = tama2;

    }

    // Update is called once per frame
    void Update()
    {

        tama1 = pistol.Mag;
        tama2 = tama1.ToString();

        if (tama1 > 0)
        {
            
            Text.GetComponent<TextMesh>().text = tama2;
            Text.GetComponent<TextMesh>().color = Color.white;

        }
        else
        {
            Text.GetComponent<TextMesh>().text = tama2;
            Text.GetComponent<TextMesh>().color = Color.red;
        }
       
        
    }
}
