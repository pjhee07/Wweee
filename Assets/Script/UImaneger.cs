using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImaneger : MonoBehaviour
{
    public Image hpGauge;
    
    public void DecrementHP()
    {
        hpGauge.fillAmount -= 0.2f;
    }
}
