namespace Assignment2_4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            double mathsMark, physicsMark, chemistryMark;

            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter Your Maths Mark: ");
            while (!double.TryParse(Console.ReadLine(), out mathsMark))
            {
                if (mathsMark < 0 || mathsMark <= 100)
                {
                    Console.WriteLine("Mark Should be a positive integer!! Enter your Maths Mark: ");
                }
            }

            Console.Write("Enter Your Physics Mark: ");
            while (!double.TryParse(Console.ReadLine(), out physicsMark))
            {
                if (physicsMark < 0 || physicsMark <= 100)
                {
                    Console.WriteLine("Mark Should be a positive integer!! Enter your Maths Mark: ");
                }
            }

            Console.Write("Enter Your Chemstry Mark: ");
            while (!double.TryParse(Console.ReadLine(), out chemistryMark))
            {
                if (chemistryMark < 0 || chemistryMark <= 100)
                {
                    Console.WriteLine("Mark Should be a positive integer!! Enter your Maths Mark: ");

                }
            }

            //calculating marks
            double totalMark1 = mathsMark + physicsMark + chemistryMark;
            double totalMark2 = mathsMark + physicsMark;

            //checking eligibility
            if ((mathsMark >= 65 && physicsMark >= 55 && chemistryMark >= 50) || (totalMark1 >= 180 || totalMark2 >= 140))
            {
                Console.WriteLine($"Congratulations {studentName}!! You are Eligible to get Admission");
            }
            else
            {
                Console.WriteLine($"Sorry {studentName}!! You are not Eligible");
            }

        }
    }
}
