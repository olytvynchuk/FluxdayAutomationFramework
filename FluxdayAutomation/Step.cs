
namespace FluxdayAutomation
{
    public class Step
    {
        private string testName;
        private string description;

        public string TestName
        {
            get
            {
                return this.testName;
            }
            set
            {
                if (this.testName == null)
                {
                    this.testName = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set { this.description = value; }
        }

        public string GetTestAndStep()
        {
            string testAndStep = this.testName;
            if (description != null)
            {
                testAndStep += " " + this.ToString();
            }

            return testAndStep;
        }

        public override string ToString()
        {
            string result = "";
            if (description != null)
            {
                result = $"[STEP {this.description}]";
            }

            return result;
        }
    }
}
