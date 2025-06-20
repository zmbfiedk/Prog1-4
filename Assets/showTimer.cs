using UnityEngine;
using TMPro;

public class showTimer : MonoBehaviour
{
    [SerializeField] private TIMER timer;
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (timer == null || textMeshPro == null)
        {
            Debug.LogWarning("Timer or TextMeshProUGUI not assigned!");
            return;
        }

        if (timer.Ttime <= 0)
        {
            textMeshPro.text = "GameOverGNG";
        }
        else
        {
            textMeshPro.text = timer.Ttime.ToString("F3");
        }
    }
}
