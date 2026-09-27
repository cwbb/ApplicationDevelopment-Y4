using System.ComponentModel;
using System.Net.Cache;

struct Students
{
    string FirstName;
    string Surname;
    int DayDOB;
    int MonthDOB;
    int YearDOB;
    string StudentNumber;
    int Result;

    public Students(string fn, string ln, int D, int M, int Y, string Sn, int r)
    {
        FirstName = fn;
        Surname = ln;
        DayDOB = D;
        MonthDOB = M;
        YearDOB = Y;
        StudentNumber = Sn;
        Result = r;
    }

    public string getFirstName() { return FirstName; }
    public string setFirstName(string fn) {
        FirstName = fn;
        return FirstName;
    }
    public string getSurname() { return Surname; }
    public string setSurname(string ln) {
        Surname = ln;
        return Surname; }
    public int getDayDOB() { return DayDOB; }
    public int setDayDOB(int D) {
        DayDOB = D;
        return DayDOB;
    }
    public int getMonthDOB() { return MonthDOB; }
    public int setMonthDOB(int M) {
        MonthDOB = M;
        return MonthDOB;
    }
    public int getYearDOB() { return YearDOB; }
    public int setYearDOB(int Y) {
        YearDOB = Y;
        return YearDOB;
    }
    public string getStudentNumber() { return StudentNumber; }
    public string setStudentNumber(string Sn)
    {
        StudentNumber = Sn;
        return StudentNumber;
    }
    public int getResult() { return Result; }
    public int setResult(int r)
    {
            Result = r;
        return Result;
        }
    }



class mainClass
{

    public static int Age(int Day, int Month, int Year)
    {
        int CurrentAge = 0;
        string TodayNow = DateTime.Now.ToString("dd");
        int dayToday = Convert.ToInt32(TodayNow);

        string MonthNow = DateTime.Now.ToString("MM");
        int ThisMonth = Convert.ToInt32(MonthNow);

        string YearNow = DateTime.Now.ToString("yyyy");
        int ThisYear = Convert.ToInt32(YearNow);


        CurrentAge = ThisYear - Year;

        if (ThisMonth < Month)
        {
            CurrentAge--;
        }
        else if (ThisMonth == Month && dayToday < Day)
        {
            CurrentAge--;
        }
        return CurrentAge;

    }

    public static void Main(string[] args)
    {
        int highestResult = 0;
        int StudentHigh = 0;
        int lowestResult = 100;
        int StudentLow = 0;
        string PassFail;
        int AVG = 0;
        string? input;
        int NumberOfStudents;


        Console.WriteLine("Hello admin, how many students are to be logged?\n");

        input = Console.ReadLine();
        NumberOfStudents = Convert.ToInt32(input);

        Students[] details = new Students[NumberOfStudents];
        for (int i = 0; i < NumberOfStudents; ++i)
        {

            Console.WriteLine("\n First Name: ");
            string? fn = Console.ReadLine();
            string? fn1 = fn;
            details[i].setFirstName(fn1);

            Console.WriteLine("\n Second Name: ");
            string? Ln = Console.ReadLine();
            details[i].setSurname(Ln);

            Console.WriteLine("\n DOB Day: ");
            input = Console.ReadLine();
            int d = Convert.ToInt32(input);
            details[i].setDayDOB(d);

            Console.WriteLine("\n DOB Month: ");
            input = Console.ReadLine();
            int M = Convert.ToInt32(input);
            details[i].setMonthDOB(M);

            Console.WriteLine("\n DOB Year: ");
            input = Console.ReadLine();
            int Y = Convert.ToInt32(input);
            details[i].setYearDOB(Y);

            Console.WriteLine("\n Student Number: ");
            string? Sn = Console.ReadLine();
            details[i].setStudentNumber(Sn);

            Console.WriteLine("\n Result: ");
            input = Console.ReadLine();
            int r = Convert.ToInt32(input);
            details[i].setResult(r);
        }
            for (int i = 0; i < NumberOfStudents; i++)
            {

            int StudentAge =Age(details[i].getDayDOB(), details[i].getMonthDOB(), details[i].getYearDOB());

                if (details[i].getResult() >= 40)
                {
                    PassFail = "Pass";
                }
                else
                {
                    PassFail = "Fail";
                }

                if (highestResult < details[i].getResult())
                {
                    highestResult = details[i].getResult();
                    StudentHigh = i;
                }

                if (lowestResult >= details[i].getResult())
                {
                    lowestResult = details[i].getResult();
                    StudentLow = i;
                }

                AVG = AVG + details[i].getResult();

                if (details[i].getResult() >= 40)
                {
                    PassFail = "Pass";
                }
                else
                {
                    PassFail = "Fail";
                }

                Console.WriteLine($"\n Student Profile:\n Name: {details[i].getFirstName()} {details[i].getSurname()}\n Age: {StudentAge}\n Student Number: {details[i].getStudentNumber()}\n DOB: {details[i].getDayDOB()}/{details[i].getMonthDOB()}/{details[i].getYearDOB()}\n Results: {PassFail}");
            }

            float classAVG = AVG / NumberOfStudents;

            Console.WriteLine($"\n Average Result: {classAVG}\n");
            Console.WriteLine($" Highest result: {details[StudentHigh].getResult()} Student Name: {details[StudentHigh].getFirstName()} {details[StudentHigh].getSurname()}\n");
            Console.WriteLine($" Lowest result: {details[StudentLow].getResult()} Student Name: {details[StudentLow].getFirstName()} {details[StudentLow].getSurname()}\n");

            return;
        }
    }