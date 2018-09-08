using NetTopologySuite.Geometries;

namespace EFCoreSpatialBugRepro
{
    public class Fly
    {
        public int Id { get; set; }
        public bool IsSmashed { get; set; }
        public Point Location { get; set; }
    }
}
