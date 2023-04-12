namespace WebApplicationApi.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte LevelDepartment { get; set; }
        public int ParentId { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class DepartmentViewModel
    {
        public string Name { get; set; }
        public byte LevelDepartment { get; set; }
        public int ParentId { get; set; }
        public bool IsActive { get; set; }
    }
}
