using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Tests.Unit.UI
{
    public class TutorialModalTest
    {
        [SetUp]
        public void SetUp()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Menu.unity");
        }
        
        [Test]
        public void ModalTogglesVisibilityOnButtonClick()
        {
            var tutorialButton = new GameObject("TutorialButton");

            var modalPanel = new GameObject("TutorialModal");
            modalPanel.SetActive(false);
            
            var tutorialModalScript = tutorialButton.AddComponent<TutorialModal>();
            tutorialModalScript.modalPanel = modalPanel;

            tutorialModalScript.ToggleTutorialModal();
            Assert.IsTrue(modalPanel.activeSelf);
            
            tutorialModalScript.ToggleTutorialModal();
            Assert.IsFalse(modalPanel.activeSelf);
        }
    }
}