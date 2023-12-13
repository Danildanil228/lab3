class Program
{
    static void Main(string[] args)
    {
        try
        {
            RadioSession session;
            Console.Write("Позывной: ");
            session.Pozivnoi = Console.ReadLine();
            Console.Write("Частота: ");
            session.Chastota = double.Parse(Console.ReadLine());
            Console.Write("Дата сеанса (ДДММГГГГ): ");
            session.SessionDate = DateTime.ParseExact(Console.ReadLine(), "ddMMyyyy", null);
            Console.Write("Время начала сеанса (ЧЧ:ММ:СС): ");
            session.StartTime = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Время окончания сеанса (ЧЧ:ММ:СС): ");
            session.EndTime = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Количество переданных групп: ");
            session.TransmittedGroups = int.Parse(Console.ReadLine());
            double transmissionRate = (double)session.TransmittedGroups / (session.EndTime - session.StartTime).TotalMinutes;
            Console.WriteLine($"Позывной: {session.Pozivnoi}, Скорость передачи: {transmissionRate:F2} групп в минуту");
            Console.WriteLine("\nВведите дату и интервал времени для просмотра информации о выходе радистов на связь:");
            Console.Write("Дата (ДДММГГГГ): ");
            DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "ddMMyyyy", null);
            Console.Write("Начальное время (ЧЧ:ММ:СС): ");
            TimeSpan startTime = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Конечное время (ЧЧ:ММ:СС): ");
            TimeSpan endTime = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine($"\nИнформация о выходе радистов на связь на {inputDate:ddMMyyyy} с {startTime} до {endTime}:");
            if (session.SessionDate == inputDate && session.StartTime >= startTime && session.EndTime <= endTime)
            {
                Console.WriteLine($"Позывной: {session.Pozivnoi}, Дата: {session.SessionDate:ddMMyyyy}, Время начала: {session.StartTime}, Время окончания: {session.EndTime}");
            }
        }
        catch (Exception ex) 
        { Console.WriteLine(ex.Message); }
    }
}
