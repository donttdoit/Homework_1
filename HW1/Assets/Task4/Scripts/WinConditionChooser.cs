using UnityEngine;

public class WinConditionChooser : MonoBehaviour
{
    [SerializeField] private SphereStats _sphereStats;
    private IWinCondition _winCondition;

    private void Awake()
    {
        SetConditionToWin(new AllSpheresNeededBeDestroyPattern(_sphereStats));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SetConditionToWin(new AllSpheresNeededBeDestroyPattern(_sphereStats));
            Debug.Log("Победа только тогда, когда все сферы лопнуты");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            SetConditionToWin(new OnlyOneColorWinPattern(_sphereStats, new RedSphere())); // Здесь warning на то что MonoBehaviour создаем
            Debug.Log("Победа только тогда, когда все красные сферы лопнуты");
        }

        // Победу в апдейте наверное плохо делать, как иначе?
        if (GetWin())
        {
            Debug.Log("Победа!");
        }

    }

    public void SetConditionToWin(IWinCondition winCondition) => _winCondition = winCondition;

    public bool GetWin() => _winCondition.CheckWinResult();

}
