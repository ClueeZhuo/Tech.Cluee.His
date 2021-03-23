
using NewLife.Log;

using System;

using Tech.Cluee.XCode.Module;

using XCode.Membership;

namespace Tech.Cluee.XCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            XTrace.UseConsole();

            StudentTest();

            Console.ReadKey();
        }

        /// <summary>
        /// User测试
        /// </summary>
        private static void UserTest()
        {
            //添加
            User user = new User()
            {
                Name = "ClueeZhuo",
                Enable = true
            };

            user.Insert();

            XTrace.WriteLine($"用户Id：{user.ID}");

            //查询
            User findUser = User.Find(User._.Name == "ClueeZhuo");

            //更新
            findUser.Logins++;
            findUser.LastLogin = DateTime.Now;
            findUser.Update();

            //删除
            User deleteUser = User.FindByID(user.ID);

            deleteUser.Delete();

        }

        private static void StudentTest()
        {
            //新增
            Student student = new Student()
            {
                FirstName = "Elena",
                LastName = "Violet",
                Age = 30,
                IdCard = "410927",
                Balance = 300
            };

            student.Insert();

            XTrace.WriteLine($"StudentID:{student.Id}");

            //查询 
            Student findStudent = Student.Find(Student._.FirstName == "Elena");

            findStudent.Balance += 100;

            //修改
            findStudent.Update();

            //删除

            Student deleteStudent = Student.FindById(findStudent.Id);
            deleteStudent.Delete();
        }
    }
}
