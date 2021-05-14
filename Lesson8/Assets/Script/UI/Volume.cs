using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    private SettingMenu _SettingMenu;
    public AudioMixerGroup _Mixer;

    private bool _SoundMute;
    private float _SoundVolume;

    private void Awake()
    {
        _SoundVolume = _SettingMenu.SoundVolume;
        _SoundMute = _SettingMenu.SoundMute;

        if (_SoundMute)
            _Mixer.audioMixer.SetFloat("MasterVolume", -80);
        else
            _Mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, _SoundVolume));

    }

}
