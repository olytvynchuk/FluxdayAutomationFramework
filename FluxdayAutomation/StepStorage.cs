using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace FluxdayAutomation
{
   public static class StepStorage
    {
        private static readonly ThreadLocal<Step> threadLocalStep = new ThreadLocal<Step>();

        public static Step GetStep()
        {
            return threadLocalStep.Value;
        }

        public static void SetStep(Step step)
        {
            threadLocalStep.Value = step;
        }
    }
}
