using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int clickPower = 1;
    public float autoClickRate = 0.1f;

    private void Start()
    {
        StartCoroutine(AutoClick());
    }

    IEnumerator AutoClick()
    {
        while (true)
        {
            GameManager.instance.AddScore(clickPower);
            yield return new WaitForSeconds(autoClickRate);
        }
    }
}
