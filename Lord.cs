using Modding;
using UnityEngine;
using ModCommon.Util;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;

namespace LordOfSouls
{
    internal class Lord : MonoBehaviour
    {
        static GameObject lord = Instantiate(GameObject.Find("Mage Lord"));
        static PlayMakerFSM fsm = lord.LocateMyFSM("Dream Mage Lord-Mage Lord");
        static FsmFloat testAction = fsm.GetAction<SetVelocity2d>("Quake Down", 3).y = 0.5f;
    }
}