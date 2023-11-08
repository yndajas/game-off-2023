using NUnit.Framework;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Tests.Unit.UI
{
    public class MenuTest
    {
        [SetUp]
        public void SetUp()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Menu.unity");
        }

        [Test]
        public void TitleRendersCorrectly()
        {
            var textElement = GameObject.Find("TitleText");
            Assert.IsNotNull(textElement, "GameObject 'TitleText' not found.");

            var textMeshPro = textElement.GetComponent<TextMeshProUGUI>();
            Assert.IsNotNull(textMeshPro, "TextMeshProGUI component not found on 'TitleText' GameObject.");
            Assert.AreEqual("Tennis Bird placeholder", textMeshPro.text);
        }

        [Test]
        public void TutorialButtonRendersCorrectly()
        {
            var textElement = GameObject.Find("TutorialButtonText");
            Assert.IsNotNull(textElement, "GameObject 'TutorialButtonText' not found.");

            var textMeshPro = textElement.GetComponent<TextMeshProUGUI>();
            Assert.IsNotNull(textMeshPro, "TextMeshProGUI component not found on 'TutorialButtonText' GameObject.");
            Assert.AreEqual("Tutorial", textMeshPro.text);
        }

        [Test]
        public void StartButtonRendersCorrectly()
        {
            var textElement = GameObject.Find("StartButtonText");
            Assert.IsNotNull(textElement, "GameObject 'StartButtonText' not found.");

            var textMeshPro = textElement.GetComponent<TextMeshProUGUI>();
            Assert.IsNotNull(textMeshPro, "TextMeshProGUI component not found on 'StartButtonText' GameObject.");
            Assert.AreEqual("Start", textMeshPro.text);
        }
    }
}
