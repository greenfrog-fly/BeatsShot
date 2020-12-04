using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target2 : MonoBehaviour
{
    public GameObject target;

    //ノーツ出現位置
    public float x;
    public float y;
    public float z;

    //原点
    public GameObject root;


    public GameObject score;
    ScoreBox scorebox;

    Transform pos;
    public GameObject particle;
    public GameObject particle1;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("ScoreBox");
        scorebox = score.GetComponent<ScoreBox>();
        root = GameObject.Find("Camera");
        target = this.gameObject;
        //Destroy(target, 2.5f);

        pos = this.transform;

        //target.transform.position = new Vector3(x, y, z);
        //this.transform.LookAt(root.transform);

        Invoke("targetdestroy", 2.7f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet_L"))
        {
            particle1 = Instantiate(particle, pos) as GameObject;
            particle1.transform.parent = null;
            scorebox.getpoint = scorebox.getpoint + 100;
            scorebox.combo = scorebox.combo + 1;
            Destroy(target);
        }else if (collision.gameObject.CompareTag("bullet_R"))
        {
            scorebox.hitaudio.PlayOneShot(scorebox.bad);
            scorebox.combo = 0;
            scorebox.miss = scorebox.miss + 1;
            Destroy(target);
        }
    }

    public void targetdestroy()
    {
        scorebox.combo = 0;
        scorebox.miss = scorebox.miss + 1;
        Destroy(target);
    }
}
