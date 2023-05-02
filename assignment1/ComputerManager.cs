using System;
namespace assignment1
{
	public class ComputerManager
	{
		private int total_cost = 0;
		private Computer[] arrComp;
		private User[] arrUser;

		//다형성 써서 배열 안에 집어넣어야함
		//Init Computer's array 
		public void InitCompArray(int note_num, int desk_num, int net_num)
		{
			arrComp = new Computer[note_num + desk_num + net_num];

            for (int i = 0; i < note_num; i++)
			{
				arrComp[i] = new Notebook();
			}	
            for (int i = note_num; i < desk_num; i++)
			{
				arrComp[i] = new Desktop();
			}	
            for (int i = note_num + desk_num; i < net_num; i++)
			{
				arrComp[i] = new Netbook();
			}	
		}

		//Init User's array 
		public void InitUserArray(int note_num, int desk_num, int net_num)
		{
			arrComp = new Computer[note_num + desk_num + net_num];

            for (int i = 0; i < note_num; i++)
			{
				arrComp[i] = new Notebook();
			}	
            for (int i = note_num; i < desk_num; i++)
			{
				arrComp[i] = new Desktop();
			}	
            for (int i = note_num + desk_num; i < net_num; i++)
			{
				arrComp[i] = new Netbook();
			}	
		}

		//"A"
		public void RentToUser(int user_id, int days_requested, ref StreamWriter sw)
		{
			int comp_id = FindFitComp(user_id);
			sw.WriteLine("Computer #{0} has been assigned to User #{1}", comp_id, user_id);

			//init user_day_status & connect user_id <=> comp_id
			arrComp[comp_id - 1].days_requested = days_requested;
			arrComp[comp_id - 1].days_left = days_requested;
			arrComp[comp_id - 1].days_used = 0;
			arrComp[comp_id - 1].user_id_who_use_comp = user_id;
			arrUser[user_id - 1].comp_id_which_is_used = comp_id;
		}

		public int FindFitComp(int user_id)
		{
			int comp_id;

			// SWITCH case
			
			switch("")
			{
				case "internet":

				case "scientific":

				case "game":

					break;
			}

			return (comp_id);
		}
		
		//"R"
		public void ReturnFromUser(int user_id)
		{
			//total_cost
			total_cost += arrUser[user_id - 1].using_period * arrComp[arrUser[user_id - 1].comp_id_which_is_used - 1].fee_per_day;
		}


		//"T"
		public void OneDayLater(int user_id)
		{ 
			//요구한 기간이 되었을때
			if (arrUser[user_id - 1].using_period >= arrComp[arrUser[user_id - 1].comp_id_which_is_used - 1].days_requested)
			{
				//아직 반납이 안되어있다면
				if (arrComp[arrUser[user_id - 1].comp_id_which_is_used - 1].Avail == false)
				{ 
					this.ReturnFromUser(user_id);
					//sw.ReadLine("Time for ~~~~");
				}
			}

		}

		//"S"
		public int WriteTotalCost()
		{
			return (total_cost);
		}
		public void WriteComputerList(ref StreamWriter sw)
		{
			for (int i = 1; i <= arrComp.Length; i++)
			{
				sw.WriteLine("({0}) ", i);
				arrComp[i - 1].CompInfo(ref sw);
            }
        }
        public void WriteUserList(ref StreamWriter sw)
        {
			for (int i = 1; i <= arrUser.Length; i++)
			{
				sw.WriteLine("({0}) ", i);
				arrUser[i - 1].UserInfo(ref sw);
            }
        }

        public ComputerManager()
		{
		}
	}
}
