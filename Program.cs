using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customexceptiondemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> rollnos = new List<int>();
            rollnos.Add(1);
            rollnos.Add(2);
            rollnos.Add(3);
            rollnos.Add(4);
            rollnos.Add(5);
            rollnos.Add(6);

            try
            {
                Console.WriteLine("Enter rollno to find");
                int rno = Convert.ToInt32(Console.ReadLine());
                bool ans = rollnos.Contains(rno);

                Console.WriteLine("Enter i");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter j");
                int j = Convert.ToInt32(Console.ReadLine());

                //CUSTOM EXCEPTION FOR ROLL NO EXISTENCE
                if (ans == false)
                {


                    throw new StudentNotFoundException("This rollno doesnot exist");
                }
                else
                {
                    Console.WriteLine("Roll no found");
                }

                //CUSTOM EXCEPTION FOR DIVBYZERO EXISTENCE
                if (j == 0)
                {
                    throw new DivideByZeroException("This division would not be possible");

                }
                else
                {
                    int Divans = i / j;
                    Console.WriteLine(Divans);
                }

                
            }
            catch (StudentNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.....");
            }
            Console.ReadLine();
        }
    }
}
