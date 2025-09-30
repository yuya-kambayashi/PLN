namespace PLN
{
    public abstract class Command
    {
        public abstract string RegisteredName { get; }
        public abstract string Name { get; }

        public virtual Task Apply(CADDocument doc, CancellationToken token, params string[] args)
        {
            return Task.FromResult(default(object));
        }
    }
}
