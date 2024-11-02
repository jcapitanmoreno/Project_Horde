using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinAcquired;

    [SerializeField] TMPro.TextMeshProUGUI CoinsCountText;

    public void Add(int count)
    {
        coinAcquired += count;
        CoinsCountText.text = "MONEDAS: " + coinAcquired.ToString();
    }
}
