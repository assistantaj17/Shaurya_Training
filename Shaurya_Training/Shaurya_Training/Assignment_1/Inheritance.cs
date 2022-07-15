using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaurya_Training.Assignment_1
{
    // Program 01
    abstract public class Teacher
    {
        public int Tid;
        public string TName;
        public long MobNo;
        public Teacher(int Tid, string TName, long MobNo)
        {
            this.Tid = Tid;
            this.TName = TName;
            this.MobNo = MobNo;
        }
        public abstract void Salary();
    }
    public class Hourlybased : Teacher
    {
        public int hrs;
        public int rate_per_hr;
        public Hourlybased(int Tid, string TName, long MobNo, int hrs, int r) : base(Tid, TName, MobNo)
        {
            this.hrs = hrs;
            this.rate_per_hr = r;
        }

        public override void Salary()
        {
            Console.WriteLine("Salary of HourlyBased Teacher " + (hrs * rate_per_hr));
        }
    }
    class SalaryBased : Teacher
    {
        public int salary;
        public SalaryBased(int Tid, string TName, long MobNo, int salary) : base(Tid, TName, MobNo)
        {
            this.salary = salary;
        }
        public override void Salary()
        {
            Console.WriteLine("Salary of SalaryBased teacher " + salary);
        }
    }
    class Program01
    {
        static void Main(string[] args)
        {
            Teacher hb = new Hourlybased(101, "Sachin", 985647, 5, 500);
            hb.Salary();
            Teacher sh = new SalaryBased(401, "Rahul", 958674, 45000);
            sh.Salary();
        }
    }


    // Program 02
    class Nib
    {
        private string materialtype;
        private int width;
        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
    }
    class Refill
    {
        private string inkcolor;
        private int length;
        Nib tip;
        public string Inkcolor
        {
            set { inkcolor = value; }
            get { return inkcolor; }
        }
        public int Length
        {
            set { length = value; }
            get { return length; }
        }
        public Nib Tip
        {
            set { tip = value; }
            get { return tip; }
        }
    }
    class Pen
    {
        private int caplength;
        private string brand;
        Refill r;
        public int Caplength
        {
            set { caplength = value; }
            get { return caplength; }
        }
        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }
        public Refill R
        {
            set { r = value; }
            get { return r; }
        }
    }
    class Program02
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.Caplength = 3;
            p.Brand = "Cello";
            p.R = new Refill();
            p.R.Inkcolor = "Blue";
            p.R.Length = 5;
            p.R.Tip = new Nib();
            p.R.Tip.Materialtype = "Lid";
            p.R.Tip.Width = 2;
            Console.WriteLine("CapLength "+p.Caplength+"  "+" Brand  "+p.Brand);
            Console.WriteLine("InkColour  "+p.R.Inkcolor+"  "+" Length  "+p.R.Length);
            Console.WriteLine("Material Type  "+p.R.Tip.Materialtype+"  "+" Width  "+p.R.Tip.Width);
        }
    }

    // Program 03
    class Person
    {
        private int id;
        private String name;
        Vehicle v;
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public Vehicle V
        {
            set { v = value; }
            get { return v; }
        }

    }
    class Vehicle
    {
        private int vid;
        private string vname;
        public int VID
        {
            set { vid = value; }
            get { return vid; }
        }
        public string Vname
        {
            set { vname = value; }
            get { return vname; }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.ID = 101;
            p.Name = "Vikas";
            Vehicle v = new Vehicle();
            v.VID = 20356;
            v.Vname = "Nexon";
            Console.WriteLine("Person ID "+p.ID+"  "+" Person Name "+p.Name);
            Console.WriteLine("Vehicle ID "+v.VID+"  "+" Vehicle name "+v.Vname);
        }
    }


    // Program 07
    class Order
    {
        int ordered;
        string orderdate;
        Customer cust;
        Item item;
        public int Ordered
        {
            set { ordered = value; }
            get { return ordered; }
        }
        public string Orderdate
        {
            set { orderdate = value; }
            get { return orderdate; }
        }
        public Customer Cust
        {
            set { cust = value; }
            get { return cust; }
        }
        public Item Item
        {
            set { item = value; }
            get { return item; }
        }
    }
    class Customer
    {
        int custid;
        string custname;
        Address address1;
        public int Custid
        {
            set { custid = value; }
            get { return custid; }
        }
        public string Custname
        {
            set { custname = value; }
            get { return custname; }
        }
        public Address Address1
        {
            set { address1 = value; }
            get { return address1; }
        }
    }
    class Address
    {
        string addr1;
        string city;
        int pincode;
        public string Addr1
        {
            set { addr1 = value; }
            get { return addr1; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public int Pincode
        {
            set { pincode = value; }
            get { return pincode; }
        }
    }
    class Item
    {
        int itemid;
        string itemname;
        int price;
        public int Itemid
        {
            set { itemid = value; }
            get { return itemid; }
        }
        public string Itemname
        {
            set { Itemname = value; }
            get { return Itemname; }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }
    }
    class Program07
    {
        Order od = new Order();
        //od.Ordered=10;
        Customer c = new Customer();
        //c.Custid=121;
        Item i=new Item();
        //i.Itemid=121;
    }

    //  Program 08
    class Account
    {
        long accno;
        string custname;
        long balance;
        public long Accno
        {
            set { accno = value; }
            get { return accno; }
        }
        public string Custname
        {
            set { custname = value; }
            get { return custname; }
        }
        public long Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public Account()
        {
            Console.WriteLine("This is Default Constructor");
        }
        public Account(long accno, string custname, long balance)
        {
            this.Accno = accno;
            this.Custname = custname;
            this.Balance = balance;
            Console.WriteLine("This is Parameterized Constructor");
        }
        public void DepositeAmount()
        {
            Console.WriteLine("Enter amount to be deposited");
            int n = int.Parse(Console.ReadLine());
            balance = balance + n;
            Console.WriteLine("Amount deposited  \n balance is " + balance);
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter amount to be withdraw");
            int n = int.Parse(Console.ReadLine());
            if (n > balance)
                Console.WriteLine("you do not have sufficient balance");
            else
                balance = balance - n;
            Console.WriteLine("After Withdrwa  \n balance is " + balance);
        }
        public void CheckBalance()
        {
            Console.WriteLine("Balance is " + balance);
        }
        static void Main(string[] args)
        {
            Account a = new Account();
            Account ac = new Account(4465321, "Mohan", 50645);
            ac.DepositeAmount();
            ac.Withdraw();
            ac.CheckBalance();
        }
    }
}
