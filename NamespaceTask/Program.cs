namespace NamespaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task2
            //    User user1 = new User("Punhan", "Aliyeva", "_Punhan", "1234567");
            //    User user2 = new User("Aygun", "Shahmuradova", "Aygun18", "111aaa");
            //    User user3 = new User("Selma", "Mammedli", "MSelma", "311103s");
            //    User user4 = new User("Narmin", "Valizada", "nnarmin", "1603nnn");
            //    Console.WriteLine("Zehmet olmasa username daxil edin:");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("Zehmet olmasa parolu daxil edin:");
            //    string password = Console.ReadLine();

            //    User[] Users = new[] { user1, user2, user3, user4 };
            //    bool IsCorrectUser = false;
            //    User newUser = new();
            //    for (int i = 0; i < Users.Length; i++)
            //    {
            //        if (Users[i].Username.Equals(username, StringComparison.OrdinalIgnoreCase) && Users[i].Password.Equals(password, StringComparison.OrdinalIgnoreCase))
            //        {
            //            IsCorrectUser = true;
            //            newUser = Users[i];
            //        }
            //    }
            //    if (!IsCorrectUser)
            //    {
            //        Console.WriteLine("Bele bir user yoxdu..");
            //    }
            //    Student stu1 = new Student("Ali", "Aliyev", "ali053", "1234567yu8", 83);
            //    Student stu2 = new Student("Aygun", "Mamedova", "aygun", "fr5tgy7u", 78);
            //    Student stu3 = new Student("Punhan", "Aliyeva", "_punhan", "1234567", 57);
            //    Student stu4 = new Student("Narmin", "Valizada", "nnarmin", "1603nnn" ,11);
            //    Student[] Students = new[] { stu1, stu2, stu3,stu4 };
            //    int grade = 0;
            //    foreach (var student in Students)
            //    {
            //        if (IsCorrectUser)
            //        {
            //            if (student.Username.Equals(newUser.Username, StringComparison.OrdinalIgnoreCase) && student.Password.Equals(newUser.Password, StringComparison.OrdinalIgnoreCase))
            //            {
            //                grade = student.Grade;
            //            }
            //        }
            //    }

            //    Console.WriteLine($"Grade:{grade}");
            //}

            #endregion

                                                       // 0  1  2  3  4  5           // 0 1 2
            Console.WriteLine(IsArrayContains(new int[] { 2, 3, 1, 9, 0 }, new int[] {  9,0 }));
        }


        #region Task1
        static bool IsArrayContains(int[] arr1, int[] arr2)
        {
            int index = 0;
            foreach (int value in arr1)
            {
                if (value == arr2[index])
                {
                    index++;
                }
                if (index == arr2.Length)
                {
                    return true;
                }
            }
            return false;   
        }

        #endregion

    }

}


