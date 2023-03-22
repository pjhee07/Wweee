using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImaneger : MonoBehaviour
{
    public Image hpGauge;

    private void Update()
    {
        if (hpGauge.fillAmount <= 0)
            SceneManager.LoadScene("Gameover");
    }

    public void DecrementHP()
    {
        hpGauge.fillAmount -= 0.2f;
    }
}
