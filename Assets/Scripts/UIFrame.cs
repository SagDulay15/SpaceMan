using UnityEngine;
using TMPro;

public class UIFrame : MonoBehaviour

{
    public GameManager gameManager;
    public TextMeshProUGUI diamondsCollected;
    public TextMeshProUGUI timer;
    

    private void Update()
    {
        diamondsCollected.text = "$" + gameManager.diamondCount;
        timer.text =Mathf.CeilToInt(gameManager.timer).ToString();
    }

}
