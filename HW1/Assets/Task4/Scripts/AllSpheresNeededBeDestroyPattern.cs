using System.Collections.Generic;
using System.Linq;

public class AllSpheresNeededDestroyPattern : IWinCondition
{
    private IEnumerable<Sphere> _spheres;

    public AllSpheresNeededDestroyPattern(IEnumerable<Sphere> spheres)
    {
        _spheres = spheres;
    }

    public bool CheckWinResult() => _spheres.Count() == 0;

}
