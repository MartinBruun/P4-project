namespace OG.CodeGeneration
{
    public class GCodeCommandTextContainer : IGCodeCommand
    {
        public GCodeCommandTextContainer(string commandText)
        {
            CommandText = commandText;
        }

        public string CommandText { get; }

        public string CreateGCodeTextCommand()
        {
            return CommandText;
        }

        public static GCodeCommandTextContainer operator +(GCodeCommandTextContainer g1, GCodeCommandTextContainer g2)
        {
            return new GCodeCommandTextContainer(g1.CommandText + g2.CommandText);
        }
        
    }
}