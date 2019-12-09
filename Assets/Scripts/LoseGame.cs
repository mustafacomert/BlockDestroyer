using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour {
    [SerializeField] SceneControlScript sceneControl;
    /*SceneControlScript sceneControl;

    private void Awake()
    {
        sceneControl = FindObjectOfType<SceneControlScript>();
    }*/

    public void OnTriggerEnter2D(Collider2D collision)
    {
        sceneControl.jumpLoseScene();
    }
}
