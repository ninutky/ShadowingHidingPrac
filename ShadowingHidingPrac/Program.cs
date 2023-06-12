using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingHidingPrac
{
    internal class Program
    {
        class Animal
        {
            public virtual void Eat()
            {
                Console.WriteLine("냠냠 먹습니다");
            }
        }
        class Dog : Animal
        {
            public new void Eat()
            {
                Console.WriteLine("찹찹 먹습니다");
            }
        }
        class Cat : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("얌얌 먹습니다");
            }
        }

        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
            public virtual void Method2() 
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent {
            // 하이딩 할 때 new 연산자 사용
            public new string variable = "shadowing";
            public new void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
            public override void Method2()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        public static int number = 10;
        static void Main(string[] args)
        {
            int number = 20;
            Console.WriteLine(number);
            Child child = new Child();
            Console.WriteLine(child.variable);
            Parent parent = child;
            Console.WriteLine(parent.variable);

            child.Method();
            parent.Method();

            child.Method2();
            parent.Method2();   // 자식 실행

            List<Animal> animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog(),
            };
            foreach (var item in animals)
            {
                item.Eat();
            }

        }
    }
}
