using UnityEngine;

public class TutorialModal : MonoBehaviour
{
    public GameObject modalPanel;

    public void ToggleTutorialModal()
    {
        modalPanel.SetActive(!modalPanel.activeSelf);
    }
}