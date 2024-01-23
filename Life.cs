using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 生き物
    /// </summary>
    class Life:Thing
    {
        readonly private string _name;
        readonly private DateTime _birthDay = new DateTime();
        public float lifespan;
        public DateTime birthday
        {
            get { return _birthDay; }
        }
        new public string name
        {
            get { return _name; }
        }
        public Life(DateTime bd ,string n, float  w = 0, float h = 0, float d = 0,float we=0,float l=0 ):base(n,w,h,d,we)
        {
            this._name = n;
            this._birthDay = bd;
            this.lifespan = l;
        }
        public int Age()
        {
            int age = DateTime.Now.Year - this._birthDay.Year;
            if (_birthDay.Month == DateTime.Now.Month)
            {
                if (_birthDay.Day > DateTime.Now.Day)
                {
                    age -= 1;
                }
            }
            else if (_birthDay.Month > DateTime.Now.Month)
            {
                age -= 1;
            }
            return age;
        }
        public bool BirgthdayJudge()
        {
            if (_birthDay.Month == DateTime.Today.Month && _birthDay.Day == DateTime.Today.Day)
                return true;
            else
                return false;
        }
        static public void SelfIntroduction(Life l)
        {
            Console.WriteLine($"名前は{l._name}");
            Console.WriteLine($"{l.Age()}" + "歳" + "\n今日が誕生日:" + $"{l.BirgthdayJudge()}");
        }
        public virtual void SelfIntroduction()
        {
            SelfIntroduction(this);
        }
    }
}
