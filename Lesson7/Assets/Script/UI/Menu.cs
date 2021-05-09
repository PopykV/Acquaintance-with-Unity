
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button _NewGame;
    [SerializeField] private Button _QuitGame;
    [SerializeField] private Button _Setting;
    [SerializeField] private Button _Continue;

    private void Awake()
    {
        _NewGame.onClick.AddListener(NewGame);
        _QuitGame.onClick.AddListener(QuitGame);
        _Setting.onClick.AddListener(Setting);
    }
    void NewGame()
    {
        SceneManager.LoadScene(2);
    }

    void QuitGame()
    {
        Application.Quit();
    }
    void Setting()
    {
        SceneManager.LoadScene(1);
    }    

}
