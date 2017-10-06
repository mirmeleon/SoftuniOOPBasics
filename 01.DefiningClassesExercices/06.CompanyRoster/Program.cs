using System;
using System.Collections.Generic;
using System.Linq;

public class Program
    {
      public static void Main()
      {
          int lines = int.Parse(Console.ReadLine());
          var email = "";
          int age = 0;
            var ppl = new List<Employee>();

          for (int i = 0; i < lines; i++)
          {
              var tokens = Console.ReadLine().Split(' ');
              var name = tokens[0];
              var salary = double.Parse(tokens[1]);
              var pos = tokens[2];
              var depar = tokens[3];

                Employee emp = new Employee(name, salary, pos, depar);

                if (tokens.Length == 5)
              {
                   email = tokens[4];
                  emp.Email = email;

              }

              if (tokens.Length == 6)
              {
                    email = tokens[4];
                    age = int.Parse(tokens[5]);
                    emp.Email = email;
                    emp.Age = age;
              }

             ppl.Add(emp);
          }
            
          var dep = ppl
              .GroupBy(em => em.Department)
              .Select(gr => new
              {
                   Name = gr.Key,
                   AverageSalary = gr.Average(em=>em.Salary),
                   Employees = gr
              })
              .OrderByDescending(gr=>gr.AverageSalary)
              .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {dep.Name}");
          foreach (var p in dep.Employees.OrderByDescending(em=>em.Salary))
          {
              Console.WriteLine($"{p.Name} {p.Salary:f2} {p.Email} {p.Age}");
          }
      }
    }
