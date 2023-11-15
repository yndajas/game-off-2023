using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests.Integration.Main
{
    public class CountdownTest
    {
        [SetUp]
        public void SetUp()
        {
            SceneManager.LoadScene("Assets/Scenes/Main.unity");
        }

        [UnityTest]
        public IEnumerator TimerCountsDownOnSceneLoad()
        {
            var countdownText = new GameObject("CountdownText");
            var textMeshPro = countdownText.AddComponent<TextMeshProUGUI>();
            textMeshPro.text = "3";
            var countdownScript = countdownText.AddComponent<CountdownTimer>();
            countdownScript.countdownText = textMeshPro;
            
            yield return null;

            Assert.AreEqual("3", textMeshPro.text);
            Assert.IsTrue(textMeshPro.IsActive());

            yield return new WaitForSeconds(1f);
            Assert.AreEqual("2", textMeshPro.text);
            
            yield return new WaitForSeconds(1f);
            Assert.AreEqual("1", textMeshPro.text);
            
            yield return new WaitForSeconds(1f);
            Assert.IsFalse(textMeshPro.IsActive());
        }
        
    }
}