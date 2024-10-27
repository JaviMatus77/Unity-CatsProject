using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    //ESTE SCRIPT TIENE UN DICCIONARIO DE AUDIOS PARA LANZAR A TRAVES DE UNA INSTANCIA
    //LOS AUDIOS DEBEN ESTAR EN Resources/Audio/Effects

    public static AudioManager Instance;

    public AudioSource audioSource;
    public Dictionary<string, AudioClip> audioClips;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadAudioClips();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void LoadAudioClips()
    {
        audioClips = new Dictionary<string, AudioClip>();
        // Cargar clips desde Resources
        AudioClip[] clips = Resources.LoadAll<AudioClip>("Audio/Effects");
        foreach (var clip in clips)
        {
            audioClips[clip.name] = clip;
        }
    }

    public void PlaySound(string clipName)
    {
        if (audioClips.TryGetValue(clipName, out var clip))
        {
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.LogWarning($"Clip {clipName} no encontrado.");
        }
    }
}
