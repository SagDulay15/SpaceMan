using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public UIFrame UIFrame;
    public GameObject player;
    public SpaceDiamonds[] allDiamonds;
    public int diamondCount = 0;
    
    public float timer = 45f;

    public GameObject gameOverScreen;

    public UIFrame[] allUIFrames;
    

    void Start()
    {
        Instantiate(player);

        allDiamonds = FindObjectsByType<SpaceDiamonds>(FindObjectsSortMode.None);

        gameOverScreen.SetActive(false);
    }


    void Update()
    {
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
        

        if (diamondCount >= 35 && timer >= 9)
        {
        
        }

        else if (diamondCount >= 25)
        {
        
        }

        

       

        gameOverScreen.SetActive(true);

        Destroy(player);

        Debug.Log("gameover");
    }


    public void AddDiamond()
    {
        diamondCount++;
    }
}
