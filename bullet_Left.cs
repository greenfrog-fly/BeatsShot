using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_Left : MonoBehaviour
{
    //銃弾制御

    public GameObject Bullet;
    public float speed;
    public float timer = 5.0f;

    public GameObject s;

    Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {

        Bullet = this.gameObject;
        Destroy(Bullet, timer);

        rig = Bullet.GetComponent<Rigidbody>();
        rig.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Destroy(Bullet);
        }

    }
}

