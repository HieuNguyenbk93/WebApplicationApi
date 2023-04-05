namespace WebApplicationApi.Data
{
    public class DimensionsIndices
    {
        public int IdDimenssion { get; set; }
        public Dimension? Dimension { get; set; }
        public int IdSetOfIndices { get; set; }
        public SetOfIndices? SetOfIndices { get; set; }
        public int NumOfOrder { get; set; }
        public string ViewOfOrder { get; set; }
    }
}
