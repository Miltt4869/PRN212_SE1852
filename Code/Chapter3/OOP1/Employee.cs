using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Employee
    {
        private int _id;    //instance variable

        private string _name;//instance variable

        private string _email;
        private string _phone;

        // ưu tiên xử lý cho local nếu cả 2 có cùng tên

        #region Nhóm các contructer của empl
        public Employee() 
        { 

        }
       public Employee(int _id,  string _name, string _email, string _phone) //local variable
        {
            this._id = _id;
            this._name = _name;
            //or
            Email = _email; // gọi là setter cho proterty Email 
            Phone = _phone;

        }

        #endregion
        #region Nhóm các set/get
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
       
        public string Name {
            get { return _name; }
            set { _name = value;}
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        #endregion
        public void PrintInfer()
        {
            Console.WriteLine($"{_id}\t {_name}\t {_email}\t {_phone}");
        }

        public override string ToString()
        {
            string msg = $"{_id}\t {_name}\t {_email}\t {_phone}";
            return msg;

        }


    }
}
