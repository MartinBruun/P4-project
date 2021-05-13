namespace OG.CodeGeneration
{
    public interface IGCodeStringEmitter
    {
        public string Emit();

        public void ClearResult();
        
        public GCodeCommandText ResultCommand {get;}
    }
}