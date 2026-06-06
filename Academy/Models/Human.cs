using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
namespace Academy.Models
{
	internal class Human
	{
		internal int id;
		internal string last_name;
		internal string first_name;
		internal string middle_name;
		internal string birth_date;
		internal string email;
		internal string phone;
		internal Image photo;
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
		public Human(object[] values)
		{
			this.id = (int)values[0];
			this.last_name		= values[1].ToString();
			this.first_name		= values[2].ToString();
			this.middle_name	= values[3].ToString();
			this.birth_date		= Convert.ToDateTime(values[4]).ToString("yyyy-MM-dd");
			this.email			= values[5].ToString();
			this.phone			= values[6].ToString();
			if (values[7] as byte[] != null)
			{
				MemoryStream ms = new MemoryStream(values[7] as byte[]);
				this.photo = Image.FromStream(ms);
				//ms.Dispose();
			}
		}
		public virtual string GetNames()
		{
			return "last_name, first_name, middle_name,birth_date,email,phone";
		}
		public virtual string GetValues()
		{
			return $"N'{last_name}',N'{first_name}',N'{middle_name}',N'{birth_date}',N'{email}',N'{phone}'";
		}
		public virtual string GetUpdateExpression()
		{
			return
				$"last_name = N'{last_name}'," +
				$"first_name = N'{first_name}'," +
				$"middle_name = N'{middle_name}'," +
				$"birth_date = N'{birth_date}'," +
				$"email = N'{email}'," +
				$"phone = N'{phone}'";
		}
		public byte[] SerializePhoto()
		{
			using (MemoryStream ms = new MemoryStream())
			{
				photo.Save(ms, photo.RawFormat);
				return ms.ToArray();
			}
		}
	}
}
