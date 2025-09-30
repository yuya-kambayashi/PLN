namespace PLN.Commands
{
    public class SelectionClear : Command
    {
        public override string RegisteredName => "Selection.Clear";
        public override string Name => "Clear Selection";

        public override Task Apply(CADDocument doc, CancellationToken token, params string[] args)
        {
            doc.Editor.CurrentSelection.Clear();
            return Task.FromResult(default(object));
        }
    }
}
