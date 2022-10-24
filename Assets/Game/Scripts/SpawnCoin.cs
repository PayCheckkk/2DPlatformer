using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    [SerializeField] private Vector3 spawn1;
    [SerializeField] private Vector3 spawn2;
    [SerializeField] private Vector3 spawn3;
    [SerializeField] private Vector3 spawn4;

    public Coin Template;

    private void Start()
    {
        Instantiate(Template, spawn1, Quaternion.identity);
        Instantiate(Template, spawn2, Quaternion.identity);
        Instantiate(Template, spawn3, Quaternion.identity);
        Instantiate(Template, spawn4, Quaternion.identity);
    }
}
