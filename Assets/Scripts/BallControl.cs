using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    [SerializeField] BarControl bar;
    private bool isStart = false;
    private Vector3 distanceBetweenBallAndBar;
	// Use this for initialization
	void Start () {
        //top ile bar arasındaki farkı saklıyoruz
        distanceBetweenBallAndBar = this.transform.position - bar.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        //oyun başlamadıysa
		if(!isStart)
        {
            //oyun başlamadığı sürece bar ile top arasındaki mesafeyi koruyoruz 
            this.transform.position = bar.transform.position + distanceBetweenBallAndBar;
            //mouse tıklanmasıyla topumuza bir ivme kazandırıyoruz.
            if (Input.GetMouseButtonDown(0))
            {
                isStart = true;
                if (this.tag == "YavasTop")
                    this.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 9f);
                else
                    this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 12f);
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 ufakSapma = new Vector2(Random.Range(0f, 0.5f), Random.Range(0f, 0.5f));
        if (isStart)
        {
            GetComponent<AudioSource>().Play();
            if(Random.Range(1, 1000) % 2 == 0)
                GetComponent<Rigidbody2D>().velocity += ufakSapma;
            else
                GetComponent<Rigidbody2D>().velocity -= ufakSapma;
        }
    }
}
