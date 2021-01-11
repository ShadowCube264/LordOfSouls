using System.Collections;
using UnityEngine;
using ModCommon.Util;
using HutongGames.PlayMaker.Actions;
using System.Runtime;

namespace LordOfSouls
{
    internal class Lord : MonoBehaviour
    {
        private IEnumerator Start()
        {
            PlayMakerFSM fsm = gameObject.LocateMyFSM("Dream Mage Lord-Mage Lord");
            fsm.GetAction<SetVelocity2d>("Quake Down", 3).y = 69f;
            yield return null;
        }
    }
}