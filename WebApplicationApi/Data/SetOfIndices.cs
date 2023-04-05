namespace WebApplicationApi.Data
{
    public class SetOfIndices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description {get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsRated { get; set; }
        public int? IdDepartmentRate { get; set; }
        public Department? DepartmentRate { get; set; }
        public IList<DimensionsIndices>? DimensionsIndices { get; set; }
    }
}
