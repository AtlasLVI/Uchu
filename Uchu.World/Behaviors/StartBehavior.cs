using System.Threading.Tasks;

namespace Uchu.World.Behaviors
{
    public class StartBehavior : BehaviorBase
    {
        public override BehaviorTemplateId Id => BehaviorTemplateId.Start;
        
        public BehaviorBase Action { get; set; }
        
        public int UseTarget { get; set; }
        
        public override async Task BuildAsync()
        {
            Action = await GetBehavior("action");

            UseTarget = await GetParameter<int>("use_target");
        }
        
        public override Task ExecuteAsync(ExecutionContext context, ExecutionBranchContext branchContext)
        {
            // TODO
            
            return Task.CompletedTask;
        }
    }
}