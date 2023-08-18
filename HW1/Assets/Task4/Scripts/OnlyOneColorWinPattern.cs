using System.Linq;

public class OnlyOneColorWinPattern : IWinCondition
{
    private SphereStats _sphereStats;
    private Sphere _winColorSphere;

    public OnlyOneColorWinPattern(SphereStats sphereStats, Sphere winColorSphere)
    {
        _sphereStats = sphereStats;
        _winColorSphere = winColorSphere;
    }
    public bool CheckWinResult()
    {
        bool IsOnlyOneColorWin = !_sphereStats.Spheres.Any(sphere => sphere.GetType() == _winColorSphere.GetType());
        
        return IsOnlyOneColorWin;
    }
}
