using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
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
        Debug.Log(_demands.Count);
        if (_demands.Count >= 7)
        {
            Debug.LogError("GAME OVER!!");
            SceneManager.LoadScene("GameOver");
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
        _demands.Remove(demand);
    }
}
