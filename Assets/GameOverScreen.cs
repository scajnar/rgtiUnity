using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public void Setup(int score) {
        gameObject.SetActive(true);
        pointsText.text = "POINTS: " + score.ToString();
    }

    public void RestartButton()
    {
        CollectItemsCounter.powerup_count = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MenuButton()
    {

    }
}
