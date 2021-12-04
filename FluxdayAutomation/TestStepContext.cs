using System;


namespace FluxdayAutomation
{
    public abstract class TestStepContext<T> where T : class, new()
    {     

        private static Lazy<T> _instance = new Lazy<T>(() => new T());
        public static T Instance 
        {
            get => _instance.Value;
            set => _instance = null;
        }        
        public P DoAction<P>(Action action) where P : class, new()
        {
            action();
            return TestStepContext<P>.Instance;
        }

        protected void SetStepDescription(string description)
        {
            Step step = StepStorage.GetStep();
            step.Description = description;
            StepStorage.SetStep(step);
        }

        public P Step<P>(string description) where P : class, new()
        {
            SetStepDescription(description);
            return TestStepContext<P>.Instance;
        }

    }
}
