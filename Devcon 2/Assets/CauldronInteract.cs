using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class CauldronInteract : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerController playerController;

    public int cauldronButterfly;
    public int cauldronFrog;
    public GameObject collectPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cauldronButterfly >= gameManager.sumButterfly && cauldronFrog >= gameManager.sumFrog){
            gameManager.EndScene();
        }
    }
    public void OnTriggerEnter2D(Collider2D collider){
        if (collider.gameObject == collectPoint && playerController.interact == true){
            if(gameManager.counterButterfly > 0){
               int temp = gameManager.counterButterfly;
               cauldronButterfly += temp;
               Debug.Log("butterfly - " + cauldronButterfly);
            }
            if(gameManager.counterFrog > 0){
                int temp = gameManager.counterFrog;
                cauldronFrog += temp;
                Debug.Log("frog - " + cauldronFrog);
            }   
            gameManager.ClearContents();         
        }
    }
}
