bool IsTrianglePossible(double a, double b, double c) {
    return (a < b + c && b < a + c && c < a + b);
}

double[] TriangleParams(double a, double b, double c) {
    double[] result = new double[8];
    result[0] = a + b + c;
    double halfPerim = result[0] / 2;
    result[1] = Math.Sqrt(halfPerim * (halfPerim - a) * (halfPerim - b) * (halfPerim - c));
    result[2] = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
    result[3] = Math.Acos((c * c + a * a - b * b) / (2 * a * c));
    result[4] = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
    result[5] = (a * a == b * b + c * c || b * b == c * c + a * a || c * c == a * a + b * b) ? 1 : 0;
    result[6] = (a == b || a == c || b == c) ? 1 : 0;
    result[7] = (a == b && b == c) ? 1 : 0;
    return result;
}
try {
    Console.Write("Введите первую сторону треугольника: ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите вторую сторону треугольника: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите третью сторону треугольника: ");
    double c = Convert.ToDouble(Console.ReadLine());
    Console.Write($"{a}, {b}, {c} - ");
    if (!IsTrianglePossible(a, b, c)) {
        Console.WriteLine("не треугольник");
    } else {
        Console.WriteLine("треугольник");
        double[] triangParam = TriangleParams(a, b, c);
        Console.WriteLine($"Периметр треугольника - {triangParam[0]}");
        Console.WriteLine($"Площадь треугольника - {triangParam[1]}");
        Console.WriteLine($"Угол напротив первой стороны - {triangParam[2]} радиан");
        Console.WriteLine($"Угол напротив второй стороны - {triangParam[3]} радиан");
        Console.WriteLine($"Угол напротив третьей стороны - {triangParam[4]} радиан");
        Console.WriteLine((triangParam[5] == 0) ? "Не прямоугольный" : "Прямоугольный");
        Console.WriteLine((triangParam[6] == 0) ? "Не равнобедренный" : "Равнобедренный");
        Console.WriteLine((triangParam[7] == 0) ? "Не равносторонний" : "Равносторонний");
    }
} catch {
    Console.WriteLine("Вы ввели что-то не то.");
}