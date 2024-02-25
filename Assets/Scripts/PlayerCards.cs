using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCards : MonoBehaviour
{
    private List<ICard> _playerCards = new();

    public void AddCard(PickUpItemType a_PickUpItemType)
    {
        switch (a_PickUpItemType)
        {
            case PickUpItemType.JumpCard:
                _playerCards.Add(new JumpCard());
                break;
            case PickUpItemType.Card2:
                break;
            case PickUpItemType.Card3:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(a_PickUpItemType), a_PickUpItemType, null);
        }

        int i = 0;
        Debug.Log("Current cards:");
        foreach (var card in _playerCards)
        {
            Debug.Log(_playerCards[i]);
            i++;
        }
    }

    public void Use_TopCard()
    {
        if (_playerCards.Count == 0)
        {
            return;
        }
            
        _playerCards[0].Use();
        _playerCards.RemoveAt(0);
    }
}