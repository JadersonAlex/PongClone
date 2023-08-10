using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAlternate : MonoBehaviour
{
    public Image jogador1Image;
    public Image jogador2Image;

    public float fadeInSpeed = 1.0f; // Velocidade de aumento do alfa
    public float fadeOutSpeed = 1.0f; // Velocidade de diminuição do alfa
    public float timeBetweenAlternations = 2.0f; // Tempo entre as alternâncias

    private float currentAlpha = 0.0f; // Alfa atual
    private float alphaChangeDirection = 1.0f; // Direção da mudança do alfa (1 para aumentar, -1 para diminuir)
    private float timeSinceLastAlternation = 0.0f; // Tempo desde a última alternância

    private void Start()
    {
        jogador1Image.color = new Color(jogador1Image.color.r, jogador1Image.color.g, jogador1Image.color.b, currentAlpha);
        jogador2Image.color = new Color(jogador2Image.color.r, jogador2Image.color.g, jogador2Image.color.b, 1.0f - currentAlpha);
    }

    private void Update()
    {
        // Atualiza o alfa gradualmente
        currentAlpha += alphaChangeDirection * Time.deltaTime * ((1.0f / timeBetweenAlternations) / 2.0f);
        currentAlpha = Mathf.Clamp01(currentAlpha);

        // Atualiza as imagens com os alfas correspondentes
        jogador1Image.color = new Color(jogador1Image.color.r, jogador1Image.color.g, jogador1Image.color.b, currentAlpha);
        jogador2Image.color = new Color(jogador2Image.color.r, jogador2Image.color.g, jogador2Image.color.b, 1.0f - currentAlpha);

        // Verifica se é hora de alternar a direção da mudança do alfa
        if (currentAlpha <= 0.0f || currentAlpha >= 1.0f)
        {
            alphaChangeDirection *= -1;
        }
    }
}
