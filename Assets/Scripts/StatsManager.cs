using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour {

    public Text gpt, spt;

    void Update()
    {
        gpt.text = PlayerStats.goldPerTurn.ToString() + "/Turn";
        spt.text = PlayerStats.sciencePerTurn.ToString() + "/Turn";
        Debug.Log(PlayerStats.goldPerTurn);
    }
}
