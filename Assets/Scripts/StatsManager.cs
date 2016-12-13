using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour {

    private PlayerStats playerStats = new PlayerStats();
    public Text _stats;
    public Text[] stats;

	void Start () {
        stats = new Text[10];

        for (int i = 0; i < stats.Length; i++)
        {
            stats[i] = _stats;
        }

        stats[0].text = "Gold: " + playerStats.Gold.ToString();
        stats[1].text = playerStats.goldPerTurn.ToString();
        stats[2].text = playerStats.Science.ToString();
        stats[3].text = playerStats.sciencePerTurn.ToString();
        stats[4].text = playerStats.tradeRouteCapacity.ToString();
        stats[5].text = playerStats.tradeRoutes.ToString();
        stats[6].text = playerStats.NationalPride.ToString();
        stats[7].text = playerStats.GlobalRespect.ToString();
        stats[8].text = playerStats.Intel.ToString();
        stats[9].text = playerStats.intelPerTurn.ToString();
    }
}
