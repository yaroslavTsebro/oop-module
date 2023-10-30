using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Tank
    {
        private string id;
        private int capacity;
        private int currentAmount;
        private JuiceType juice;

        public static int CriticalPercentage { get; private set; } = 90;
        public static int TankCount { get; private set; } = 0;

        public string Id
        {
            get { return id; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("назва резервуара не може бути пустим рядком");
                id = value;
            }
        }
        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("ємкість резервуара не може бути від'ємним числом або дорівнювати 0");
                capacity = value;
            }
        }

        public int CurrentAmount
        {
            get => currentAmount;
            private set
            {
                if (value < 0 || value > capacity * CriticalPercentage / 100)
                    throw new ArgumentException("Некоректна кількість соку!");
                currentAmount = value;
            }
        }

        public JuiceType Juice
        {
            get => juice;
            set
            {
                if (currentAmount == 0 && value == JuiceType.UNKNOWN)
                    juice = value;
                else if (currentAmount > 0 && value != JuiceType.UNKNOWN)
                    juice = value;
                else
                    juice = JuiceType.UNKNOWN;
            }
        }

        public bool IsFree => currentAmount == 0;
        public bool IsFull => currentAmount >= capacity * CriticalPercentage / 100;
        public int FreeAmount => capacity * CriticalPercentage / 100 - currentAmount;

        public Tank(string id, int capacity)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Назва резервуара не може бути пустою!");

            if (capacity <= 0)
                throw new ArgumentException("Ємність резервуара повинна бути додатньою!");

            this.id = id;
            this.capacity = capacity;
            this.currentAmount = 0;
            this.juice = JuiceType.UNKNOWN;
            TankCount++;
        }

        public Tank(string id, int capacity, int currentAmount, JuiceType juice) : this(id, capacity)
        {
            this.CurrentAmount = currentAmount;
            this.Juice = juice;
        }


        public bool AddJuice(int amount, JuiceType juiceType)
        {
            if (juice != juiceType)
                return false;

            if (currentAmount + amount > capacity * CriticalPercentage / 100)
                return false;

            this.Juice = juiceType;
            this.CurrentAmount += amount;
            return true;
        }

        public void MakeFree()
        {
            this.currentAmount = 0;
            this.juice = JuiceType.UNKNOWN;
        }

        public string GetInfo()
        {
            return $"Id: {id}, Capasity: {capacity}, Current amount: {currentAmount}, Juice type: {juice}";
        }

        public static bool ChangeCriticalPercentage(int percentage)
        {
            if (percentage < 0 || percentage > 100)
                return false;

            CriticalPercentage = percentage;
            return true;
        }
    }
}
