using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Card : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField] TextMeshProUGUI _valueText;
    [SerializeField] Image _backImage;

    private CardInfo _cardInfo;
    private Cauldron _cauldron;
    private int _value;
    private string _name;

    public Action OnInsideCaldron;

    public void SetInfo(CardInfo cardInfo)
    {
        this._cardInfo = cardInfo;

        _value = _cardInfo.value;
        _valueText.text = _value.ToString();
        _backImage.color = CardColors.GetColor(_cardInfo.color);
        _name = _cardInfo.name;
    }

    public void OnDrag(PointerEventData data)
    {
        this.gameObject.transform.position = data.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(_cauldron != null)
        {
            _cauldron.CalculateBar(this._cardInfo);
            OnInsideCaldron.Invoke();
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Cauldron")
        {
            _cauldron = collider.GetComponent<Cauldron>();
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Cauldron")
        {
            _cauldron = null;
        }
    }

}
