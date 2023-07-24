namespace JsonProject.Models
{
    public class Models
    {
        public List<string> model_names { get; set; }

        public class TreesParams
        {
            public int max_depth { get; set; }
            public int min_samples_leaf { get; set; }
            public int min_samples_split { get; set; }
        }

        public class InterpretParams
        {
            public bool interpret { get; set; }
            public int n_iter { get; set; }
            public bool add_new_features_with_residuals { get; set; }
            public TreesParams trees_params { get; set; }
        }

        public class Constraints
        {
            public int PROMORATE_sum { get; set; }
            public int holiday { get; set; }
        }

        public class MultitaskLearning
        {
            public bool use { get; set; }
            public List<string> target_cols { get; set; }
            public int lambda_penalty { get; set; }
            public int coef_penalty { get; set; }
        }

        public class HierarchicalLearning
        {
            public bool use { get; set; }
        }

        public class CvxpyParams
        {
            public bool add_constraints { get; set; }
            public Constraints constraints { get; set; }
            public MultitaskLearning multitask_learning { get; set; }
            public HierarchicalLearning hierarchical_learning { get; set; }
        }

        public InterpretParams interpretable { get; set; }
        public CvxpyParams cvxpy { get; set; }
    }
}
