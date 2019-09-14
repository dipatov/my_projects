using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForHotel
{
	static public class AllForms
	{
		static public Booked booked = new Booked();
		static public InfoBooking infoBooking = new InfoBooking();
		static public InfoNumbers infoNumbers= new InfoNumbers();
		static public MenuGuest menuGuest = new MenuGuest();
		static public Offers offers;
		static public Profile profile = new Profile();
		static public Registration registration = new Registration();
		static public Types types = new Types();
		static public CancBooking cancBooking = new CancBooking();
		static public Anketa anketa = new Anketa();
		static public ChangePass changePass = new ChangePass();
		static public BookingSettle bookingSettle = new BookingSettle();
		static public FaceSettling faceSettling = new FaceSettling();
		static public InfoGuests infoGuests = new InfoGuests();
		static public ReceptionistMenu receptionistMenu = new ReceptionistMenu();
		static public Unsettling unsettling = new Unsettling();
		static public CleanerMenu CleanerMenu = new CleanerMenu();
	}
}
