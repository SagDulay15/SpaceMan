using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public UIFrame UIFrame;
    public GameObject player;
    public SpaceDiamonds[] allDiamonds;
    public int diamondCount = 0;
    
    public float timer = 45;
    public float startTime = 45;

    public GameObject gameOverScreen;
    public GameObject gameUI;

    public UIFrame[] allUIFrames;
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI timerAtEnd;
    public TextMeshProUGUI resultText;

    bool isGameOver = false;
    

    void Start()
    {
        player = Instantiate(player);

        startTime = timer;

        allDiamonds = FindObjectsByType<SpaceDiamonds>(FindObjectsSortMode.None);

        gameOverScreen.SetActive(false);
    }

    void Update()
    {
        if (isGameOver) return;

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = 0;
            GameOver();
        }

    }

    public void CalculateScore()
    {
        diamondCount = 0;

        foreach (SpaceDiamonds x in allDiamonds)
        {
            if (x.isCollected)
            {
                diamondCount += 1;
                x.gameObject.SetActive(false);
            }
        }
    }

    public void GameOver()
    {
        isGameOver = true;

        gameUI.SetActive(false);

        gameOverScreen.SetActive(true);

        finalScoreText.text = "$" + diamondCount.ToString();

        float elapsedTime = startTime - timer;
        timerAtEnd.text = "Time: " + Mathf.CeilToInt(elapsedTime).ToString();

        if (timer <= 0 || diamondCount < 25)
        {
            resultText.text = "NeverMind... Youre Lost";
        }


        player.GetComponent<MainCode>().DisablePlayer();



    }

    public void AddDiamond()
    {
        diamondCount++;
    }
}
