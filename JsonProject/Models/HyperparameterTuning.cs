namespace JsonProject.Models
{
    public class HyperparameterTuning
    {
        public bool use { get; set; }
        public int time_limit { get; set; }
        public int n_iter { get; set; }

        public class RandomForestTrialParams
        {
            public List<int> n_estimators { get; set; }
            public List<int> max_depth { get; set; }
            public List<string> max_features { get; set; }
            public List<int> random_state { get; set; }
        }

        public class XgboostTrialParams
        {
            public List<int> n_estimators { get; set; }
            public List<int> max_depth { get; set; }
            public List<int> min_child_weight { get; set; }
            public List<double> subsample { get; set; }
            public List<double> gamma { get; set; }
            public List<double> colsample_bytree { get; set; }
            public List<double> learning_rate { get; set; }
            public List<int> random_state { get; set; }
        }

        public RandomForestTrialParams random_forest_trial_params { get; set; }
        public XgboostTrialParams xgboost_trial_params { get; set; }
    }

}
