public class AllSpheresNeededBeDestroyPattern : IWinCondition
{
    private SphereStats _sphereStats;

    public AllSpheresNeededBeDestroyPattern(SphereStats sphereStats)
    {
        _sphereStats = sphereStats;
    }

    public bool CheckWinResult() => _sphereStats.GetCountOfSpheres() == 0;

}
