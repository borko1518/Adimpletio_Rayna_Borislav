using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDmgPls : MonoBehaviour
{
    public bool isDamaging;
    public float dmg = 6;
    public PlHealth plH;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player")) 
        {
            Damage();
        }

        //other.SendMessage((isDamaging) ? "DealDamage":"HealDamage", Time.deltaTime * dmg);

        //other.gameObject.GetComponent<PlHealth>().DealDamage(6);
    }

    public void Damage()
    {
        plH.currentHealth = plH.currentHealth - dmg;
        plH.healthBar.value = plH.CalcHealth();
        this.gameObject.SetActive(true);
        if (plH.currentHealth <= 0)
            Die();
    }

    public void Die()
    {
        plH.currentHealth = 0;
        Debug.Log("Wasted.");
    }
}
