using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
		public static void Main()
		{
				//Example-01
				Console.WriteLine("========== Example-01 Sum, Max, Min, Count, Average ==========");

				int[] numbers = { 8, 2, 6, 3 };
				int sum = numbers.Sum();
				Console.WriteLine("numbers: {0},{1},{2},{3}", numbers[0], numbers[1], numbers[2], numbers[3]);
				Console.WriteLine("sum: " + sum);

				int max = numbers.Max();
				Console.WriteLine("max: " + max);

				int min = numbers.Min();
				Console.WriteLine("min: " + min);

				int count = numbers.Count();
				Console.WriteLine("count: " + count);

				double average = numbers.Average();
				Console.WriteLine("average: " + average);

				//Example-02
				Console.WriteLine("========= Example-02 OrderByDescending ==========");
				var emps = new List<Employee>
				{
						new Employee { Name = "Ann", Age = 31, Gender = "F", Salary = 50000},
						new Employee { Name = "Brian", Age = 25, Gender = "M", Salary = 40000 },
						new Employee { Name = "Cara", Age = 50, Gender = "F", Salary = 65000 },
						new Employee { Name = "Dave", Age = 33, Gender = "M", Salary = 52000 }
				};

				var winner = emps.OrderByDescending(emp => emp.Salary).First();
				Console.WriteLine($"{winner.Name} earns the highest salary of ${winner.Salary}.\r\n");
		}
}

public class Employee
{
		public string? Name { get; set; }
		public int Age { get; set; }
		public decimal Salary { get; set; }
		public string? Gender { get; set; }
}
