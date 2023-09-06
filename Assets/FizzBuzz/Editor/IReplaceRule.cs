namespace Hum.FizzBuzz.Editor
{
    public interface IReplaceRule
    {
        public string Apply(string carry, int number);
        public bool Match(string carry, int number);
    }
}
