using System.Collections.Generic;

namespace OG.CodeGeneration
{
    public interface IGCodeStringEmitterNotifier : ICodeGenerationNotifier, IGCodeStringEmitter
    {
        
        public ICollection<IGCodeCommand> ToCommands{get; set; }
    }
}