namespace JsonProject.Models
{
    public class AdaptiveFeature
    {
        public List<int> shift { get; set; }
        public string shift_column { get; set; }
        public string shift_key { get; set; }
        public bool aggregation { get; set; }
        public string agg_func { get; set; }
    }
}
