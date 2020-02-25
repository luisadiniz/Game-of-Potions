using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Demand : MonoBehaviour
{
    [SerializeField] List<GameObject> _elements;
    [SerializeField] TextMeshProUGUI _redValueText;
    [SerializeField] TextMeshProUGUI _greenValueText;
    [SerializeField] TextMeshProUGUI _blueValueText;

    private int _redValue;
    private int _greenValue;
    private int _blueValue;

    private void Start()
    {
        PopulateDemand();
    }

    private void PopulateDemand()
    {
        int numberOfElements = Random.Range(1, 4);
        for (int i = 0; i < numberOfElements; i++)
        {
            SetElementsValue();
            int index = Random.Range(0, 3);
            _elements[index].SetActive(true);
        }
    }

    private void SetElementsValue()
    {
        _redValue = Random.Range(1, 4);
        _greenValue = Random.Range(1, 4);
        _blueValue = Random.Range(1, 4);

        _redValueText.text = _redValue.ToString();
        _greenValueText.text = _greenValue.ToString();
        _blueValueText.text = _blueValue.ToString();
    }

    public void OnPotionDrop(int red, int green, int blue)
    {
        _redValue -= red;
        _greenValue -= green;
        _blueValue -= blue;

        if (_redValue < 0) { _redValue = 0; }
        if (_greenValue < 0) { _greenValue = 0; }
        if (_blueValue < 0) { _blueValue = 0; }

        _redValueText.text = _redValue.ToString();
        _greenValueText.text = _greenValue.ToString();
        _blueValueText.text = _blueValue.ToString();

        if (_redValue <= 0 && _greenValue <=0 && _blueValue <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
