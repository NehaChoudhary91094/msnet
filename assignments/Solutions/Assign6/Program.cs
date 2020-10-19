using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign6
{
    class Dept
    {
        public int DeptNo { get; set; }
        public String DeptName { get; set; }
        public string Location { get; set; }
    }
    class Emp
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }

        public string Designation { get; set; }
        public double Salary { get; set; }
        public double Commision { get; set; }

        public double NetSalary { 
            get { 
                return Salary + Commision; 
            }
         }
        public int DeptNo { get; set; }

        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4}", 
                EmpNo, EmpName, Designation, NetSalary, DeptNo);
        }
    }
    class Solution
    {
        // 5Find department names in which no employees
        public static List<string> FindDeptsWithNoEmps(Dictionary<int, Emp> EmpList, Dictionary<int, Dept> DeptList)
        {
            //In SQL
            //SELECT DNAME FROM DEPT WHERE DEPTNO NOT IN (SELECT DEPTNO FROM EMP)
            var innerQuery = (from e in EmpList.Values
                              select e.DeptNo);
            var result = (from d in DeptList.Values
                          where !innerQuery.Contains(d.DeptNo)
                          select d.DeptName).ToList();
            return result;
        }
        //6. Write function to calculate total salary (Sal+Comm) of all employees
        public static double Calcluate_Total_Salary(Dictionary<int, Emp> EmpList)
        {
            //In SQL
            //SELECT SUM(SAL+COMM) FROM EMP
            var result = (from e in EmpList select e.Value.NetSalary).Sum();
            return result;
        }
        //7. Write function to display all employees of particular department
        public static List<Emp> GetAllEmployeesByDept(int DeptNo, Dictionary<int, Emp> EmpList)
        {
            //In SQL
            //SELECT * FROM EMP WHERE DEPTNO=10;

            var result = (from e in EmpList.Values
                          where e.DeptNo == DeptNo
                          select e).ToList();
            return result;
        }
        //8. Write function to calculate department wise count of employees
        public static Dictionary<int, Double> DeptwiseStaffCount(Dictionary<int, Emp> EmpList)
        {
            //In SQL
            //SELECT DEPTNO, COUNT(EMPNO) FROM EMP GROUP BY DEPTNO
            var result = (from e in EmpList.Values
                         group e by e.DeptNo into g
                         select new
                         {
                             DeptNo = g.Key,
                             StaffCount = Convert.ToDouble(g.Count())
                         }).ToDictionary(g=>g.DeptNo, g=> g.StaffCount);

            return result;
        }
        //9. Write function to calculate department wise average salary
        public static Dictionary<int, Double> DeptwiseAvgSal(Dictionary<int, Emp> EmpList)
        {
            //In SQL
            //SELECT DEPTNO, AVG(SAL) FROM EMP GROUP BY DEPTNO

            var result = (from e in EmpList.Values
                          group e by e.DeptNo into g
                          select new
                          {
                              DeptNo = g.Key,
                              AvgSal = Convert.ToDouble(g.Average(e => e.Salary))
                          }).ToDictionary(g => g.DeptNo, g => g.AvgSal);

            return result;
        }
        //10. Write function to calculate department wise minimum salary
        public static Dictionary<int, Double> DeptwiseMinSal(Dictionary<int, Emp> EmpList)
        {
            //In SQL
            //SELECT DEPTNO, MIN(EMPNO) FROM EMP GROUP BY DEPTNO

            var result = (from e in EmpList.Values
                          group e by e.DeptNo into g
                          select new
                          {
                              DeptNo = g.Key,
                              MinSal = Convert.ToDouble(g.Min(e => e.Salary))
                          }).ToDictionary(g => g.DeptNo, g => g.MinSal);

            return result;

        }
        //11. Display employee names along with department names
        public static Dictionary<int, string> GetEmpInfo(Dictionary<int, Emp> EmpList, Dictionary<int, Dept> DeptList)
        {
            var result = (from e in EmpList.Values
                      join d in DeptList.Values on e.DeptNo equals d.DeptNo
                      select new
                      {
                          e.EmpNo,
                          e.EmpName,
                          d.DeptName,
                      }).ToDictionary(e => e.EmpNo, e=>String.Format("{0},{1}",e.EmpName,e.DeptName));
            return result;
        }
    }
    class Program
    {
        static Dictionary<int, Dept> DeptList = new Dictionary<int, Dept>();
        static Dictionary<int, Emp> EmpList = new Dictionary<int, Emp>();
        static void Main(string[] args)
        {
            LoadDataSet();
            Console.WriteLine("// 5Find department names in which no employees");
            var ans5 = Solution.FindDeptsWithNoEmps(EmpList, DeptList);
            PrintList(ans5);

            Console.WriteLine("//6. Write function to calculate total salary (Sal+Comm) of all employees");
            var ans6 = Solution.Calcluate_Total_Salary(EmpList);
            Console.WriteLine(ans6);

            Console.WriteLine("//7. Write function to display all employees of particular department");
            var ans7 = Solution.GetAllEmployeesByDept(30, EmpList);

            Console.WriteLine("//8. Write function to calculate department wise count of employees");
            var ans8 = Solution.DeptwiseStaffCount(EmpList);
            PrintDictionary(ans8);

            Console.WriteLine("//9. Write function to calculate department wise average salary");
            var ans9 = Solution.DeptwiseAvgSal(EmpList);
            PrintDictionary(ans9);

            Console.WriteLine("//10.Write function to calculate department wise minimum salary");
            var ans10 = Solution.DeptwiseMinSal(EmpList);
            PrintDictionary(ans10);

            Console.WriteLine("//11.Display employee names along with department names");
            var ans11 = Solution.GetEmpInfo(EmpList, DeptList);
            PrintDictionary(ans11);

            Console.ReadLine();
        }
        static void PrintDictionary(dynamic dict)
        {
            foreach (var data in dict)
            {
                Console.WriteLine(string.Format("{0},{1}",data.Key, data.Value));
            }
        }

        static void PrintList(dynamic list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(string.Format("{0}", data.ToString()));
            }
        }
        static void LoadDataSet()
        {
            string path = @"F:\demos\HRMS\Assign6\dataset.txt";

            int dataSetCount = 0;
            //On hackrank fil
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                string lineAsInput = "";

                StreamReader reader = new StreamReader(fs);
                while ((lineAsInput = reader.ReadLine()) != null) //On HackerEarth use Console.ReadeLine() to take input
                {
                    string[] data = null;
                    if (lineAsInput.Trim().StartsWith("-"))
                    {
                        dataSetCount++;
                        continue;
                    }
                    if (dataSetCount == 1)
                    {
                        data = lineAsInput.Split(',');
                        Dept dept = new Dept() { DeptNo = Convert.ToInt32(data[0]), DeptName = data[1], Location = data[2] };
                        DeptList.Add(dept.DeptNo, dept);
                    }
                    else if (dataSetCount == 2)
                    {
                        data = lineAsInput.Split(',');
                        Emp emp = new Emp()
                        {
                            EmpNo = Convert.ToInt32(data[0]),
                            EmpName = data[1],
                            Designation = data[2],
                            Salary = Double.Parse(data[3]),
                            Commision = Double.Parse(data[4]),
                            DeptNo = Convert.ToInt32(data[5])
                        };
                        EmpList.Add(emp.EmpNo, emp);
                    }
                }
                fs.Close();
            }
        }
    }
}
