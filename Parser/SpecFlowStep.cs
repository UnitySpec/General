using Gherkin.Ast;

namespace UnityFlow.SpecFlow.Parser
{
    public class SpecFlowStep : Step
    {
        public ScenarioBlock ScenarioBlock { get; private set; }
        public StepKeyword StepKeyword { get; private set; }

        public SpecFlowStep(Location location, string keyword, string text, StepArgument argument, StepKeyword stepKeyword, ScenarioBlock scenarioBlock) : base(location, keyword, text, argument)
        {
            StepKeyword = stepKeyword;
            ScenarioBlock = scenarioBlock;
        }
    }
}
