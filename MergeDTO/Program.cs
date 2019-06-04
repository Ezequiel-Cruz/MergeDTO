using System;

namespace MergeDTO
{
    class Program
    {
        static void Main(string[] args)
        {
            var source1 = new
            {
                foo = "foo",
                bar = "bar",
                teste = "0"
            };

            var source2 = new
            {
                baz = "baz",
                bar = "Onde passa",
                teste = "5578",
                ruiva = "alto"
            };

            dynamic merged = Merge(source1, source2);

            Console.WriteLine("{0} {1} {2} {3} {4}", merged.foo, merged.bar, merged.baz, merged.teste, merged.ruiva);
            Console.Read();
        }

        static MergedType<T1, T2> Merge<T1, T2>(T1 t1, T2 t2)
        {
            return new MergedType<T1, T2>(t1, t2);
        }
    }
}
