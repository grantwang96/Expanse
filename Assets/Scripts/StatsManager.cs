using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour {

    private PlayerStats playerStats = new PlayerStats();
    public Text Gold, goldPerTurn, Science, sciencePerTurn, Production, productionPerTurn;

    void Start()
    {
        Gold.text = "GOLD: " + playerStats.Gold.ToString();
        goldPerTurn.text = "Gold/turn: " + playerStats.goldPerTurn.ToString();
        Science.text = "Science: " + playerStats.Science.ToString();
        sciencePerTurn.text = "Science/turn: " + playerStats.sciencePerTurn.ToString();
        Production.text = "Production: " + playerStats.Production.ToString();
        productionPerTurn.text = "Production/turn: " + playerStats.Production.ToString();
    }
}
