using System;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class PlayModeTest1
    {
        // A UnityTest behaves like a coroutine in PlayMode
        // and allows you to yield null to skip a frame in EditMode
        [UnityEngine.TestTools.UnityTest]
        public System.Collections.IEnumerator PlayModeTest1WithEnumeratorPasses()
        {
            SceneManager.LoadScene("Main");
            yield return new WaitForSeconds(3);
            // Use the Assert class to test conditions.
            // yield to skip a frame
            throw new Exception("test");
        }
    }
}