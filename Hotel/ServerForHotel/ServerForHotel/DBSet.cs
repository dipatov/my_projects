using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;

namespace ServerForHotel
{
	static class DBSet
	{
		public static DataSet ds;
		volatile public static SqlDataAdapter bookingfil, users, numbers, settling, guests, types,users2,guPh,guEm;
		public static ArrayList allTypes=new ArrayList();
		public static List<string> allNumbers = new List<string>();
		public static List<string> allGuest = new List<string>();
		public static List<string> allSetles = new List<string>();

		public static void fill()
		{
			SqlCommandBuilder commandBuilder;
			settling = new SqlDataAdapter("SELECT * FROM Settling", DB.connection);
			users2 = new SqlDataAdapter("SELECT * FROM Users", DB.connection);
			guPh = new SqlDataAdapter("SELECT Id,Phone, Email FROM Guest", DB.connection);
			guEm = new SqlDataAdapter("SELECT Id,Phone, Email FROM Guest", DB.connection);
			users = new SqlDataAdapter("SELECT Guest.Id,Login, Password,Role, Name, LastName, MiddleName, Phone, PassportSeria, PassportNamber, Email FROM Users LEFT JOIN Guest ON Users.Guest=Guest.Id", DB.connection);
			guests = new SqlDataAdapter("SELECT Id,Login,Name, LastName, MiddleName, Phone, PassportSeria, PassportNamber, Email FROM Guest LEFT JOIN Users ON Users.Guest=Guest.Id", DB.connection);
			types = new SqlDataAdapter("SELECT * FROM TypeNumber", DB.connection);
			numbers = new SqlDataAdapter("SELECT Number, Floor, TypeNumber.Name, TypeNumber.AmountOfGuets, Free, CountPerDay, IsClear FROM RoomNumber INNER JOIN  TypeNumber ON Type=Id", DB.connection);
			bookingfil = new SqlDataAdapter("SELECT Booking.Id, RoomNumber.Number,SettleDate, UnsettleDate,Guest,AmoungOfDays,AmountOfGuest,Count FROM Booking  INNER JOIN RoomNumber ON RoomNumber.Number=Booking.Number INNER JOIN TypeNumber ON TypeNumber.Id=RoomNumber.Type", DB.connection);
			ds = new DataSet("Hotel");
			types.FillSchema(ds, SchemaType.Source, "TypeNumber");
			types.Fill(ds, "TypeNumber");
			numbers.FillSchema(ds, SchemaType.Source, "RoomNumber");
			numbers.Fill(ds, "RoomNumber");
			allType();
			allNumber();
			guPh.UpdateCommand = new SqlCommand("ChangePhone", DB.connection);
			guPh.UpdateCommand.CommandType = CommandType.StoredProcedure;
			guPh.UpdateCommand.Parameters.Add(new SqlParameter("@Guest", SqlDbType.Int, 1000, "Id"));
			guPh.UpdateCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 255, "Phone"));
			guPh.FillSchema(ds, SchemaType.Source, "GuPH");
			guPh.Fill(ds, "GuPh");
			guEm.UpdateCommand = new SqlCommand("ChangeeEmail", DB.connection);
			guEm.UpdateCommand.CommandType = CommandType.StoredProcedure;
			guEm.UpdateCommand.Parameters.Add(new SqlParameter("@Guest", SqlDbType.Int, 1000, "Id"));
			guEm.UpdateCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 255, "Email"));
			guEm.FillSchema(ds, SchemaType.Source, "GuEm");
			guEm.Fill(ds, "GuEm");
			users2.UpdateCommand = new SqlCommand("ChangePas", DB.connection);
			users2.UpdateCommand.CommandType = CommandType.StoredProcedure;
			users2.UpdateCommand.Parameters.Add(new SqlParameter("@Login", SqlDbType.NVarChar, 255, "Login"));
			users2.UpdateCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 255, "Password"));
			users2.FillSchema(ds, SchemaType.Source, "Users2");
			users2.Fill(ds, "Users2");
			bookingfil.InsertCommand = new SqlCommand("AddBook", DB.connection);
			bookingfil.InsertCommand.CommandType = CommandType.StoredProcedure;
			bookingfil.InsertCommand.Parameters.Add(new SqlParameter("@guest",SqlDbType.Int,1000,"Guest"));
			bookingfil.InsertCommand.Parameters.Add(new SqlParameter("@guests", SqlDbType.Int, 1000, "AmountOfGuest"));
			bookingfil.InsertCommand.Parameters.Add(new SqlParameter("@settle", SqlDbType.Date, 1000, "SettleDate"));
			bookingfil.InsertCommand.Parameters.Add(new SqlParameter("@amount", SqlDbType.Int, 1000, "AmoungOfDays"));
			bookingfil.InsertCommand.Parameters.Add(new SqlParameter("@count", SqlDbType.Int, 1000, "Count"));
			bookingfil.InsertCommand.Parameters.Add(new SqlParameter("@number", SqlDbType.Int, 1000, "Number"));
			bookingfil.DeleteCommand = new SqlCommand("DelBook", DB.connection);
			bookingfil.DeleteCommand.CommandType = CommandType.StoredProcedure;
			bookingfil.DeleteCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 1000, "Id"));
			bookingfil.FillSchema(ds, SchemaType.Source, "BookingFil");
			bookingfil.Fill(ds, "BookingFil");
			commandBuilder = new SqlCommandBuilder(users);
			users.InsertCommand = new SqlCommand("CreateUser", DB.connection);
			users.InsertCommand.CommandType = CommandType.StoredProcedure;
			users.InsertCommand.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar, 100, "Login"));
			users.InsertCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 100, "Password"));
			users.InsertCommand.Parameters.Add(new SqlParameter("@role", SqlDbType.NVarChar, 100, "Role"));
			users.FillSchema(ds, SchemaType.Source, "Users");
			users.Fill(ds, "Users");
			guests.InsertCommand = new SqlCommand("NewGuest", DB.connection);
			guests.InsertCommand.CommandType = CommandType.StoredProcedure;
			guests.InsertCommand.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar, 50, "Login"));
			guests.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
			guests.InsertCommand.Parameters.Add(new SqlParameter("@lName", SqlDbType.NVarChar, 50, "LastName"));
			guests.InsertCommand.Parameters.Add(new SqlParameter("@mName", SqlDbType.NVarChar, 50, "MiddleName"));
			guests.InsertCommand.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar, 50, "Phone"));
			guests.InsertCommand.Parameters.Add(new SqlParameter("@seria", SqlDbType.NVarChar, 50, "PassportSeria"));
			guests.InsertCommand.Parameters.Add(new SqlParameter("@number", SqlDbType.NVarChar, 50, "PassportNamber"));
			guests.InsertCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 50, "Email"));
			guests.FillSchema(ds, SchemaType.Source, "Guest");
			guests.Fill(ds, "Guest");
			allGuests();
			settling.FillSchema(ds, SchemaType.Source, "Settling");
			settling.Fill(ds, "Settling");
			allSettles();
		}

		public static void allSettles()
		{
			allSetles = new List<string>();
			var qu = from settle in ds.Tables["Settling"].AsEnumerable()
					 select new { id = settle["Id"], guest = settle["Guest"], number = settle["Number"], guests = settle["AmountOfGuest"], settledate = settle["SettleDate"], unsettledate=settle["UnsettleDate"], count=settle["Count"] };
			foreach (var settle in qu)
			{
				allSetles.Add((string)"NEWSETTLE#"+settle.id+":"+settle.guest + ":" + settle.number + ":" + settle.guests + ":" + getstrindate((DateTime)settle.settledate) + ":" + getstrindate((DateTime)settle.unsettledate) + ":" + settle.count);
			}
		}

		public static void allType()
		{
			allTypes = new ArrayList();
			var qu = from types in ds.Tables["TypeNumber"].AsEnumerable()
					 select new { id = types["Id"], name = types["Name"], amount = types["Amount"], guests = types["AmountOfGuets"], food = types["Food"] };
			foreach(var type in qu)
			{
				allTypes.Add((string)"NEWTYPE#" + type.name + ":" + type.amount + ":" + type.guests + ":"+type.food+":"+allTypes.Count);
			}
		}

		public static void allNumber()
		{
			var qu = from number in ds.Tables["RoomNumber"].AsEnumerable()
					 select new { number = number["Number"], floor = number["Floor"], type = number["Name"], free = number["Free"], countPerDay = number["CountPerDay"], clear=number["IsClear"] };
			foreach (var number in qu.Distinct())
			{
				allTypes.Add((string)"NEWNUMBER#" + number.number + ":" + number.floor + ":" + number.type + ":" + number.free+":"+number.countPerDay+":"+number.clear);
			}
		}

		public static void allGuests()
		{
			var qu = from guest in ds.Tables["Guest"].AsEnumerable()
					 select new {id=guest["Id"], name = guest["Name"], lName = guest["LastName"], mName = guest["MiddleName"], phone = guest["Phone"], seria = guest["PassportSeria"], number = guest["PassportNamber"], email = guest["Email"] };
			foreach (var guest in qu.Distinct())
			{
				allGuest.Add((string)"NEWGUEST#" +guest.id+":"+ guest.name + ":" + guest.lName + ":" + guest.mName + ":" + guest.phone + ":" + guest.seria + ":" + guest.number + ":" + guest.email);
			}
		}

		public static string Login(string message,ClientObject client)
		{
			string[] words = message.Split(':');
			if (words.Length != 2)
			{
				return "BADLOGIN#";
			}
			var qu = from users in ds.Tables["Users"].AsEnumerable()
					 where (string)users["Login"] == words[0] && (string)users["Password"] == words[1]
					 select new { id=users["Id"],login=users["Login"], role = users["Role"],name=users["Name"], lName=users["LastName"], mName=users["MiddleName"], phone=users["Phone"], seria=users["PassportSeria"], namber=users["PassportNamber"], email=users["Email"] };
			int s = 0;
			string ret="";
			foreach(var user in qu)
			{
				s++;
				if ((string)user.role == "Guest")
				{
					client.role = Role.Guest;
				}
				if ((string)user.role == "Reseptionist")
				{
					client.role = Role.Receptionis;
				}
				if ((string)user.role == "Cleaner")
				{
					client.role = Role.Cleaner;
				}
				ret = "GOODLOGIN#"+user.login+":"+user.role+":"+user.name+":"+user.lName+":"+user.mName+":"+user.phone+":"+user.seria+":"+user.namber+":"+user.email+":"+user.id;
			}
			if (s == 0)
			{
				return "BADLOGIN#";
			}
			return ret;
		}

		public static string Registration(string message)
		{
			string[] words = message.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
			if (words.Length != 2)
			{
				return "BADREGISTRATION#";
			}
			var qu = from users in ds.Tables["Users"].AsEnumerable()
					 where (string)users["Login"] == words[0]
					 select new { role = users["Role"] };
			int s = 0;
			foreach (var user in qu)
			{
				s++;
			}
			if (s != 0)
			{
				return "BADREGISTRATION#";
			}
			DataTable dt = ds.Tables["Users"];
			DataRow dr = dt.NewRow();
			dr["Login"] = words[0];
			dr["Password"] = words[1];
			dr["Role"] = "Guest";
			dt.Rows.Add(dr);
			users.Update(ds,"Users");
			ds.AcceptChanges();
			return "GOODREGISTRATION#";
		}

		public static string newGuest(string message, ClientObject client)
		{
			string[] words = message.Split(':');
			DataTable dt = ds.Tables["Guest"];
			DataRow dr = dt.NewRow();
			Console.WriteLine(0);
			dr["Login"] = words[0];
			dr["Name"] = words[1];
			dr["LastName"] = words[2];
			dr["MiddleName"] = words[3];
			dr["Phone"] = words[4];
			dr["PassportSeria"] = words[5];
			dr["PassportNamber"] = words[6];
			dr["Email"] = words[7];
			dt.Rows.Add(dr);
			guests.Update(ds, "Guest");
			ds.AcceptChanges();
			users.Update(ds, "Users");
			ds.AcceptChanges();
			ds.Tables["Users"].Select("Login='" + words[0] + "'")[0]["Name"] = words[1];
			ds.Tables["Users"].Select("Login='" + words[0] + "'")[0]["LastName"] = words[2];
			ds.Tables["Users"].Select("Login='" + words[0] + "'")[0]["MiddleName"] = words[3];
			ds.Tables["Users"].Select("Login='" + words[0] + "'")[0]["Phone"] = words[4];
			ds.Tables["Users"].Select("Login='" + words[0] + "'")[0]["PassportSeria"] = words[5];
			ds.Tables["Users"].Select("Login='" + words[0] + "'")[0]["PassportNamber"] = words[6];
			ds.Tables["Users"].Select("Login='" + words[0] + "'")[0]["Email"] = words[7];
			Program.broadcastMessage("UPDATEGUESTS#", Role.Receptionis);
			allGuest.Add("NEWGUEST#" + words[1] + ":" + words[2] + ":" + words[3] + ":" + words[4] + ":" + words[5] + ":" + words[6] + ":" + words[7]);
			Program.broadcastMessage("NEWGUEST#" + dt.Select("Login='" + words[0] + "'")[0]["Id"]+":"+ words[1] + ":" + words[2] + ":" + words[3] + ":" + words[4] + ":" + words[5] + ":" + words[6] + ":" + words[7], Role.Receptionis);
			return "GOODANKETA#"+message+":"+dt.Select("Login='"+words[0]+"'")[0]["Id"];
		}
		public static void filters(ClientObject client, string message)
		{
			client.filters = new List<string>();
			string[] words = message.Split(':');
			var qu = from bookingfil in ds.Tables["BookingFil"].AsEnumerable()
					 where !(((comparedatemen(words[0], getstrindate((DateTime)bookingfil["SettleDate"]))&& comparedatemen(words[5], getstrindate((DateTime)bookingfil["SettleDate"]))) || (comparedatebol(words[0], getstrindate((DateTime)bookingfil["SettleDate"])) && comparedatebol(words[5], getstrindate((DateTime)bookingfil["SettleDate"])))))
					 select new { number = bookingfil["Number"] };
			foreach(var book in qu.Distinct())
			{
				client.filters.Add("NEWFILTER#" + book.number );
			}
			var qt = from number in ds.Tables["RoomNumber"].AsEnumerable()
					 where !((int)number["AmountOfGuets"]>=Int32.Parse(words[2])&&(int)number["CountPerDay"]*Int32.Parse(words[1])>=Int32.Parse(words[3])&& (int)number["CountPerDay"] * Int32.Parse(words[1]) <= Int32.Parse(words[4]))
					 select new { number = number["Number"]};
			foreach (var book in qt.Distinct())
			{
				client.filters.Add("NEWFILTER#" + book.number);
			}
		}

		static string getstrindate(DateTime date)
		{
			return date.Day + "." + date.Month + "." + date.Year;
		}

		static bool comparedatemen(string message1, string message2)
		{
			string[] date1 = message1.Split('.'), date2 = message2.Split('.');
			if (Int32.Parse(date1[2]) != Int32.Parse(date2[2]))
			{
				return Int32.Parse(date1[2]) < Int32.Parse(date2[2]);
			}
			if(Int32.Parse(date1[1]) != Int32.Parse(date2[1]))
			{
				return Int32.Parse(date1[1]) < Int32.Parse(date2[1]);
			}
			return Int32.Parse(date1[0]) < Int32.Parse(date2[0]);
		}

		static bool comparedatebol(string message1, string message2)
		{
			string[] date1 = message1.Split('.'), date2 = message2.Split('.');
			if (Int32.Parse(date1[2]) != Int32.Parse(date2[2]))
			{
				return Int32.Parse(date1[2]) > Int32.Parse(date2[2]);
			}
			if (Int32.Parse(date1[1]) != Int32.Parse(date2[1]))
			{
				return Int32.Parse(date1[1]) > Int32.Parse(date2[1]);
			}
			return Int32.Parse(date1[0]) > Int32.Parse(date2[0]);
		}
		static public string addbook(string message)
		{
			string[] words = message.Split(':');
			var qu = from bookingfil in ds.Tables["BookingFil"].AsEnumerable()
					 where !(((comparedatemen(words[1], getstrindate((DateTime)bookingfil["SettleDate"])) && comparedatemen(words[5], getstrindate((DateTime)bookingfil["SettleDate"]))) || (comparedatebol(words[1], getstrindate((DateTime)bookingfil["SettleDate"])) && comparedatebol(words[5], getstrindate((DateTime)bookingfil["SettleDate"])))))&&(int)bookingfil["Number"]==Int32.Parse(words[0])
					 select new { number = bookingfil["Number"] };
			if (qu.Count() != 0)
			{
				return "BADBOOK#";
			}
			DataTable dt = ds.Tables["BookingFil"];
			DataRow dr = dt.NewRow();
			dr["Number"] = words[0];
			dr["SettleDate"] = words[1];
			dr["AmoungOfDays"] = words[2];
			dr["AmountOfGuest"] = words[3];
			dr["Count"] = words[4];
			dr["Guest"] = words[6];
			dt.Rows.Add(dr);
			bookingfil.Update(ds, "BookingFil");
			ds.AcceptChanges();
			Program.broadcastMessage("UPDATEBOOKINGS#", Role.Receptionis);
			return "GOODBOOK#";
		}

		public static void booklist(ClientObject client, string message)
		{
			client.bookings = new List<string>();
			string[] words = message.Split(':');
			var qu = from bookingfil in ds.Tables["BookingFil"].AsEnumerable()
					 where (Int32)bookingfil["Guest"] == Int32.Parse(message)
					 select new {id=bookingfil["Id"], number = bookingfil["Number"], guests= bookingfil["AmountOfGuest"], date=bookingfil["SettleDate"],days=bookingfil["AmoungOfDays"],count=bookingfil["Count"] };
			foreach (var book in qu.Distinct())
			{
				DateTime date = (DateTime)book.date;
				client.bookings.Add("NEWBOOKING#" + book.id+":"+book.number+":"+book.guests+":"+date.Day+"."+date.Month+"."+date.Year+":"+book.days+":"+book.count);
			}
			client.Send("FOUNDBOOKINGS#"+client.bookings.Count());
		}

		public static void booklist(ClientObject client)
		{
			client.bookings = new List<string>();
			var qu = from bookingfil in ds.Tables["BookingFil"].AsEnumerable()
					 select new { id = bookingfil["Id"], number = bookingfil["Number"], guests = bookingfil["AmountOfGuest"], date = bookingfil["SettleDate"], days = bookingfil["AmoungOfDays"], count = bookingfil["Count"] };
			foreach (var book in qu.Distinct())
			{
				DateTime date = (DateTime)book.date;
				client.bookings.Add("NEWBOOKING#" + book.id + ":" + book.number + ":" + book.guests + ":" + date.Day + "." + date.Month + "." + date.Year + ":" + book.days + ":" + book.count);
			}
			client.Send("FOUNDBOOKINGS#" + client.bookings.Count());
		}

		static public void dellbook(string message)
		{
			DataRow[] rows= ds.Tables["BookingFil"].Select("Id=" + message);
			foreach(var row in rows)
			{
				row.Delete();
			}
			bookingfil.Update(ds.Tables["BookingFil"]);
			ds.AcceptChanges();
			Program.broadcastMessage("UPDATEBOOKINGS#", Role.Receptionis);
		}
		public static string changePass(string message)
		{
			string[] words = message.Split(':');
			var qu = from users in ds.Tables["Users"].AsEnumerable()
					 where (string)users["Login"] == words[0] && (string)users["Password"] == words[1]
					 select new { id = users["Id"],password=users["Password"]};
			if (qu.Count() == 0)
			{
				return "BADPASS#";
			}
			DataTable dt = ds.Tables["Users2"];
			var current = dt.Select("Login = '" + words[0] + "'")[0];
			current.BeginEdit();
			current["Password"] = words[2].Split(' ')[0];
			current.EndEdit();
			users2.Update(ds, "Users2");
			ds.AcceptChanges();
			ds.Tables["Users"].Clear();
			ds.Tables["Guest"].Clear();
			users.FillSchema(ds, SchemaType.Source, "Users");
			users.Fill(ds, "Users");
			guests.FillSchema(ds, SchemaType.Source, "Guest");
			guests.Fill(ds, "Guest");
			return "GOODPASS#";
		}
		public static string changePhone(string message)
		{
			string[] words = message.Split(':');
			DataTable dt = ds.Tables["GuPh"];
			var current = dt.Select("Id = " + words[0])[0];
			current.BeginEdit();
			current["Phone"] = words[1];
			current.EndEdit();
			guPh.Update(ds, "GuPh");
			ds.AcceptChanges();
			ds.Tables["Users"].Clear();
			ds.Tables["Guest"].Clear();
			users.FillSchema(ds, SchemaType.Source, "Users");
			users.Fill(ds, "Users");
			guests.FillSchema(ds, SchemaType.Source, "Guest");
			guests.Fill(ds, "Guest");
			return "GOODPHONE#";
		}
		public static string changeEmail(string message)
		{
			string[] words = message.Split(':');
			DataTable dt = ds.Tables["GuEm"];
			var current = dt.Select("Id = " + words[0])[0];
			current.BeginEdit();
			current["Email"] = words[1];
			current.EndEdit();
			guEm.Update(ds, "GuEm");
			ds.AcceptChanges();
			ds.Tables["Users"].Clear();
			ds.Tables["Guest"].Clear();
			users.FillSchema(ds, SchemaType.Source, "Users");
			users.Fill(ds, "Users");
			guests.FillSchema(ds, SchemaType.Source, "Guest");
			guests.Fill(ds, "Guest");
			return "GOODEMAIL#";
		}
		public static void unsettle(string message)
		{
			numbers.UpdateCommand = new SqlCommand("UpdNumber", DB.connection);
			numbers.UpdateCommand.CommandType = CommandType.StoredProcedure;
			numbers.UpdateCommand.Parameters.Add(new SqlParameter("@number", SqlDbType.Int, 1000, "Number"));
			numbers.UpdateCommand.Parameters.Add(new SqlParameter("@clear", SqlDbType.Int, 1000, "IsClear"));
			numbers.UpdateCommand.Parameters.Add(new SqlParameter("@free", SqlDbType.Int, 1000, "Free"));
			string[] words = message.Split(':');
			foreach (var number in ds.Tables["RoomNumber"].Select("Number=" + words[0]))
			{
				number.BeginEdit();
				number["Free"] = 1;
				number["IsClear"] = words[1] == "1" ? "True" : "False";
				number.EndEdit();
			}
			numbers.Update(ds, "RoomNumber");
			ds.AcceptChanges();
			allType();
			allNumber();
			Program.broadcastMessage((string)allTypes[0], Role.Guest);
			Program.broadcastMessage((string)allTypes[0], Role.Receptionis);
			Program.broadcastMessage((string)allTypes[0], Role.Cleaner);
		}
		public static void booksettle(string message)
		{
			settling.InsertCommand = new SqlCommand("BookingSettle", DB.connection);
			settling.InsertCommand.CommandType = CommandType.StoredProcedure;
			settling.InsertCommand.Parameters.Add(new SqlParameter("@booking", SqlDbType.Int, 1000, "Booking"));
			DataTable dt = ds.Tables["Settling"];
			DataRow dr = dt.NewRow();
			dr["Booking"] = message;
			dt.Rows.Add(dr);
			settling.Update(ds, "Settling");
			ds.AcceptChanges();
			ds.Tables["Settling"].Clear();
			settling.FillSchema(ds, SchemaType.Source, "Settling");
			settling.Fill(ds, "Settling");
			ds.Tables["RoomNumber"].Clear();
			numbers.FillSchema(ds, SchemaType.Source, "RoomNumber");
			numbers.Fill(ds, "RoomNumber");
			allType();
			allNumber();
			allSettles();
			Program.broadcastMessage((string)allSetles[allSetles.Count-1], Role.Receptionis);
			Program.broadcastMessage((string)allTypes[0], Role.Guest);
			Program.broadcastMessage((string)allTypes[0], Role.Receptionis);
			Program.broadcastMessage((string)allTypes[0], Role.Cleaner);
		}
		public static void settle(string message)
		{
			settling.InsertCommand = new SqlCommand("Settl", DB.connection);
			settling.InsertCommand.CommandType = CommandType.StoredProcedure;
			settling.InsertCommand.Parameters.Add(new SqlParameter("@guest", SqlDbType.Int, 1000, "Guest"));
			settling.InsertCommand.Parameters.Add(new SqlParameter("@settledate", SqlDbType.Date, 1000, "SettleDate"));
			settling.InsertCommand.Parameters.Add(new SqlParameter("@unsettledate", SqlDbType.Date, 1000, "UnsettleDate"));
			settling.InsertCommand.Parameters.Add(new SqlParameter("@guests", SqlDbType.Int, 1000, "AmountOfGuest"));
			settling.InsertCommand.Parameters.Add(new SqlParameter("@number", SqlDbType.Int, 1000, "Number"));
			string[] words = message.Split(':');
			DataTable dt = ds.Tables["Settling"];
			DataRow dr = dt.NewRow();
			dr["Guest"] = words[0];
			dr["SettleDate"] = words[1];
			dr["UnsettleDate"] = words[2];
			dr["AmountOfGuest"] = words[3];
			dr["Number"] = words[4];
			dt.Rows.Add(dr);
			settling.Update(ds, "Settling");
			ds.AcceptChanges();
			ds.Tables["Settling"].Clear();
			settling.FillSchema(ds, SchemaType.Source, "Settling");
			settling.Fill(ds, "Settling");
			allType();
			ds.Tables["RoomNumber"].Clear();
			numbers.FillSchema(ds, SchemaType.Source, "RoomNumber");
			numbers.Fill(ds, "RoomNumber");
			allNumber();
			allSettles();
			Program.broadcastMessage((string)allSetles[allSetles.Count - 1], Role.Receptionis);
			Program.broadcastMessage((string)allTypes[0], Role.Guest);
			Program.broadcastMessage((string)allTypes[0], Role.Receptionis);
			Program.broadcastMessage((string)allTypes[0], Role.Cleaner);
		}
	}
}
