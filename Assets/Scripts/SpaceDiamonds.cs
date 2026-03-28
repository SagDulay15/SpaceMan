using UnityEngine;

public class SpaceDiamonds : MonoBehaviour
{
    public bool isCollected = false;

    void Start()
    {
      
    }

  
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isCollected = true;
            FindFirstObjectByType<GameManager>().AddDiamond();
            gameObject.SetActive(false);
        }
    }
}
