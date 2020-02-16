using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemandsHandler : MonoBehaviour
{
    [SerializeField] GameObject _demandsPrefab;
    [SerializeField] List<GameObject> _elements;

    private void Start()
    {
        
    }

    private void PopulateDemand()
    {
        int numberOfElements = Random.Range(1, 3);
        for (int i = 0; i < numberOfElements; i++)
        {
            _elements[i].SetActive(true);
        }    
    }
}
