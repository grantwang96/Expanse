using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerStats : MonoBehaviour {

    // Gold
    static public int Gold = 0, goldPerTurn = 2;

    // Science
    static public int Science = 0, sciencePerTurn = 1;

    // Intel
    static public int Intel = 0, intelPerTurn = 0;

    // Trade
    static public int tradeRouteCapacity = 1, tradeRoutes = 0;

    //

    // Misc
    static public int NationalPride = 1, GlobalRespect = 0;
    static public int Production = 0, productionPerTurn = 5; 
}
