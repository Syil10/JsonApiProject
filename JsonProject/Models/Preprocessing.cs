namespace JsonProject.Models
{
    public class Preprocessing
    {
        public bool add_missing_days { get; set; }
        public DatetimeColumns datetime_columns { get; set; }
        public Holiday holiday { get; set; }
        public bool add_promotion { get; set; }
        public CyclicTransform cyclic_transform { get; set; }
        public SplitData split_data { get; set; }
    }
}
