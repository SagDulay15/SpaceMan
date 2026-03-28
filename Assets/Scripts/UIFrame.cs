using UnityEngine;
using TMPro;

public class UIFrame : MonoBehaviour

{
    public GameManager gameManager;
    public TextMeshProUGUI diamondsCollected;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI stars;




    private void Update()
    {
        diamondsCollected.text = "$" + gameManager.diamondCount;
        timer.text = "" + Mathf.Ceil(gameManager.timer);
    }


    public void SetStars(int starCount)
    {
        stars.text = starCount + "Stars";
    }
}
