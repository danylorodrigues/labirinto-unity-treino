using UnityEngine;

public class Reiniciar : MonoBehaviour
{
    public Transform jogador;
    public Transform pontoInicial;

    public void Resetar()
    {
        jogador.position = pontoInicial.position;
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}