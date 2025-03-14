using HeatMapBackend.Dto;

namespace HeatMapBackend.Repository
{
    public interface IHandleDataRepository
    {
        public List<HeatmapEvent> LoadData();
        public bool SaveData(List<HeatmapEvent> data);
    }
}
