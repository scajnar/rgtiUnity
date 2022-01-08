using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Transform player;
    bool gameHasEnded = false;

    public float restartDelay = 1f;
    public GameOverScreen GameOverScreen;
    public void EndGame() {

        if(gameHasEnded == false){
            Debug.Log("GAME OVER");
            gameHasEnded = true;

            Invoke("feedDog", 2);
            

        }
    }

    void feedDog()
    {
        //Debug.Log("Dog fed");
        GameOverScreen.Setup((int)(player.position.z));
    }

}
