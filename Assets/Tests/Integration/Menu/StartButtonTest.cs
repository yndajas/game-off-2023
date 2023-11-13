using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests.Integration.Menu
{
    public class StartButtonTest
    {
        [SetUp]
        public void SetUp()
        {
            SceneManager.LoadScene("Assets/Scenes/Menu.unity");
        }
    
        [UnityTest]
        public IEnumerator MainSceneLoadsOnButtonClick()
        {
            var startButton = new GameObject("StartButton");
            var startButtonScript = startButton.AddComponent<StartButton>();

            var currentScene = SceneManager.GetActiveScene();
            Assert.AreEqual("Menu", currentScene.name);
            
            startButtonScript.StartGame();
            yield return null;

            var newScene = SceneManager.GetActiveScene();
            Assert.AreEqual("Main", newScene.name);
        }
    }
}
