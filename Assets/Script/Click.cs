using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private int clickPower;

    public void OnClick()
    {
        clickPower = GameManager.instance.player.clickPower;
        GameManager.instance.AddScore(clickPower);
    }
}
