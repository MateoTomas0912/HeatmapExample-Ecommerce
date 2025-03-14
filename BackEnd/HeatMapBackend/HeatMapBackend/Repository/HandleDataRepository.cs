using HeatMapBackend.Dto;
using System.Text.Json;

namespace HeatMapBackend.Repository
{
    public class HandleDataRepository : IHandleDataRepository
    {
        private static readonly string FilePath = "heatmap_data.json";

        public List<HeatmapEvent> LoadData()
        {
            try
            {
                if (!System.IO.File.Exists(FilePath))
                    return new List<HeatmapEvent>();

                string json = System.IO.File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<HeatmapEvent>>(json) ?? new List<HeatmapEvent>();
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error si es necesario
                return null;
            }
        }

        public bool SaveData(List<HeatmapEvent> data)
        {
            try
            {
                string json = JsonSerializer.Serialize(data);
                System.IO.File.WriteAllText(FilePath, json);
                return true;
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error si es necesario
                return false;
            }
        }

    }
}
