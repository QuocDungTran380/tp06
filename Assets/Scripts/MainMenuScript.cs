using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Button leaveButton;
    public Button startButton;

    void Start()
    {
        leaveButton.onClick.AddListener(LeaveGame);
        startButton.onClick.AddListener(StartLevel);
    }

    void LeaveGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    void StartLevel()
    {
        SceneManager.LoadScene("Niveau1");
    }
}