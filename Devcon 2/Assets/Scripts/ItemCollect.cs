using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerController playerController;
    
    //obj attached to player to act as 'net'
    public GameObject collect;
    
    public void OnTriggerStay2D(Collider2D collider){
        //if the player clicks on this gameobj it will add to the counter in game manager
        //and will destroy the obj -cc
        //**need to add stuff to gamemanager functions to count items collected
        if(playerController.interact == true && collider.gameObject == collect){
            CheckObject();
            Destroy(gameObject);       
        }
    }
    private void CheckObject(){
        if (gameObject.CompareTag("Frog")){
            gameManager.FrogCounter();
            Debug.Log("Interacted with frog");
        }
        if (gameObject.CompareTag("Butterfly")){
            gameManager.ButterflyCounter();
            Debug.Log("Interacted with butterfly");
        } 
    }
}
