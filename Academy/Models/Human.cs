using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Academy.Models
{
	internal class Human
	{
		int id;
		string last_name;
		string first_name;
		string middle_name;
		string birth_date;
		string email;
		string phone;
		Image photo;
		public Human
			(
				int id, string last_name, string first_name, string middle_name,
				string bitrh_date, string email, string phone, Image photo
			)
		{
			this.id = id;
			this.last_name = last_name;
			this.first_name = first_name;
			this.middle_name = middle_name;	
			this.birth_date = bitrh_date;
			this.email = email;	
			this.phone = phone;
			this.photo = photo;
		}
		public Human(Human outher)
		{
			this.id = outher.id;
			this.last_name= outher.last_name;
			this.first_name= outher.first_name;
			this.middle_name= outher.middle_name;
			this.birth_date= outher.birth_date;
			this.email= outher.email;
			this.phone= outher.phone;
			this.photo= outher.photo;

			//Конструктор копирования
		}
		public virtual string GetNames()
		{
			return "last_name, first_name, middle_name,birth_date,email,photo";
		}
		public virtual string GetValues()
		{
			return $"N'{last_name}',N'{first_name}',N'{middle_name}',N'{birth_date}',N'{email}',N'{phone}'";
		}
	}
}
