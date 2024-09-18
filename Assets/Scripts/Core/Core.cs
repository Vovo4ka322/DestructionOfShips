using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour, ISelectable
{
    //private List<Transform> _clipSeats;

    //public void Init(List<Transform> clipSeats)
    //{
    //    _clipSeats = clipSeats;
    //}

    public void GetAnyPosition(Clip clip)
    {
        transform.position = clip.GetPosition().position;
    }
}
