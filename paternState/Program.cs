namespace paternState;
class Program
{
    static void Main(string[] args)
    {
        Study study = new Study(new StudyIssued());
        study.Issued();
        study.Done();
        study.Check();
        study.MarkIsWorth();
        Console.WriteLine("Оценка не поставлена");
        study.MarkIsNotWorth();
        study.Check();
        study.Done();

        Console.Read();
    }
    
}