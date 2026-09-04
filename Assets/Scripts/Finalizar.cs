using UnityEngine;

public class Finalizar : MonoBehaviour
{
    public GameObject botaoReiniciar;

    void OnMouseDown()
    {
        Time.timeScale = 0f;
        botaoReiniciar.SetActive(true);
    }
}
