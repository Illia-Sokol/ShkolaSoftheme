using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Modules.Models
{
    public interface Subject
    {
        void Register(Observer o);
        void UnRegister(Observer o);
        void Notify();
    }

    public interface Observer
    {
        void update(String operation, String record);
    }

    public class EmployeeObserver : Subject
    {
        public List<Observer> observerList;
        private String operation;
        private String record;
        public EmployeeObserver()
        {
            observerList = new List<Observer>();
        }
        public void Register(Observer o)
        {
            observerList.Add(o);
        }

        public void UnRegister(Observer o)
        {
            observerList.Remove(o);
        }

        public void Notify()
        {
            for (int loopIndex = 0; loopIndex < observerList.Count; loopIndex++)
            {
                Observer observer = (Observer)observerList[loopIndex];
                observer.update(operation, record);
            }
        }

        public void EditRecord(String operation, String record)
        {
            this.operation = operation;
            this.record = record;
            Notify();
        }
    }

    public class Manager : Observer
    {
        public string Record { get; set; }
        public void update(string operation, string record)
        {
            Record = ("Manager" + ',' + operation + ',' + record);
        }
    }

    public class Admin : Observer
    {
        public string Record { get; set; }
        public void update(string operation, string record)
        {
            Record = ("Admin" + ',' + operation + ',' + record);
        }
    }

}
