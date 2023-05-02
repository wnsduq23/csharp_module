namespace assignment1
{ 
    class Program
    { 
        static void Main(String[] args)
        {
            StreamReader    sr = new StreamReader("input.txt");
            StreamWriter    sw = new StreamWriter("output.txt");
            Computer c = new Computer();
            User u = new User();
            ComputerManager cm = new ComputerManager();
            //이거 어디 안으로 넣을수가없나
            int stud_num = 0;
            int gamer_num = 0;
            int worker_num = 0;

            //input

            // Total number of computers
            c.ComputerNum = int.Parse(sr.ReadLine());

            // Different type of computers's num
            string input = sr.ReadLine();
            string[] numbers = input.Split(' ');
            cm.InitCompArray(int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]));

            // Number of Users
            u.UserNum = int.Parse(sr.ReadLine());
            
            // User List
            // i think it have to make arraylist or sth
            // can i use 'numbers' more time ? it can
            //  interrupt sometimes.
            for (int i = 0; i < u.UserNum; i++)
            {
                input = sr.ReadLine();
                numbers = input.Split(' ');
                u.UserId = i + 1;
                u.UserName = numbers[1];
                if (numbers[0].Equals("Student"))
                {
                }
                else if (numbers[0].Equals("Gamer"))
                {
                }
                else if (numbers[0].Equals("Worker"))
                {
                }
            }

            // Writeline order output until order "Q"
            input = sr.ReadLine();
            numbers = input.Split(' ');
            while (true)
            {
                switch (numbers[0])
                {
                    case "S":
                        sw.WriteLine("Total Cost: ");
                        cm.WriteTotalCost();
                        sw.WriteLine("Computer List: ");
                        cm.WriteComputerList(ref sw);
                        sw.WriteLine("User List: ");
                        cm.WriteUserList(ref sw);
                        break;
                    case "T":
                        cm.OneDayLater(int.Parse(numbers[1]));
                        break;
                    case "R":
                        cm.ReturnFromUser(int.Parse(numbers[1]));
                        break;
                    case "A":
                        cm.RentToUser(int.Parse(numbers[1]), int.Parse(numbers[2]), ref sw);
                        break;
                    case "Q":
                        sr.Close();
                        sw.Close();
                        Environment.Exit(0);
                        break;
                }
                sw.WriteLine("=============================");
            }
		}
	}
}