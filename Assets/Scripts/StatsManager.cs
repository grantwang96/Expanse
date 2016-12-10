using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour {

    public EconomicStats playerStats = new EconomicStats();
    public Text stats;

	void Start () {
        stats.text = playerStats.Gold.ToString();
	}
}
