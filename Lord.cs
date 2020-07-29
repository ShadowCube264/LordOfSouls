using Modding;
using UnityEngine;
using ModCommon.Util;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;

namespace LordOfSouls
{
    internal class Lord : MonoBehaviour
    {
        GameObject lord = Instantiate(GameObject.Find("Mage Lord"));
        PlayMakerFSM fsm = go.LocateMyFSM("Dream Mage Lord-Mage Lord");
        var testAction = fsm.GetAction<SetVelocity2d>("Quake Down", 3).y = 0.5f;
    }
}