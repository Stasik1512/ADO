using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy.Models
{
	internal class Teacher : Human
	{
		DateTime work_since;

		public Teacher
			(
				int id, string last_name, string first_name, string middle_name,
				string birth_date, string email, string phone, Image photo,
				DateTime work_since
			) : base(id, last_name, first_name, middle_name, birth_date, email, phone, photo)
		{
			this.work_since = work_since;
		}

		public Teacher(Human human, DateTime work_since) : base(human)
		{
			this.work_since = work_since;
		}

		public override string GetNames()
		{
			return base.GetNames() + ",[work_since]";
		}

		public override string GetValues()
		{
			return base.GetValues() + $",'{work_since:yyyy-MM-dd}'";
		}
	}
}