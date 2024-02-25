using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    [SerializeField] private PickUpItemType itemType;

    private PlayerCards _playerCards;
    
    private void OnTriggerEnter2D(Collider2D a_Other)
    {
        if (!a_Other.CompareTag("Player")) return;

        GameObject player = a_Other.gameObject;
        _playerCards = player.GetComponent<PlayerCards>();
        PickUp();
    }

    private void PickUp()
    { 
        Debug.Log("Player picked up: " + itemType);
        _playerCards.AddCard(itemType);
        Destroy(gameObject);
    }
}