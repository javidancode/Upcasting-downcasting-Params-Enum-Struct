using System;
using Upcasting_downcasting_Enum_Struct.Models;

namespace Upcasting_downcasting_Enum_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params

            //int[] arr = { 1, 6, 9, 2, 5, };
            //GetElements(1, 6, 9, 2, 5,12,15);

            #endregion

            #region Enum

            /*CheckRole(1)*/;

            #endregion

            #region Nullable

            //Test test = new Test();
            //Console.WriteLine(test.Number);

            //string word = null;
            //int? age = null;

            //var result = age == null ? 21 : 60;

            //var result = age ?? 60;

            //Console.WriteLine(result);

            //Test test = null;

            //Console.WriteLine(test.Number.ToString());

            #endregion Nullable

            #region Struct

            //Test test = new Test("cavidan");

            //Console.WriteLine(test.Num);

            //Test2 test2 = new Test2();

            #endregion Struct

            #region Upcasting

            //Eagle eagle1 = new Eagle();

            //Eagle eagle3 = new Eagle();

            //Shark shark1 = new Shark();

            //Animal shark2 = new Shark();


            //Animal eagle2 = eagle1;

            //Animal[] animals = { eagle1, eagle2, eagle3, shark1, shark2 };

            //foreach (var item in animals)
            //{
            //    item.Eat();
            //}

            #endregion Upcasting



        }

        #region Params

        //public static void GetElements(params int[] nums)
        //{
        //    foreach (var item in nums)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        #endregion

        #region Enum

        //static void CheckRole(int roleid)
        //{
        //    switch (roleid)
        //    {
        //        case (int)Role.SuperAdmin:
        //            Console.WriteLine("Super Admin");
        //            break;
        //        case (int)Role.Admin:
        //            Console.WriteLine("Admin");
        //            break;
        //        case (int)Role.Member:
        //            Console.WriteLine("Member");
        //            break;
        //        default:
        //            Console.WriteLine("Not found");
        //            break;

        //    }
        //}

        #endregion Enum


    }

    #region Enum

    //public enum Role
    //{
    //    SuperAdmin,
    //    Admin,
    //    Member,
    //}

    #endregion Enum

    #region Nullable

    //class Test
    //{
    //    public int? Number  { get; set; }

    //    public string word { get; set; }
    //}

    #endregion Nullable

    #region Struct
    //struct Test1
    //{
    //    public int Num { get; set; }

    //    public Test1(string name)
    //    {
    //        Num = 21;
    //        Console.WriteLine(Num);
    //    }


    //}

    //class Test2
    //{
    //    public int MyProperty { get; set; } = 21;

    //    public Test2()
    //    {
    //        Console.WriteLine("Bos");
    //    }

    //    public Test2(int b)
    //    {
    //        Console.WriteLine("Dolu");
    //    }
    //}

    //struct Test3
    //{

    //}

    //interface ITest4
    //{

    //}

    #endregion Struct
}
