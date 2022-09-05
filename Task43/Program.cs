double[] FindCrossPoint(double k1, double b1, double k2, double b2) {
    double[] result = new double[2];
    result[0] = (b1 - b2) / (k2 - k1);
    result[1] = k1 * result[0] + b1;
    return result;
}

try {
    Console.Write("Введите к1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите к2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    if (k1 == k2) {
        if (b1 == b2) {
            Console.WriteLine("Вы задали одну и ту же прямую.");
        } else {
            Console.WriteLine("Вы задали параллельные прямые, они никогда не пересекутся.");
        }
    } else {
        double[] result = FindCrossPoint(k1, b1, k2, b2);
        Console.WriteLine($"y = {k1}x + {b1}, y = {k2}x + {b2} -> ({result[0]}; {result[1]})");
    }
} catch {
    Console.WriteLine("Вы ввели что-то не то.");
}