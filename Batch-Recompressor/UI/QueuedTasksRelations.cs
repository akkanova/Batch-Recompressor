using Batch_Recompressor.All_Purpose;
using Batch_Recompressor.Core;

namespace Batch_Recompressor.UI
{
    internal class QueuedTasksRelations
    {
        public ConcurrentList<RecompressTask> Tasks { get; init; }
        public QueuedTasksRelations() 
        {
            Tasks = new();
        }
    }
}
