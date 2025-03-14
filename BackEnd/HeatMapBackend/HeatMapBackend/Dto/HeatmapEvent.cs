namespace HeatMapBackend.Dto
{
    public class HeatmapEvent
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Event { get; set; } = "";
        public long Timestamp { get; set; }
    }
}

