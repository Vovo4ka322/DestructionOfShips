using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clip : MonoBehaviour
{
    [SerializeField] private List<Transform> _seats;
    [SerializeField] private List<Core> _clipCore;

    public bool IsFreePlace()//здесь я хочу сделать свободные и занятые места
    {
        foreach (var seat in _seats)
        {
            if (seat != null)
            {
                return true;
            }
        }

        return false;
    }

    public Transform GetPosition()
    {
        Transform place = null;

        for (int i = 0; i < _seats.Count; i++)
        {
            place = _seats[i];
        }

        return place;
    }

    public void Add(Core core)
    {
        _clipCore.Add(core);
    }
}
