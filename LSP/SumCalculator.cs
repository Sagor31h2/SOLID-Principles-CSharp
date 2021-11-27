using System.Linq;

namespace LSP
{
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Sum();
    }
}