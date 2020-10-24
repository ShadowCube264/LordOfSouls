using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using USceneManager = UnityEngine.SceneManagement.SceneManager;

//Modified from https://github.com/fifty-six/HollowKnight.Pale-Prince/blob/master/Pale%20Prince/PrinceFinder.cs

namespace LordOfSouls
{
    internal class LordFinder : MonoBehaviour
    {
        private void Start()
        {
            USceneManager.activeSceneChanged += SceneChanged;
        }

        private void SceneChanged(Scene arg0, Scene arg1) => StartCoroutine(SceneChangeRoutine(arg0.name, arg1.name));

        private IEnumerator SceneChangeRoutine(string prev, string next)
        {
            if (next != "GG_Soul_Tyrant") yield break;
            if (prev != "GG_Workshop") yield break;

            StartCoroutine(AddComponent());
        }

        private static IEnumerator AddComponent()
        {
            yield return null;

            GameObject.Find("Mage Lord").AddComponent<Lord>();
        }

        private void OnDestroy()
        {
            USceneManager.activeSceneChanged -= SceneChanged;
        }

    }
}