namespace WebApplicationApi.Models
{
    public class DimensionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

    public class DimensionViewModel
    {
        public string Name { get; set; }
    }

    public class DimensionlListModel
    {
        public List<DimensionModel>? Dimensions { get; set; }
        public int TotalRecords { get; set; }
    }
}
