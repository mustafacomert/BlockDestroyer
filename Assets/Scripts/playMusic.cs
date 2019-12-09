using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMusic : MonoBehaviour {

    [SerializeField] static playMusic playOnlyOneMusic = null;

    private void Awake()
    {
        //eğer daha önce bir muzik objesi oluştuysa
        //yeni gelen müzik objesini yok et
        //böylece oyunda boyunca yalnız bir tane müzik objesi kalmış olacak.
        if (playOnlyOneMusic != null)
        {
            Destroy(gameObject);
        }
        //müzik objesi daha önce oluşmadıysa, oluşturuyoruz.
        else
        {
            playOnlyOneMusic = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}
