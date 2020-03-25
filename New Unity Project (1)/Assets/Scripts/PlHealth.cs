using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlHealth : MonoBehaviour
{
    public float currentHealth { get; set; }
    public float maxHealth { get; set; }

    public Slider healthBar;


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 20f;
        currentHealth = maxHealth;

        healthBar.value = CalcHealth();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            DealDamage(6);
        if (Input.GetKeyDown(KeyCode.Z))
            HealDamage(3);
    }

     public void DealDamage(float dmgVal)
    {
        currentHealth -= dmgVal;

        healthBar.value = CalcHealth();
        if (currentHealth <= 0)
            Die();
    }

    void HealDamage(float dmgVal)
    {
        currentHealth += dmgVal;

        healthBar.value = CalcHealth();
        if (currentHealth <= 0)
            Die();
    }

    public void TakeDmg(float dmgAmount)
    {
        currentHealth -= dmgAmount;
    }

    public float CalcHealth()
    {
        return currentHealth / maxHealth;
    }

      void Die()
    {
        currentHealth = 0;
        Debug.Log("Wasted.");
    }
}
