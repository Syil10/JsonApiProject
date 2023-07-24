namespace JsonProject.Models
{

    public class JsonModel
    {
        public Configs configs { get; set; }
        public Predict predict { get; set; }
        public Preprocessing preprocessing { get; set; }
        public List<BaselineFeature> baseline_features { get; set; }
        public List<AdaptiveFeature> adaptive_features { get; set; }
        public Models models { get; set; }
        public HyperparameterTuning hyperparameter_tuning { get; set; }
    }
}


