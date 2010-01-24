using System.Linq;
using FubuMVC.Core.Continuations;
using FubuMVC.Core.Registration.Nodes;

namespace FubuMVC.Core.Registration.Conventions
{
    public class ContinuationHandlerConvention : IConfigurationAction
    {
        public void Configure(BehaviorGraph graph)
        {
            graph.Actions().Where(x => x.OutputType().CanBeCastTo<FubuContinuation>()).Each(call =>
            {
                call.InsertDirectlyAfter(new ContinuationNode());
                graph.Observer.RecordCallStatus(call, "Adding ContinuationNode directly after action call");
            });
        }
    }
}