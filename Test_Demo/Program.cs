using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //// prime number
            //doworkPrimenumber();

            //// factorial
            // factorialNumber();

            //// palindrome
            //isPalindrome("adda");
            //isPalindrome("nike");
            //isPalindrome("sunsilk");
            //isPalindrome("rubber");
            //isPalindrome("rebber");
            //Console.ReadKey();

            //// increase 1
            //increaseOne();
        }

        #region Prime Number

        private static void doworkPrimenumber()
        {
            for (int i = 0; i < 1000000; i++)
            {
                if (isPrimenumber(i))
                {
                    Console.WriteLine($"{i} is prime number...");
                }
            }
        }

        private static bool isPrimenumber(int number)
        {
            int factor = number / 2;
            int i = 0;
            for (i = 2; i <= factor; i++)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion Prime Number

        #region Factorial

        private static void factorialNumber()
        {
            int factorial = 1;
            int num = 100;
            for (int i = 1; i <= 100; i++)
            {
                factorial = factorial * i;
            }
            // greater than integer
            Console.WriteLine($"factorial of {num} is {factorial}");
            Console.ReadKey();
        }

        #endregion Factorial

        #region Palindrome

        private static void isPalindrome(string myString)
        {
            int indexLeft = 0;
            int indexRight = myString.Length - 1;
            int flag = 0;
            while (indexLeft < indexRight)
            {
                if (myString[indexLeft] != myString[indexRight])
                {
                    flag = 1;
                    break;
                }
                indexLeft++;
                indexRight--;
            }

            if (flag == 0)
            {
                Console.WriteLine($"{myString} is a Palindrome ");
            }
            else
            {
                Console.WriteLine($"{myString} is not a Palindrome ");
            }
        }

        #endregion Palindrome

        #region increase1

        private static void increaseOne()
        {
            string strOne = "1";
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"{strOne}");
                strOne += 1;
            }
            Console.WriteLine($"{strOne}");
            Console.ReadKey();
        }

        #endregion increase1

        // ข้อ 5 SELECT * FROM LKPROVINCE WHERE PROVINCE_NAME LIKE '%กรุง' ORDER BY UpdateDate DESC;
        // ข้อ 6 DELETE FROM LKPROVINCE WHERE PROVINCE_ID > 10;
        // ข้อ 7 SELECT SUBSTRING(PROVINCE_NAME, 1,1) FROM LKPROVINCE;
        // ข้อ 8 UPDATE LKPROVINCE SET UpdateDate = DATE_FORMAT(NOW(), '%Y-%d-%m') WHERE PROVINCE_NAME = 'กรุงเทพมหานคร';
        // ข้อ 9 INSERT INTO PROVINCE_NAME (PROVINCE_ID, PROVINCE_NAME, CreateBy, CreateDate) VALUES (10, 'กรุงเทพมหานคร', 'system', DATE_FORMAT(NOW(), '%Y-%d-%m'));
        // ข้อ 10 SELECT MS_CUSTOMER.MS_CUS_ID, MS_CUSTOMER.CUS_NAME, LKPROVINCE.PROVINCE_NAME FROM MS_CUSTOMER LEFT JOIN LKPROVINCE ON MS_CUSTOMER.PROVINCE_ID = LKPROVINCE.PROVINCE_ID;
        // ข้อ 11 SELECT EMP.Emp_Name, DEP.Dept_Name, MAX(EMP.Salary) FROM EMP LEFT JOIN DEP ON EMP.Dept_ID = DEP.Dept_ID WHERE DEP.Location NOT IN ('LA') GROUP BY DEP.Dept_ID;
        // ข้อ 12 SELECT EMP.Emp_Name, DEP.Dept_Name, MAX(EMP.Salary) FROM EMP LEFT JOIN DEP ON EMP.Dept_ID = DEP.Dept_ID WHERE EMP.Salary < (SELECT MAX(EMP.Salary) FROM EMP);
        // ข้อ 13 CREATE VIEW VW_EMP AS SELECT EMP.Emp_ID, EMP.Emp_Name, DEP.Dept_Name, EMP.Salary FROM EMP LEFT JOIN DEP ON EMP.Dept_ID = DEP.Dept_ID;
        // ข้อ 14 ALTER TABLE EMP DROP COLUMN Dep_ID;
        // PART3 ผมไม่มีความรู้เรื่อง MongoDB เลยครับ
    }
}