using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private List<Core> _cores;
    [SerializeField] private Clip _clip;
    //[SerializeField] private List<Transform> _clipSeats;
    [SerializeField] private CoreSpawner[] _spawners;
    [SerializeField] private CoreSelector _selector;

    private void OnEnable()
    {
        _selector.Selected += OnRemoved;
    }

    private void OnDisable()
    {
        _selector.Selected -= OnRemoved;
    }

    private void Awake()
    {
        foreach (var spawner in _spawners)
        {
            spawner.Spawn(_cores);

            //List<Core> cores = spawner.Spawn(_cores);

            //foreach (var core in cores)
            //{
            //    core.Init(_clipSeats);
            //}
        }
    }

    private void OnRemoved(Core core)
    {
        _cores.Remove(core);
        _clip.Add(core);
        core.GetAnyPosition(_clip);

        foreach (var spawner in _spawners)
        {
            Core newCore = spawner.SpawnOneCore(_cores);
            newCore.transform.position = core.transform.position;
            _cores.Add(newCore);
        }
        //_clipSeats.Add(core);
    }
}
