using System;

namespace oop_3
{

    #region Part 01 (Q 01)
    //public enum SecurityLevel
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA,
    //    SecurityOfficer
    //}
    //
    //public class Employee
    //{
    //    public int ID { get; private set; }
    //    public string Name { get; private set; }
    //    private char gender;
    //    public char Gender
    //    {
    //        get => gender;
    //        set
    //        {
    //            if (value == 'M' || value == 'F')
    //            {
    //                gender = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Gender Must Be 'M' or 'F' ");
    //            }
    //        }
    //    }
    //    public SecurityLevel Security { get; private set; }
    //    public decimal Salary
    //    {
    //        get => Salary;
    //        private set
    //        {
    //            if (value < 0)
    //            {
    //                throw new ArgumentException("Salary Cannot Be Negative");
    //            }
    //            else
    //            {
    //                Salary = value;
    //            }
    //        }
    //    }
    //    public DateTime HireDate { get; private set; }
    //
    //    public Employee(int id, string name, char gendr, SecurityLevel security, decimal salary, DateTime hireDate)
    //    {
    //        ID = id;
    //        Name = name;
    //        Gender = gender;
    //        Security = security;
    //        Salary = salary;
    //        HireDate = hireDate;
    //    }
    //
    //    public override string ToString()
    //    {
    //        return $"ID: {ID}\nName: {Name}\nGender: {(Gender == 'M' ? "Male" : "Female")}\n" +
    //           $"Security Level: {Security}\nSalary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}\n" +
    //           $"Hire Date: {HireDate.ToShortDateString()}";
    //
    //    }
    //}
    #endregion

    #region Part 01 (Q 02)
    //public class HiringDate
    //{
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }
    //
    //    public HiringDate(int day, int month, int year)
    //    {
    //        if (!IsValidDate(day, month, year))
    //            throw new ArgumentException("invalid date provided");
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }
    //
    //    private bool IsValidDate(int day, int month, int year)
    //    {
    //        try
    //        {
    //            DateTime temp = new DateTime(year, month, day);
    //            return true;
    //        }
    //        catch
    //        {
    //            return false;
    //        }
    //
    //    }
    //
    //    public override string ToString()
    //    {
    //        DateTime date = new DateTime(Year, Month, Day);
    //        return date.ToShortDateString();
    //    }
    //}
    #endregion

    #region Part 01 (Q 05)
    //public class Book
    //{
    //    public string Title { get; set; }
    //    public string Author { get; set; }
    //    public string ISBN { get; set; }
    //
    //    public Book(string title, string author, string isbn)
    //    {
    //        Title = title;
    //        Author = author;
    //        ISBN = isbn;
    //    }
    //
    //    public virtual string GetDetails()
    //    {
    //        return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
    //    }
    //}
    //
    //public class EBook : Book
    //{
    //    public double FileSizeMB { get; set; }
    //
    //    public EBook(string title, string author, string isbn, double fileSizeMB)
    //        : base(title, author, isbn)
    //    {
    //        FileSizeMB = fileSizeMB;
    //    }
    //
    //    public override string GetDetails()
    //    {
    //        return base.GetDetails() + $", File Size: {FileSizeMB} MB";
    //    }
    //}
    //
    //public class PrintedBook : Book
    //{
    //    public int PageCount { get; set; }
    //
    //    public PrintedBook(string title, string author, string isbn, int pageCount)
    //        : base(title, author, isbn)
    //    {
    //        PageCount = pageCount;
    //    }
    //
    //    public override string GetDetails()
    //    {
    //        return base.GetDetails() + $", Page Count: {PageCount}";
    //    }
    //}         

    #endregion



    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 (Q 03)
            //Employee[] EmpArr = new Employee[3];
            //
            //EmpArr[0] = new Employee(101, "Alice", 'F', SecurityLevel.DBA, 90000, new DateTime(2020, 5, 12));
            //EmpArr[1] = new Employee(102, "Bob", 'M', SecurityLevel.Guest, 40000, new DateTime(2023, 3, 5));
            //EmpArr[2] = new Employee(103, "Charlie", 'M', SecurityLevel.SecurityOfficer, 100000, new DateTime(2019, 11, 20));
            //
            //foreach (var emp in EmpArr)
            //{
            //    Console.WriteLine(emp.ToString());
            //    Console.WriteLine(new string('-', 40));
            //}
            #endregion

            #region Part 01 (Q 04)
            //Employee[] EmpArr = new Employee[3];
            //
            //EmpArr[0] = new Employee(1, "Alice", 'F', SecurityLevel.DBA, 8000.00m, new HiringDate(12, 6, 2020));
            //EmpArr[1] = new Employee(2, "Bob", 'M', SecurityLevel.Guest, 3000.00m, new HiringDate(1, 1, 2023));
            //EmpArr[2] = new Employee(3, "Charlie", 'M', SecurityLevel.SecurityOfficer, 10000.00m, new HiringDate(15, 3, 2018));
            //
            //
            //Array.Sort(EmpArr, (e1, e2) => e1.HireDate.ToDateTime().CompareTo(e2.HireDate.ToDateTime()));
            //
            //Console.WriteLine("Sorted Employees by Hire Date:");
            //foreach (var emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //}
            // The number of unboxing and boxing = 0
            #endregion

            #region Part 01 (Q 05) implement
            //Book[] library = new Book[2];
            //
            //library[0] = new EBook("Digital Fortress", "Dan Brown", "978-0-312-99542-3", 5.2);
            //library[1] = new PrintedBook("To Kill a Mockingbird", "Harper Lee", "978-0-06-112008-4", 281);
            //
            //foreach (var book in library)
            //{
            //    Console.WriteLine(book.GetDetails());
            //}
            #endregion

        }
    }
}
