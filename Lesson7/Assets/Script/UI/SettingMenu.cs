using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;


public class SettingMenu : MonoBehaviour
{
    public static SettingMenu instance;

    private int _soundVolume;
    private bool _soundMute;

    [SerializeField] private Button _ExiteSetting;
    [SerializeField] private Toggle _MuteSound;
    [SerializeField] private Slider _Volume;

    public int SoundVolume => _soundVolume;
    public bool SoundMute => _soundMute;

    private void Awake()
    {
        _ExiteSetting.onClick.AddListener(ExiteSetting);

    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);

    //        _Volume.onValueChanged.AddListener(Volume);
    //        _MuteSound.onValueChanged.AddListener(Mute);
    //    }
    //    else
    //        Destroy(gameObject);
    }

    void ExiteSetting()
    {
        SceneManager.LoadScene(0);
    }
    void Mute(bool value)
    {
        instance._soundMute = value;
    }
    void Volume(float value)
    {
        instance._soundVolume = (int)value;
    }    
}
