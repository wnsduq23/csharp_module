using System;
namespace assignment1
{
    public class Computer
    {
        protected int days_requested;// DR
        protected int days_left;// DL
        protected int days_used;// DU
        protected bool Avail = true;// if Avail = false, someone rent it.
        protected int comp_id;

        private int comp_num;
        private int[] comp_type_num = new int[3];
        protected int user_id_who_use_comp;

        //property, for save the total computer num
        public int ComputerNum
        {
            get { return comp_num; }
            set { comp_num = value; }
        }

        //indexer, for save the num different type of computer
        public int this[int idx]
        {
            get { return comp_type_num[idx]; }
            set { comp_type_num[idx] = value; }
        }

		public virtual void CompInfo(ref StreamWriter sw)
		{
			Console.WriteLine("if this output on console, it's ERROR2");
		}
    }

    public class Notebook : Computer
    {
        public const int fee_per_day = 10000;
        public const string type = "Notebook";
        public readonly string[] provide_service = { "internet", "scientific" };
        private int note_id = 0;

        public override void CompInfo(ref StreamWriter sw)
        {
            sw.WriteLine("type: Notebook, ");
            sw.WriteLine("ComId: {0} ", comp_id);//what is comid?
            sw.WriteLine("NoteId: {0} ", note_id);
            sw.WriteLine("Used for: {0} ", provide_service);
            sw.WriteLine("Avail: {0} ", Avail);
            if (Avail == false)
            {
                sw.WriteLine("(UserId:{0}, DR:{1}, DL:{2}, DU:{3})",user_id_who_use_comp, days_requested, days_left, days_used);
			}
            note_id++;
        }
        public Notebook()
        {
        }
    }
    public class Desktop : Computer
    {
        public const int fee_per_day = 13000;
        public const string type = "Desktop";
        public readonly string[] provide_service = { "internet", "scientific", "game" };
        private int desk_id = 0;

        public override void CompInfo(ref StreamWriter sw)
        {
            sw.WriteLine("type: desktop, ");
            sw.WriteLine("ComId: {0} ", comp_id);//what is comid?
            sw.WriteLine("deskId: {0} ", desk_id);
            sw.WriteLine("Used for: {0} ", provide_service);
            sw.WriteLine("Avail: {0} ", Avail);
            if (Avail == false)
            {
                sw.WriteLine("(UserId:{0}, DR:{1}, DL:{2}, DU:{3})",user_id_who_use_comp, days_requested, days_left, days_used);
			}
            desk_id++;
        }
        public Desktop()
        { }
    }
    public class Netbook : Computer
    {
        public const int fee_per_day = 7000;
        public const string type = "Netbook";
        public readonly string[] provide_service = { "internet" };
        private int net_id = 0;

        public override void CompInfo(ref StreamWriter sw)
        {
            sw.WriteLine("type: Netbook, ");
            sw.WriteLine("ComId: {0} ", comp_id);//what is comid?
            sw.WriteLine("NetId: {0} ", net_id);
            sw.WriteLine("Used for: {0} ", provide_service);
            sw.WriteLine("Avail: {0} ", Avail);
            if (Avail == false)
            {
                sw.WriteLine("(UserId:{0}, DR:{1}, DL:{2}, DU:{3})",user_id_who_use_comp, days_requested, days_left, days_used);
			}
            net_id++;
        }
        public Netbook()
        {
        }
    }
}