using System;

namespace assignment1
{
	public class User
	{
		private int user_id;// if user = 4, userid 1~4
		private string user_name;
		private int user_num;

		protected int using_period;
		protected bool Rent = false; // if Rent is true, he(she) rents sth
		protected int comp_id_which_is_used;


        public int UserId
		{
			get { return user_id; }
			set { user_id = value; }
		}

		public string UserName
		{
			get { return user_name; }
			set { user_name = value; }
		}

		public int UserNum
		{
			get { return user_num; }
			set { user_num = value; }
		}

		public virtual void UserInfo(ref StreamWriter sw)
		{
			Console.WriteLine("if this output on console, it's ERROR");
		}


		public User()
		{

		}
	}

	public class Workers : User
	{
		private int worker_id = 0;
        public readonly string[] reason_to_use = { "internet" };

        public override void UserInfo(ref StreamWriter sw)
        {
            sw.WriteLine("type: Workers, ");
            sw.WriteLine("Name: {0}, ", UserName);
            sw.WriteLine("UserId: {0}, ", UserId);
            sw.WriteLine("WorkerId: {0}, ", worker_id);
            sw.WriteLine("Used for: {0}, ", reason_to_use);
            sw.WriteLine("Rent: {0} ", Rent);
			if (Rent == true)
			{
				sw.WriteLine("(RentComId: {0})", comp_id_which_is_used);
			}
			worker_id++;
        }
    }
    public class Students : User
	{ 
		private int student_id = 0;
        public readonly string[] reason_to_use = { "internet", "scientific" };

        public override void UserInfo(ref StreamWriter sw)
        {
            sw.WriteLine("type: Students ");
            sw.WriteLine("Name: {0} ", UserName);
            sw.WriteLine("UserId: {0} ", UserId);
            sw.WriteLine("StudId: {0} ", student_id);
            sw.WriteLine("Used for: {0} ", reason_to_use);
            sw.WriteLine("Rent: {0} ", Rent);
			if (Rent == true)
			{
				sw.WriteLine("(RentComId: {0})", comp_id_which_is_used);
			}
			student_id++;
        }
	}
	public class Gamers : User
	{ 
		private int gamer_id = 0;
        public readonly string[] reason_to_use = { "internet", "game" };

        public override void UserInfo(ref StreamWriter sw)
        {
            sw.WriteLine("type: Gamers ");
            sw.WriteLine("Name: {0} ", UserName);
            sw.WriteLine("UserId: {0} ", UserId);
            sw.WriteLine("GamerId: {0} ", gamer_id);
            sw.WriteLine("Used for: {0} ", reason_to_use);
            sw.WriteLine("Rent: {0} ", Rent);
			if (Rent == true)
			{
				sw.WriteLine("(RentComId: {0})", comp_id_which_is_used);
			}
			gamer_id++;
        }
	}
}
