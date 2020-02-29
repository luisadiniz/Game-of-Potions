using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using TMPro;

public class Cauldron : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] TextMeshProUGUI _redValueText;
    [SerializeField] TextMeshProUGUI _greenValueText;
    [SerializeField] TextMeshProUGUI _blueValueText;

    [SerializeField] GameObject _potionPrefab;

    private int _redValue;
    private int _greenValue;
    private int _blueValue;

    private GameObject _newPotion;

    public void CalculateBar(CardInfo card)
    {
        switch (card.color)
        {
            case CardColors.Colors.Red:
                _redValue += card.value;
                if (_redValue > 0)
                {
                    _redValueText.text = _redValue.ToString();
                    _redValueText.gameObject.SetActive(true);
                }
                break;
            case CardColors.Colors.Green:
                _greenValue += card.value;
                if (_greenValue > 0)
                {
                    _greenValueText.text = _greenValue.ToString();
                    _greenValueText.gameObject.SetActive(true);
                }
                break;
            case CardColors.Colors.Blue:
                _blueValue += card.value;
                if (_blueValue > 0)
                {
                    _blueValueText.text = _blueValue.ToString();
                    _blueValueText.gameObject.SetActive(true);
                }
                break;
        }
    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        _newPotion = Instantiate(_potionPrefab, this.gameObject.transform);
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        _newPotion.GetComponent<Potion>().DropPotion(_redValue, _greenValue, _blueValue, this);
        Destroy(_newPotion);
    }

    public void ResetCauldron()
    {
        _redValue = 0;
        _greenValue = 0;
        _blueValue = 0;

        _redValueText.text = _redValue.ToString();
        _greenValueText.text = _greenValue.ToString();
        _blueValueText.text = _blueValue.ToString();

    }
}
