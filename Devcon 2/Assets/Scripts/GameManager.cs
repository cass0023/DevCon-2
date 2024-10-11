using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    //UI TextMeshPros
    public TextMeshProUGUI butterflyCounter;
    public TextMeshProUGUI frogCounter;
    public TextMeshProUGUI cauldronCounter;
    //Collectible Counters
     public int counterButterfly;
    public int counterFrog;
    public int sumButterfly;
    public int sumFrog;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] butterflies = GameObject.FindGameObjectsWithTag("Butterfly");
        GameObject[] frogs = GameObject.FindGameObjectsWithTag("Frog");

        sumButterfly = butterflies.Length;
        sumFrog = frogs.Length;
    }

    // Update is called once per frame
    void Update()
    {
        frogCounter.text = "" + counterFrog;
        butterflyCounter.text = "" + counterButterfly;
    }
    //can be used for a ui counter / tracker of items being carried ?
    public void FrogCounter(){
        counterFrog += 1;
    }
    public void ButterflyCounter(){
        counterButterfly += 1;
    }
    public void ClearContents(){
        counterButterfly = 0;
        counterFrog = 0;
    }
    public void EndScene(){
        //put code to change to end scence here! 
        //gets called in CauldronInteract when contents in cauldron are equal to number of collectibles in scene.
        SceneManager.LoadScene("Winner");
    }
}
