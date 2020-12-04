using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omake : MonoBehaviour
{

    public GameObject stone;
    public GameObject inst1;
    public GameObject inst2;
    Transform pos;

    int i;
    float x;
    float y;
    float z;

    public GameObject particle;
    public GameObject particle1;

    // Start is called before the first frame update
    void Start()
    {
        stone = this.gameObject;
        pos = this.transform;

        i = Random.Range(0, 3);

        if (i == 0)
        {
            x = 5f;
            y = Random.Range(0.5f, 3.5f);
            z = Random.Range(-3f, 3f);
            stone.transform.position = new Vector3(x, y, z);
            
            
        }
        else if (i == 1)
        {
            x = Random.Range(-3f, 3f);
            y = Random.Range(0.5f, 3.5f);
            z = -5f;
            stone.transform.position = new Vector3(x, y, z);
            
        }
        else if (i == 2)
        {
            x = -5f;
            y = Random.Range(0.5f, 3.5f);
            z = Random.Range(-3f, 3f);
            stone.transform.position = new Vector3(x, y, z);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            particle1 = Instantiate(particle, pos) as GameObject;
            particle1.transform.parent = null;
            inst2 = Instantiate(inst1);
            Destroy(stone);
        }
    }




   
}
