using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Patron.Estructural.Composite.Ejercicio
{
  public abstract class Employee
    {
        protected Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; private set; }
        public int Salary { get; private set; }

        public abstract void Add(Employee employee);
        public abstract void Remove(Employee employee);

        public abstract int GetCost();
    }

    public class TeamMember : Employee
    {
        public TeamMember(string name, int salary) : base(name, salary)
        {
        }

        public override void Add(Employee employee)
        {
            //throw new NotImplementedException();
        }

        public override int GetCost()
        {
            return Salary;
        }

        public override void Remove(Employee employee)
        {
            //throw new NotImplementedException();
        }
    }

    public class TeamLead : Employee
    {
        List<Employee> _employees = new List<Employee>();

        public TeamLead(string name) : base(name, 0)
        {
        }

        public override void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public override int GetCost()
        {
            return _employees.Sum(o => o.Salary);
        }

        public override void Remove(Employee employee)
        {
            _employees.Remove(employee);
        }
    }
}