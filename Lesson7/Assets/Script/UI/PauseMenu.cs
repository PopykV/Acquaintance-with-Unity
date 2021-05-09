using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Button _NewGame;
    [SerializeField] private Button _QuitGame;
    [SerializeField] private Button _Continue;

    void Start()
    {
        _NewGame.onClick.AddListener(NewGame);
        _QuitGame.onClick.AddListener(QuitGame);
        _Continue.onClick.AddListener(Continue);

        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause ()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        
    }
    
    void Continue ()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    void NewGame()
    {
        SceneManager.LoadScene(2);
    }

    void QuitGame()
    {
        Application.Quit();
    }

}
