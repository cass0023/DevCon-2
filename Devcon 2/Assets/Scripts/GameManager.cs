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
    private int counterButterfly;
    private int counterFrog;

    // Start is called before the first frame update
    void Start()
    {
        
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
}
