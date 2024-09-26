
namespace Learning
{
    public static class InputHelper
    {
        public static int? GetIndex<T>(IEnumerable<T> objects, Func<T, string> func)
        {
            int i = 0;

            foreach (var obj in objects)
            {
                var str = func.Invoke(obj);
                Console.WriteLine($"{i}: {str}");
                i++;
            }

            var input = Console.ReadLine();
            var result = int.TryParse(input, out var index);

            if (result == false)
                return null;

            if (index < objects.Count())
                return index;

            return null;
        }
    }
}
