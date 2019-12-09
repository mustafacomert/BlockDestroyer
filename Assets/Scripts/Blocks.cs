using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour {
    public GameObject efekt;
    public static int breakableBlockCount = 0;
    [SerializeField] int life;
    [SerializeField] int hitCount;
    private SceneControlScript sceneManager;
    public Sprite[] blockView; 
 	// Use this for initialization
	void Start () {
        if (this.tag == "Breakable")
            ++breakableBlockCount;
        hitCount = 0;
        sceneManager = GameObject.FindObjectOfType<SceneControlScript>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        if (this.tag == "Breakable")
        {
            HitControl();
        }
    }

    private void HitControl()
    {
        int life = blockView.Length + 1;
        ++hitCount;
        if (hitCount >= life)
        {
            --breakableBlockCount;
            GameObject myEfect = Instantiate(efekt, this.transform.position, Quaternion.identity) as GameObject;
            myEfect.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;

            Destroy(gameObject);
            //Debug.Log(breakableBlockCount);
            if (breakableBlockCount <= 0)
                sceneManager.nextScene();
        }
        else
        {
            ChangeBlockView();
        }
    }

    private void ChangeBlockView()
    {
        this.GetComponent<SpriteRenderer>().sprite = blockView[hitCount - 1];
    }
}
