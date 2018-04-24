using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

public class Program {
    interface IPerson {
        string Name { get; }
    }

    interface IEmployee: IPerson {
        decimal Salary { get; }
    }

    class Person : IPerson {
        public string Name { get; set; }
    }

    class Employee : IEmployee {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    public static void Execute() {
        IPerson john = new Employee {
            Name = "John",
            Salary = 5000
        };
        IPerson carry = new Person {
            Name = "Carry"
        };
        IPerson alice = new Employee {
            Name = "Alice",
            Salary = 7000
        };
        
        List<IPerson> People = new List<IPerson> { john, carry, alice };
        foreach (IPerson person in People)
            if(person is IEmployee)
                WriteLine($"{ (person as IEmployee).Salary }");
        
    }
}