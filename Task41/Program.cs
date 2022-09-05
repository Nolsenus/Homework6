int CountPositiveEntered() {
    Console.Write("Вводите целые числа, чтобы закончить нажмите Enter, ничего не вводя: ");
    string entry = Console.ReadLine();
    int count = 0;
    try{
        while (!entry.Equals(String.Empty)) {
            if (Convert.ToInt32(entry) > 0) {
                count++;
            }
            Console.Write("Введите следующее число: ");
            entry = Console.ReadLine();
        }
    } catch {
        return -1;
    }
    return count;
}

int result = CountPositiveEntered();
if (result == -1) {
    Console.WriteLine("Было введено что-то кроме целых чисел и пустых строк.");
} else {
    Console.WriteLine(result);
}