using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public int cost;
    public int clickPower;
    public float autoClickRate;

    public void Apply()
    {
        Player player = GameManager.instance.click.GetComponent<Player>();
        GameManager.instance.score -= cost;
        player.clickPower += clickPower;
        player.autoClickRate -= autoClickRate;
    }
}
