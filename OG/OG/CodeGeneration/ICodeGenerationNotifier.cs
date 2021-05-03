namespace OG.CodeGeneration
{
    public interface ICodeGenerationNotifier
    {
        public event CodeGenerationNotification CodeGenerationNotification;
    }
    public delegate void CodeGenerationNotification(string codeString);
}