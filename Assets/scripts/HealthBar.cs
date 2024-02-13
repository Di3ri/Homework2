using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
   
{
    public Image HealthBar;

    public void UpdateHealth(float fraction)
    {
        //depicts healthbar amount
        HealthBar.fillAmount = fraction;

    }



}
