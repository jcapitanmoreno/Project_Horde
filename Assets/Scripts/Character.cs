using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHP = 1000;
    public int currentHP = 1000;
    [SerializeField] StatusBar hpBar;

    private void Start()
    {
        hpBar.SetState(currentHP, maxHP);
    }


    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            Debug.Log("personaje muerto game over");
        }
        hpBar.SetState(currentHP, maxHP);
    }

    public void Heal(int amount)
    {
        if (currentHP <= 0) { return; }

        currentHP += amount;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }
        hpBar.SetState(currentHP, maxHP);
    }

}