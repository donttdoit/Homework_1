using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private SpheresList _spheresList;
    private Level _level;
    private IWinCondition _winCondition;

    private void Awake()
    {
        _winCondition = new AllSpheresNeededBeDestroyPattern(_spheresList);
        _level = new Level(_winCondition, _spheresList);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _level.SetConditionToWin(new AllSpheresNeededBeDestroyPattern(_spheresList));
            Debug.Log("Победа только тогда, когда все сферы лопнуты");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _level.SetConditionToWin(new OnlyOneColorWinPattern(_spheresList, SphereType.RedSphere));
            Debug.Log("Победа только тогда, когда все красные сферы лопнуты");
        }

    }
}
