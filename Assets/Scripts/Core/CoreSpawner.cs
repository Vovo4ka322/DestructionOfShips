using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreSpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _placesForSeat;

    private int _randomCore;

    public List<Core> Spawn(List<Core> cores)
    {
        List<Core> newCores = new();

        for (int i = 0; i < _placesForSeat.Count; i++)
        {
            _randomCore = Random.Range(0, cores.Count);
            newCores.Add(Instantiate(cores[_randomCore], _placesForSeat[i].position, Quaternion.identity));
        }

        return newCores;
    }
}