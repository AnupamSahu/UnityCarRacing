using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhaustController : MonoBehaviour
{
    private ParticleSystem[] _exhausts;
    private carController _cc;

    private void Start()
    {
        _exhausts = new ParticleSystem[transform.childCount - 2];
        for (int i = 0; i < _exhausts.Length; i++)
        {
            _exhausts[i] = transform.GetChild(i).GetComponent<ParticleSystem>();
        }

        _cc = transform.parent.GetComponent<carController>();
    }

    private void Update()
    {
        if (_cc.isBoosting)
            PlayExhaustPS();
        else
            StopExhaustPS();
    }

    private void PlayExhaustPS()
    {
        foreach (ParticleSystem ps in _exhausts)
        {
            ps.Play();
        }
    }

    private void StopExhaustPS()
    {
        foreach (ParticleSystem ps in _exhausts)
        {
            ps.Stop();
        }
    }
}
