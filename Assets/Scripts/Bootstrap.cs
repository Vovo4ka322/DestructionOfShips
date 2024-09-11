using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private List<Core> _cores;
    [SerializeField] private List<Transform> _clipSeats;
    [SerializeField] private CoreSpawner[] _spawners;

    private void Awake()
    {
        foreach (var spawner in _spawners)
        {
            List<Core> cores = spawner.Spawn(_cores);

            foreach (var core in cores)
            {
                core.Init(_clipSeats);
            }
        }
    }
}
