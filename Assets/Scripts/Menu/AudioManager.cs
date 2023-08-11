using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;

    private void Start()
    {
        // Configurar o valor inicial do slider para o volume atual
        volumeSlider.value = audioSource.volume;

        // Adicionar um ouvinte de evento para quando o valor do slider mudar
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    private void ChangeVolume(float volume)
    {
        // Atualizar o volume do AudioSource com base no valor do slider
        audioSource.volume = volume;
    }
}
