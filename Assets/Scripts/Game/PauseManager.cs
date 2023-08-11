using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pausedPanel;

    private bool isPaused = false;

    void Start()
    {
        // Certifica-se de que o painel de pausa está desativado no início
        if (pausedPanel != null)
        {
            pausedPanel.SetActive(false);
        }
    }

    void Update()
    {
        // Verifica se o jogador pressionou o botão ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Alterna o estado de pausa
            isPaused = !isPaused;

            // Pausa ou despausa o jogo
            if (isPaused)
            {
                Time.timeScale = 0; // Pausa o tempo
                // Ativa o painel de pausa
                if (pausedPanel != null)
                {
                    pausedPanel.SetActive(true);
                }
            }
            else
            {
                Time.timeScale = 1; // Volta a correr o tempo normalmente
                // Desativa o painel de pausa
                if (pausedPanel != null)
                {
                    pausedPanel.SetActive(false);
                }
            }
        }
    }
}
