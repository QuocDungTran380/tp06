using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelScript : MonoBehaviour
{
    public Button leaveButton;
    public Button nextLevelButton;

    void Start()
    {
        leaveButton.onClick.AddListener(LeaveGame);
        nextLevelButton.onClick.AddListener(GoToNextLevel);
    }

    void LeaveGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    void GoToNextLevel()
    {
        SceneManager.LoadScene("Niveau2");
    }
}