using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class MuteToggle : MonoBehaviour
{
    public Toggle speakerToggle;
    void Start()
    {
        speakerToggle = GetComponent<Toggle>();
        if (AudioListener.volume == 0)
        {
            speakerToggle.isOn = false;
        }
    }

    public void ToggleAudioOnValueChange(bool inAudio)
    {
        if (inAudio)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}
