using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] CardDatabase _cardDatabase;
    [SerializeField] GameObject _cardPrefab;
    [SerializeField] int _numberOfCards;

    [SerializeField] DemandsHandler _demandsHandler;

    private List<Card> _cards = new List<Card>();

    private void Start()
    {
        CreateCards();
    }

    private void CreateCards()
    {
        for (int i = 0; i < _numberOfCards; i++)
        {
            int index = Random.Range(0, _cardDatabase.cardDatabase.Count);
            Card newCard;
        
            newCard = Instantiate(_cardPrefab, this.gameObject.transform).GetComponent<Card>();
            newCard.SetInfo(_cardDatabase.cardDatabase[index]);
            _cards.Add(newCard);

            newCard.OnInsideCaldron += NewListOfCards;
            newCard.OnInsideCaldron += _demandsHandler.AddDemandOnList;
        }
    }

    public void NewListOfCards()
    {
        for (int i = 0; i < _cards.Count; i++)
        {
            Destroy(_cards[i].gameObject);
        }
        _cards = new List<Card>();
        CreateCards();
    }

}
