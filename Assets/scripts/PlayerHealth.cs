using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;

    public Health healthbar;

    private int curHealth;

    // Start is called before the first frame update
    void Start()
    {
        //makes sure health is full
        curHealth = maxHealth;

    }

    public void update()
    {
        //if damaged health goes red
        Color Health = (curHealth == maxHealth) ?
            Color.green : Color.red;
    }

    // 
    public void takeDamage(int damage)
    {
        //incase damaged, translate it to other code
        curHealth -= damage;
        healthbar.UpdateHealth((float)curHealth / (float)maxHealth);
    }
    
}
