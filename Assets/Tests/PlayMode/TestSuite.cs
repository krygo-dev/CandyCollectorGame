using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.

            GameObject gameObject;
            gameObject = GameObject.Find("Canvas");
            Debug.Log(gameObject);
            //GameObject panel = gameObject.GetChild("")
            ShowMenu showMenu = gameObject.GetComponent<ShowMenu>();
            showMenu.Resume();
            Assert.AreEqual(1f, Time.timeScale);
            yield return null;
        }
    }
}
