using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemandsHandler : MonoBehaviour
{
    [SerializeField] GameObject _demandsPrefab;
    [SerializeField] int _maxDemands;

    private List<Demand> _demands;
    

    private void Start()
    {
        _demands = new List<Demand>();

        AddDemandOnList();
    }

    public void AddDemandOnList()
    {
        if (_demands.Count == 7 && _demands[6] != null)
        {
            Debug.LogError("GAME OVER!!");
        }
        else if (_demands.Count < _maxDemands)
        {
            Demand demand;
            demand = Instantiate(_demandsPrefab, this.gameObject.transform).GetComponent<Demand>();
            _demands.Add(demand);
        }
    }

    public void GetElementDestroyed(Demand demand)
    {
        _demands[_demands.IndexOf(demand)] = null;
    }
}
